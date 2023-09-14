using System;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

namespace YacoPila
{
    public partial class Form4 : Form
    {
        private StockPilas formulario2;

        public Form4()
        {
            InitializeComponent();
            formulario2 = new StockPilas();
            this.MaximizeBox = false; // Deshabilita la maximización

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Obtener la lista de productos desde Form2
            List<StockPilas.Producto> productos = formulario2.ObtenerProductos();

            // Obtener códigos únicos de la lista de productos
            List<string> codigosUnicos = productos.Select(producto => producto.CODIGO).Distinct().ToList();

            // Enlazar la lista de códigos al ComboBox
            ComboBoxCOD.DataSource = codigosUnicos;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el código seleccionado del ComboBox
            string codigoSeleccionado = (string)ComboBoxCOD.SelectedItem;

            // Obtener la cantidad ingresada en el TextBox
            int cantidadVendida;
            if (int.TryParse(textCantidadSell.Text, out cantidadVendida))
            {
                // Buscar el producto correspondiente en la lista de productos de Form2
                StockPilas.Producto producto = formulario2.ObtenerProductos().FirstOrDefault(p => p.CODIGO == codigoSeleccionado);

                if (producto != null)
                {
                    // Verificar si hay suficiente cantidad en stock para la venta
                    if (cantidadVendida <= producto.CANTIDAD)
                    {
                        // Actualizar la cantidad del producto
                        producto.CANTIDAD -= cantidadVendida;

                        // Actualizar la lista de productos en Form2
                        formulario2.ActualizarProductos(formulario2.ObtenerProductos());

                        // Escribir los datos actualizados de productos en el archivo CSV
                        using (var writer = new StreamWriter("stock.csv"))
                        using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)
                        {
                            Delimiter = ";", // Establece el delimitador correcto según tu archivo CSV
                            HasHeaderRecord = true // Indica que el archivo tiene una fila de encabezados
                        }))
                        {
                            csv.WriteRecords(formulario2.ObtenerProductos());
                        }

                        // Mostrar un mensaje de éxito
                        MessageBox.Show($"Venta realizada con éxito. Cantidad restante: {producto.CANTIDAD}");

                        // Limpiar el TextBox
                        textCantidadSell.Clear();

                        // Cerrar el formulario actual (Form4 en este caso)
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock para la venta.");
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida.");
            }
        }


    }


}

