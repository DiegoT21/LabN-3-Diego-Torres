using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasApp;

namespace LabN_3_Diego_Torres
{
    public partial class FrmEnunciado3 : Form
    {
        private GestorVentas gestorVentas;  
        public FrmEnunciado3()
        {
            InitializeComponent();
        }
        private void btnCargarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = @"C:\", 
                    Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*",
                    Title = "Seleccionar archivo de ventas"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    gestorVentas = new GestorVentas(filePath);
                    var ventasFiltradas = gestorVentas.ObtenerVentasFiltradasYOrdenadas(50, 287);
                    dataGridView1.Rows.Clear();

                    // Mostrar los resultados en el DataGridView
                    foreach (var venta in ventasFiltradas)
                    {
                        dataGridView1.Rows.Add(venta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas: {ex.Message}");
            }
        }
    }
}
