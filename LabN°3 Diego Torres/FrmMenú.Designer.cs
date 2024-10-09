namespace LabN_3_Diego_Torres
{
    partial class FrmMenú
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuPrincipal = new MenuStrip();
            cuentaBancoToolStripMenuItem = new ToolStripMenuItem();
            eliminadorDeDatosToolStripMenuItem = new ToolStripMenuItem();
            gestorVentasToolStripMenuItem = new ToolStripMenuItem();
            mnuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { cuentaBancoToolStripMenuItem, eliminadorDeDatosToolStripMenuItem, gestorVentasToolStripMenuItem });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(800, 27);
            mnuPrincipal.TabIndex = 0;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // cuentaBancoToolStripMenuItem
            // 
            cuentaBancoToolStripMenuItem.Name = "cuentaBancoToolStripMenuItem";
            cuentaBancoToolStripMenuItem.Size = new Size(112, 23);
            cuentaBancoToolStripMenuItem.Text = "Cuenta Banco";
            cuentaBancoToolStripMenuItem.Click += cuentaBancoToolStripMenuItem_Click;
            // 
            // eliminadorDeDatosToolStripMenuItem
            // 
            eliminadorDeDatosToolStripMenuItem.Name = "eliminadorDeDatosToolStripMenuItem";
            eliminadorDeDatosToolStripMenuItem.Size = new Size(154, 23);
            eliminadorDeDatosToolStripMenuItem.Text = "Eliminador de Datos";
            eliminadorDeDatosToolStripMenuItem.Click += eliminadorDeDatosToolStripMenuItem_Click;
            // 
            // gestorVentasToolStripMenuItem
            // 
            gestorVentasToolStripMenuItem.Name = "gestorVentasToolStripMenuItem";
            gestorVentasToolStripMenuItem.Size = new Size(107, 23);
            gestorVentasToolStripMenuItem.Text = "GestorVentas";
            gestorVentasToolStripMenuItem.Click += gestorVentasToolStripMenuItem_Click;
            // 
            // FrmMenú
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = mnuPrincipal;
            Name = "FrmMenú";
            Text = "Menú";
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem cuentaBancoToolStripMenuItem;
        private ToolStripMenuItem eliminadorDeDatosToolStripMenuItem;
        private ToolStripMenuItem gestorVentasToolStripMenuItem;
    }
}
