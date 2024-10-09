using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabN_3_Diego_Torres
{
    public partial class FrmBanco : Form
    {
        private BancoCuenta? cuenta;
        public FrmBanco()
        {
            InitializeComponent();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (cuenta == null)
            {
                MessageBox.Show("Debe abrir una cuenta primero.");
                return;
            }

            decimal montoTransaccion;
            if (decimal.TryParse(txtMonto.Text, out montoTransaccion))
            {
                if (rdbDepositos.Checked)
                {
                    // Realizar depósito
                    cuenta.Depositar(montoTransaccion);
                    txtSaldo.Text = cuenta.Saldo.ToString();
                    lstDepositos.Items.Add(montoTransaccion); // Mostrar depósito en el ListBox
                }
                else if (rdbRetiros.Checked)
                {
                    // Realizar retiro
                    if (cuenta.Retirar(montoTransaccion))
                    {
                        txtSaldo.Text = cuenta.Saldo.ToString();
                        lstRetiros.Items.Add(montoTransaccion); // Mostrar retiro en el ListBox
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente.");
                    }
                }
            }
        }

        private void btnAbrirCuenta_Click(object sender, EventArgs e)
        {
            decimal MontoInicial;

            if (decimal.TryParse(txtMontoInicial.Text, out MontoInicial) && MontoInicial > 0)
            {
                cuenta = new BancoCuenta(MontoInicial);
                txtSaldo.Text = cuenta.Saldo.ToString();
                MessageBox.Show("Su cuenta se creo con éxito");
            }
            else
            {
                MessageBox.Show("Ingrese un monto inicial válido");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtMontoInicial.Clear();
            txtMonto.Clear();
            txtSaldo.Text = "0";
            lstDepositos.Items.Clear();  // Limpiar la lista de depósitos
            lstRetiros.Items.Clear();    // Limpiar la lista de retiros
            cuenta = null;
            rdbDepositos.Checked = true; // Seleccionamos depósito por defecto
            MessageBox.Show("Listo para abrir una nueva cuenta.");
        }

        private void lstDepositos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

