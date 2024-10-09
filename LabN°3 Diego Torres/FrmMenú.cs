namespace LabN_3_Diego_Torres
{
    public partial class FrmMenú : Form
    {
        public FrmMenú()
        {
            InitializeComponent();
        }

        private void cuentaBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBanco frmBanco = new FrmBanco();
            frmBanco.MdiParent = this;
            frmBanco.WindowState = FormWindowState.Maximized;
            frmBanco.Show();
        }

        private void eliminadorDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEnunciado2 frmEnunciado2 = new FrmEnunciado2();
            frmEnunciado2.MdiParent = this;
            frmEnunciado2.WindowState = FormWindowState.Maximized;
            frmEnunciado2.Show();
        }

        private void gestorVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEnunciado3 frmEnunciado3 = new FrmEnunciado3();
            frmEnunciado3.MdiParent = this;
            frmEnunciado3.WindowState = FormWindowState.Maximized;
            frmEnunciado3.Show();
        }
    }
}
    