using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq; // Agrega esta línea para usar LINQ
using System.Windows.Forms;

namespace YacoPila
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.MaximizeBox = false; // Deshabilita la maximización

        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            string rutaArchivoCSV = "stock.csv"; // Ruta al archivo CSV

            // Obtener los valores de los TextBox
            string codigo = txtCodigo.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string cantidad = txtCantidad.Text;

            try
            {
                // Cargar los datos existentes del archivo CSV en una lista
                List<Producto> stockExistente = CargarDatosDesdeCSV(rutaArchivoCSV);

                // Buscar si el código ya existe en la lista
                Producto productoExistente = stockExistente.FirstOrDefault(p => p.CODIGO == codigo);

                if (productoExistente != null)
                {
                    // Si el código ya existe, suma la cantidad ingresada
                    if (int.TryParse(cantidad, out int cantidadIngresada))
                    {
                        productoExistente.CANTIDAD += cantidadIngresada;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    // Si el código no existe, agrega una nueva entrada a la lista
                    if (int.TryParse(cantidad, out int cantidadIngresada))
                    {
                        stockExistente.Add(new Producto
                        {
                            CODIGO = codigo,
                            MARCA = marca,
                            MODELO = modelo,
                            CANTIDAD = cantidadIngresada
                        });
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Guarda la lista actualizada en el archivo CSV
                GuardarDatosEnCSV(rutaArchivoCSV, stockExistente);

                // Limpiar los TextBox después de agregar los datos
                txtCodigo.Clear();
                txtMarca.Clear();
                txtModelo.Clear();
                txtCantidad.Clear();

                // Mostrar mensaje de éxito y cerrar el formulario
                MessageBox.Show("Stock agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario actual
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar datos al archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clase Producto
        public class Producto
        {
            public string CODIGO { get; set; }
            public string MARCA { get; set; }
            public string MODELO { get; set; }
            public int CANTIDAD { get; set; }
        }

        // Método para cargar los datos existentes del archivo CSV en una lista
        private List<Producto> CargarDatosDesdeCSV(string rutaArchivoCSV)
        {
            using (var reader = new StreamReader(rutaArchivoCSV))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";", // Establece el delimitador correcto según tu archivo CSV
                HasHeaderRecord = true // Indica que el archivo tiene una fila de encabezados
            }))
            {
                var records = csv.GetRecords<Producto>().ToList();
                return records;
            }
        }

        // Método para guardar una lista de productos en el archivo CSV
        private void GuardarDatosEnCSV(string rutaArchivoCSV, List<Producto> productos)
        {
            using (var writer = new StreamWriter(rutaArchivoCSV))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";", // Establece el delimitador correcto según tu archivo CSV
                HasHeaderRecord = true // Indica que el archivo tiene una fila de encabezados
            }))
            {
                csv.WriteRecords(productos);
            }
        }
    }
}

