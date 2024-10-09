using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VentasApp
{
    public class GestorVentas
    {
        private List<decimal> ventas;

        // Constructor que carga las ventas desde el archivo
        public GestorVentas(string filePath)
        {
            CargarVentas(filePath);
        }

        // Método para cargar las ventas desde un archivo
        private void CargarVentas(string filePath)
        {
            try
            {
                ventas = File.ReadAllLines(filePath)
                .Select(decimal.Parse)
                .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer el archivo: {ex.Message}");
            }
        }

        // Método para obtener las ventas filtradas y ordenadas
        public List<decimal> ObtenerVentasFiltradasYOrdenadas(decimal min, decimal max)
        {
            return ventas.Where(v => v >= min && v <= max)
            .OrderBy(v => v)
            .ToList();
        }
    }
}