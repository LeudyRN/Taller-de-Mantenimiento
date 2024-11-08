using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Taller_de_Mantenimiento
{
    internal class ConsultaFactura
    {

        private ConexionMysql conexionMysql;
        private List<Factura> mfactura;

        public ConsultaFactura()
        {
            conexionMysql = new ConexionMysql();
            mfactura = new List<Factura>();

        }

        public List<Factura> getFactura(string filtro)
        {
            string query = @"
        SELECT f.id_factura, f.id_orden, f.fecha, 
               (SELECT SUM(do.subtotal) FROM detalles_ordenes_de_trabajo do WHERE do.id_orden = f.id_orden) AS total 
        FROM facturacion f";

            if (!string.IsNullOrEmpty(filtro))
            {
                query += " WHERE " +
                          "f.id_factura LIKE '%" + filtro + "%' OR " +
                          "f.id_orden LIKE '%" + filtro + "%' OR " +
                          "f.fecha LIKE '%" + filtro + "%' OR " +
                          "f.total LIKE '%" + filtro + "%';";
            }

            MySqlDataReader mReader = null;
            List<Factura> facturas = new List<Factura>();

            try
            {
                using (MySqlCommand mcomando = new MySqlCommand(query, conexionMysql.GetConnection()))
                {
                    mReader = mcomando.ExecuteReader();

                    while (mReader.Read())
                    {
                        Factura mFactura = new Factura
                        {
                            id_factura = mReader.GetInt32("id_factura"),
                            id_orden = mReader.GetInt32("id_orden"),
                            fecha = mReader.IsDBNull(mReader.GetOrdinal("fecha"))
                                    ? DateTime.MinValue
                                    : mReader.GetDateTime("fecha"),

                            // Aquí obtenemos el total calculado desde los detalles de la orden
                            total = mReader.IsDBNull(mReader.GetOrdinal("total"))
                                    ? 0
                                    : mReader.GetDecimal("total"),
                        };
                        facturas.Add(mFactura);
                    }
                }

                mReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return facturas;
        }

        internal bool GenerarFacturaPDF(int idOrden)
        {
            string queryTotal = @"
                    SELECT SUM(subtotal) AS total 
                    FROM detalles_ordenes_de_trabajo 
                    WHERE id_orden = @id_orden";

            decimal totalFactura = 0;

            using (MySqlCommand cmdTotal = new MySqlCommand(queryTotal, conexionMysql.GetConnection()))
            {
                cmdTotal.Parameters.AddWithValue("@id_orden", idOrden);

                object result = cmdTotal.ExecuteScalar();
                if (result != null)
                {
                    totalFactura = Convert.ToDecimal(result);
                }
            }

            if (totalFactura <= 0)
            {
                MessageBox.Show("No se encontraron detalles para la orden proporcionada.");
                return false;
            }

            string queryInsert = @"
                            INSERT INTO facturacion (id_orden, fecha, total) 
                            VALUES (@id_orden, @fecha, @total)";

            using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conexionMysql.GetConnection()))
            {
                cmdInsert.Parameters.AddWithValue("@id_orden", idOrden);
                cmdInsert.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmdInsert.Parameters.AddWithValue("@total", totalFactura);

                try
                {
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Factura generada con éxito.");

                    ExportarFacturaPDF(idOrden, totalFactura);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar la factura: " + ex.Message);
                    return false;
                }
            }
        }


        private void ExportarFacturaPDF(int idOrden, decimal totalFactura)
        {
            
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreArchivo = Path.Combine(desktopPath, $"Factura_{idOrden}.pdf");

            Document documento = new Document();

            try
            {
                PdfWriter.GetInstance(documento, new FileStream(nombreArchivo, FileMode.Create));
                documento.Open();

                string rutaLogo = @"D:\Descargas\logo.png";
                if (File.Exists(rutaLogo))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                    logo.ScaleToFit(100f, 100f);
                    logo.Alignment = Element.ALIGN_LEFT;
                    documento.Add(logo);
                }
                documento.Add(new Paragraph("AUTOLOGIC SYSTEM", FontFactory.GetFont("Arial", 18, Font.BOLD)));
                documento.Add(new Paragraph("Factura de Orden de Trabajo", FontFactory.GetFont("Arial", 14, Font.BOLD)));
                documento.Add(new Paragraph("------------------------------------------------"));

                documento.Add(new Paragraph($"ID de Orden: {idOrden}"));
                documento.Add(new Paragraph($"Fecha: {DateTime.Now.ToShortDateString()}"));
                documento.Add(new Paragraph("------------------------------------------------"));

                string queryDetalles = @"
            SELECT do.id_detalle, s.descripcion, do.subtotal 
            FROM detalles_ordenes_de_trabajo do
            JOIN servicios s ON do.id_servicio = s.id_servicio
            WHERE do.id_orden = @id_orden";

                using (MySqlCommand cmdDetalles = new MySqlCommand(queryDetalles, conexionMysql.GetConnection()))
                {
                    cmdDetalles.Parameters.AddWithValue("@id_orden", idOrden);
                    MySqlDataReader reader = cmdDetalles.ExecuteReader();

                    PdfPTable tabla = new PdfPTable(3);
                    tabla.AddCell("ID Detalle");
                    tabla.AddCell("Servicio");
                    tabla.AddCell("Subtotal");

                    while (reader.Read())
                    {
                        tabla.AddCell(reader["id_detalle"].ToString());
                        tabla.AddCell(reader["descripcion"].ToString());
                        tabla.AddCell(Convert.ToDecimal(reader["subtotal"]).ToString("0.00"));
                    }

                    documento.Add(tabla);
                    reader.Close();
                }

                documento.Add(new Paragraph("------------------------------------------------"));
                documento.Add(new Paragraph($"Total Factura: {totalFactura.ToString("0.00")}"));

                MessageBox.Show($"Factura exportada exitosamente en el escritorio como {nombreArchivo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la factura en PDF: " + ex.Message);
            }
            finally
            {
                documento.Close();
            }
        }

        internal bool GenerarFacturaEXCEL(int idOrden)
        {
            string queryTotal = @"
            SELECT SUM(subtotal) AS total 
            FROM detalles_ordenes_de_trabajo 
            WHERE id_orden = @id_orden";

            decimal totalFactura = 0;

            using (MySqlCommand cmdTotal = new MySqlCommand(queryTotal, conexionMysql.GetConnection()))
            {
                cmdTotal.Parameters.AddWithValue("@id_orden", idOrden);

                object result = cmdTotal.ExecuteScalar();
                if (result != null)
                {
                    totalFactura = Convert.ToDecimal(result);
                }
            }

            if (totalFactura <= 0)
            {
                MessageBox.Show("No se encontraron detalles para la orden proporcionada.");
                return false;
            }

            string queryInsert = @"
                 INSERT INTO facturacion (id_orden, fecha, total) 
                 VALUES (@id_orden, @fecha, @total)";

            using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conexionMysql.GetConnection()))
            {
                cmdInsert.Parameters.AddWithValue("@id_orden", idOrden);
                cmdInsert.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmdInsert.Parameters.AddWithValue("@total", totalFactura);

                try
                {
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Factura generada con éxito.");

                    ExportarFacturaExcel(idOrden, totalFactura);

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar la factura: " + ex.Message);
                    return false;
                }
            }
        }

        private void ExportarFacturaExcel(int idOrden, decimal totalFactura)
        {
        
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel no está instalado en este sistema.");
                return;
            }

            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Name = "Factura";

        
            worksheet.Cells[1, 1] = "ID de Orden";
            worksheet.Cells[1, 2] = "Fecha";
            worksheet.Cells[1, 3] = "Servicio";
            worksheet.Cells[1, 4] = "Total Factura";
  
            Excel.Range headerRange = worksheet.get_Range("A1", "E1");
            headerRange.Font.Bold = true;
            headerRange.Font.Size = 12;
            headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            worksheet.Columns[1].ColumnWidth = 15;
            worksheet.Columns[2].ColumnWidth = 15;
            worksheet.Columns[3].ColumnWidth = 30;
            worksheet.Columns[4].ColumnWidth = 15;

            worksheet.Cells[2, 1] = idOrden;
            worksheet.Cells[2, 2] = DateTime.Now.ToShortDateString();

            string queryDetalles = @"
                    SELECT do.id_detalle, s.descripcion, do.subtotal 
                    FROM detalles_ordenes_de_trabajo do
                    JOIN servicios s ON do.id_servicio = s.id_servicio
                    WHERE do.id_orden = @id_orden";

            int row = 2; 
            using (MySqlCommand cmdDetalles = new MySqlCommand(queryDetalles, conexionMysql.GetConnection()))
            {
                cmdDetalles.Parameters.AddWithValue("@id_orden", idOrden);
                MySqlDataReader reader = cmdDetalles.ExecuteReader();

                while (reader.Read())
                {
                    worksheet.Cells[row, 3] = reader["descripcion"].ToString(); 
                    worksheet.Cells[row, 4] = Convert.ToDecimal(reader["subtotal"]).ToString("0.00"); 
                    row++;
                }
                reader.Close();
            }

            worksheet.Cells[row, 4] = totalFactura.ToString("0.00"); 
            worksheet.Cells[row, 5] = "TOTAL"; 
       
            Excel.Range totalRange = worksheet.get_Range($"A{row}", $"E{row}");
            totalRange.Font.Bold = true;
            totalRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            totalRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            totalRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightYellow);

            Excel.Range dataRange = worksheet.get_Range("A1", $"E{row}");
            dataRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            dataRange.Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreArchivo = Path.Combine(desktopPath, $"Factura_{idOrden}.xlsx");
            workbook.SaveAs(nombreArchivo);

            workbook.Close(false);
            excelApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);

            MessageBox.Show($"Factura exportada exitosamente en el escritorio como {nombreArchivo}");
        }

        internal bool eliminarFactura(Factura mfactura)
        {
            string DELETE = "DELETE FROM facturacion WHERE id_factura = @id_factura";

            try
            {
                using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection()))
                {
                    mCommand.Parameters.AddWithValue("@id_factura", mfactura.id_factura);
                    return mCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
