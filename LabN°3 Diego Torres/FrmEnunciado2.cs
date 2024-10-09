using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabN_3_Diego_Torres
{
    public partial class FrmEnunciado2 : Form
    {
        private int currentCellIndex = 0;
        public FrmEnunciado2()
        {
            InitializeComponent();
            InitializeDataGridView();
            initializeButtons();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }
        private void initializeButtons()
        {
            for (int i = 0; i <= 9; i++)
            {
                Button numButton = new Button();
                numButton.Text = i.ToString();
                numButton.Width = 50;
                numButton.Height = 50;
                numButton.Click += NumButton_Click;

                // Agregar el botón al formulario
                flowLayoutPanel1.Controls.Add(numButton);
            }
        }
        private void NumButton_Click(object sender, EventArgs e)
        {
            if (currentCellIndex < 25) // 5x5 grid tiene 25 celdas
            {
                Button clickedButton = sender as Button;
                string number = clickedButton.Text;

                // Calcular el índice de la fila y columna
                int rowIndex = currentCellIndex / 5;
                int colIndex = currentCellIndex % 5;

                // Validar que los índices estén dentro del rango (0 a 4)
                if (rowIndex >= 0 && rowIndex < 5 && colIndex >= 0 && colIndex < 5)
                {
                    dataGridView1[colIndex, rowIndex].Value = number;
                    currentCellIndex++; // Incrementar el índice de la celda
                }
                else
                {
                    // Mostrar un mensaje si los índices están fuera de rango (aunque no debería pasar)
                    MessageBox.Show("Índice fuera de rango. No se puede agregar el número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar mensaje si el grid está lleno
                MessageBox.Show("El DataGridView ya está lleno.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            GridControlador gridManager = new GridControlador(dataGridView1);

            // Obtener el número a eliminar desde el TextBox
            int numberToRemove;

            if (int.TryParse(txtNumeroEliminar.Text, out numberToRemove))
            {
                // Llamar al método para eliminar y reorganizar
                gridManager.RemoveAndShift(numberToRemove);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
