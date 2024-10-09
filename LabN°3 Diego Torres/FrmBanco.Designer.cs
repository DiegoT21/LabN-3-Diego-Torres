namespace LabN_3_Diego_Torres
{
    partial class FrmBanco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnAbrirCuenta = new Button();
            btnRealizar = new Button();
            lstRetiros = new ListBox();
            lstDepositos = new ListBox();
            rdbDepositos = new RadioButton();
            rdbRetiros = new RadioButton();
            txtCliente = new TextBox();
            txtMontoInicial = new TextBox();
            txtSaldo = new TextBox();
            txtMonto = new TextBox();
            groupBox1 = new GroupBox();
            btnNuevo = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 28);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 70);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Monto inicial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(715, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 4;
            label5.Text = "Saldo";
            // 
            // btnAbrirCuenta
            // 
            btnAbrirCuenta.Location = new Point(90, 102);
            btnAbrirCuenta.Name = "btnAbrirCuenta";
            btnAbrirCuenta.Size = new Size(100, 23);
            btnAbrirCuenta.TabIndex = 5;
            btnAbrirCuenta.Text = "AbrirCuenta";
            btnAbrirCuenta.UseVisualStyleBackColor = true;
            btnAbrirCuenta.Click += btnAbrirCuenta_Click;
            // 
            // btnRealizar
            // 
            btnRealizar.Location = new Point(77, 100);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(75, 23);
            btnRealizar.TabIndex = 6;
            btnRealizar.Text = "Realizar";
            btnRealizar.UseVisualStyleBackColor = true;
            btnRealizar.Click += btnRealizar_Click;
            // 
            // lstRetiros
            // 
            lstRetiros.FormattingEnabled = true;
            lstRetiros.ItemHeight = 15;
            lstRetiros.Location = new Point(184, 29);
            lstRetiros.Name = "lstRetiros";
            lstRetiros.Size = new Size(154, 244);
            lstRetiros.TabIndex = 7;
            // 
            // lstDepositos
            // 
            lstDepositos.FormattingEnabled = true;
            lstDepositos.ItemHeight = 15;
            lstDepositos.Location = new Point(6, 29);
            lstDepositos.Name = "lstDepositos";
            lstDepositos.Size = new Size(154, 244);
            lstDepositos.TabIndex = 8;
            lstDepositos.SelectedIndexChanged += lstDepositos_SelectedIndexChanged;
            // 
            // rdbDepositos
            // 
            rdbDepositos.AutoSize = true;
            rdbDepositos.Location = new Point(26, 35);
            rdbDepositos.Name = "rdbDepositos";
            rdbDepositos.Size = new Size(77, 19);
            rdbDepositos.TabIndex = 9;
            rdbDepositos.TabStop = true;
            rdbDepositos.Text = "Depósitos";
            rdbDepositos.UseVisualStyleBackColor = true;
            // 
            // rdbRetiros
            // 
            rdbRetiros.AutoSize = true;
            rdbRetiros.Location = new Point(164, 35);
            rdbRetiros.Name = "rdbRetiros";
            rdbRetiros.Size = new Size(61, 19);
            rdbRetiros.TabIndex = 10;
            rdbRetiros.TabStop = true;
            rdbRetiros.Text = "Retiros";
            rdbRetiros.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(125, 28);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 11;
            // 
            // txtMontoInicial
            // 
            txtMontoInicial.Location = new Point(125, 62);
            txtMontoInicial.Name = "txtMontoInicial";
            txtMontoInicial.Size = new Size(100, 23);
            txtMontoInicial.TabIndex = 12;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(688, 23);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(100, 23);
            txtSaldo.TabIndex = 13;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(68, 71);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDepositos);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(rdbRetiros);
            groupBox1.Controls.Add(btnRealizar);
            groupBox1.Location = new Point(38, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(237, 141);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transacciones";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(363, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(1, 59, 133);
            panel2.Controls.Add(btnNuevo);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 403);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 47);
            panel2.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(1, 59, 133);
            panel5.Controls.Add(txtSaldo);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.ForeColor = SystemColors.ControlLightLight;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 49);
            panel5.TabIndex = 18;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstDepositos);
            groupBox2.Controls.Add(lstRetiros);
            groupBox2.Location = new Point(444, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 279);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Historial";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtMontoInicial);
            groupBox3.Controls.Add(txtCliente);
            groupBox3.Controls.Add(btnAbrirCuenta);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 65);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(307, 134);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cuenta";
            // 
            // FrmBanco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Name = "FrmBanco";
            Text = "FrmBanco";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Button btnAbrirCuenta;
        private Button btnRealizar;
        private ListBox lstRetiros;
        private ListBox lstDepositos;
        private RadioButton rdbDepositos;
        private RadioButton rdbRetiros;
        private TextBox txtCliente;
        private TextBox txtMontoInicial;
        private TextBox txtSaldo;
        private TextBox txtMonto;
        private GroupBox groupBox1;
        private Button btnNuevo;
        private Panel panel2;
        private Panel panel5;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}