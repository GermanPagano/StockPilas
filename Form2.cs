using CsvHelper;
using CsvHelper.Configuration;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq; // Agrega esta línea para usar LINQ
using System.Windows.Forms;

namespace YacoPila
{
    public partial class StockPilas : Form
    {
        private List<Producto> productos; // Agrega esta lista como campo de clase

        public StockPilas()
        {
            InitializeComponent();
            CenterToScreen(); // Centra el formulario en la pantalla
            CargarDatosDesdeCSV();

        }

        public class Producto
        {
            public string CODIGO { get; set; } // Cambia el tipo de dato a string
            public string MARCA { get; set; }
            public string MODELO { get; set; }
            public int CANTIDAD { get; set; }
        }

        public void CargarDatosDesdeCSV()
        {
            string rutaArchivoCSV = "./stock.csv";

            try
            {
                if (File.Exists(rutaArchivoCSV))
                {
                    using (var reader = new StreamReader(rutaArchivoCSV))
                    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ";", // Establece el delimitador correcto según tu archivo CSV
                        HasHeaderRecord = true // Indica que el archivo tiene una fila de encabezados
                    }))
                    {
                        var records = csv.GetRecords<Producto>().ToList();

                        if (records.Count < 1)
                        {
                            MessageBox.Show("No se encontraron datos en el archivo CSV.");
                            return;
                        }

                        // Crear columnas en el DataGridView con los nombres de las propiedades de Producto
                        foreach (var property in typeof(Producto).GetProperties())
                        {
                            dataGridView1.Columns.Add(property.Name, property.Name);
                        }

                        // Leer y mostrar los registros
                        foreach (var record in records)
                        {
                            dataGridView1.Rows.Add(record.CODIGO, record.MARCA, record.MODELO, record.CANTIDAD);
                        }
                        productos = records.ToList(); // Almacena los registros en la lista de productos
                    }
                }
                else
                {
                    MessageBox.Show("El archivo CSV no se encontró en la ubicación especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos desde el archivo CSV: {ex.Message}");
            }
        }

        public List<Producto> ObtenerProductos() // Agrega este método para obtener la lista
        {
            return productos;
        }

        // Método para actualizar la lista de productos
        public void ActualizarProductos(List<Producto> nuevaLista)
        {
            productos = nuevaLista;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Obtén el código del producto eliminado
                string codigoEliminado = selectedRow.Cells["CODIGO"].Value.ToString();

                // Elimina el producto de la lista de productos
                Producto productoAEliminar = productos.FirstOrDefault(p => p.CODIGO == codigoEliminado);
                if (productoAEliminar != null)
                {
                    productos.Remove(productoAEliminar);

                    // Actualiza el archivo CSV con la nueva lista de productos
                    ActualizarArchivoCSV(productos);
                }

                // Elimina la fila del DataGridView
                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        // Método para actualizar el archivo CSV con la lista de productos proporcionada
        private void ActualizarArchivoCSV(List<Producto> nuevaLista)
        {
            string nombreArchivo = "stock.csv";
            string rutaArchivoCSV = Path.Combine(Application.StartupPath, nombreArchivo);

            try
            {
                using (var writer = new StreamWriter(rutaArchivoCSV))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";",
                    HasHeaderRecord = true
                }))
                {
                    csv.WriteRecords(nuevaLista);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el archivo CSV: {ex.Message}");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo para guardar el archivo PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";
            saveFileDialog.FileName = "StockPilas.pdf"; // Nombre predeterminado del archivo PDF

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivoPDF = saveFileDialog.FileName;

                // Crear un documento PDF
                Document doc = new Document();

                try
                {
                    // Crear un escritor PDF
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivoPDF, FileMode.Create));

                    // Abrir el documento para editar
                    doc.Open();

                    // Crear una tabla para almacenar los datos del DataGridView
                    PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

                    // Agregar las columnas del DataGridView a la tabla
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(dataGridView1.Columns[i].HeaderText));
                        table.AddCell(cell);
                    }

                    // Agregar las filas y celdas del DataGridView a la tabla
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1[j, i].Value != null)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(dataGridView1[j, i].Value.ToString()));
                                table.AddCell(cell);
                            }
                            else
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(""));
                                table.AddCell(cell);
                            }
                        }
                    }

                    // Agregar la tabla al documento
                    doc.Add(table);

                    // Cerrar el documento
                    doc.Close();

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("El archivo PDF se ha generado y guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el archivo PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    doc.Close();
                }
            }
        }


    }
}

