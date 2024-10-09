using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabN_3_Diego_Torres
{
    class GridControlador
    {
        private DataGridView _dataGridView;

        // Constructor que recibe el DataGridView
        public GridControlador(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }

        // Método para eliminar todos los números iguales y reorganizar el grid
        public void RemoveAndShift(int numberToRemove)
        {
            int totalRows = _dataGridView.RowCount;
            int totalColumns = _dataGridView.ColumnCount;

            // Lista para guardar todos los valores que quedan después de eliminar
            List<string> remainingValues = new List<string>();

            // Recorrer todo el grid y eliminar las celdas con el número a eliminar
            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalColumns; j++)
                {
                    var cellValue = _dataGridView[j, i].Value?.ToString();
                    if (cellValue != null && cellValue != numberToRemove.ToString())
                    {
                        // Agregar los valores que no son iguales al número a eliminar
                        remainingValues.Add(cellValue);
                    }
                }
            }

            // Limpiar todas las celdas del DataGridView
            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalColumns; j++)
                {
                    _dataGridView[j, i].Value = null;
                }
            }

            // Reorganizar los valores restantes en el DataGridView
            int currentIndex = 0;
            foreach (var value in remainingValues)
            {
                int rowIndex = currentIndex / totalColumns;
                int colIndex = currentIndex % totalColumns;

                _dataGridView[colIndex, rowIndex].Value = value;

                currentIndex++;
            }
        }
    }
}
