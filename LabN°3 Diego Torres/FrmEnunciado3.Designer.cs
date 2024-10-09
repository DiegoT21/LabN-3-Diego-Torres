namespace LabN_3_Diego_Torres
{
    partial class FrmEnunciado3
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
            btnCargarVentas = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCargarVentas
            // 
            btnCargarVentas.Location = new Point(357, 388);
            btnCargarVentas.Name = "btnCargarVentas";
            btnCargarVentas.Size = new Size(75, 23);
            btnCargarVentas.TabIndex = 0;
            btnCargarVentas.Text = "Cargar";
            btnCargarVentas.UseVisualStyleBackColor = true;
            btnCargarVentas.Click += btnCargarVentas_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(321, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(147, 309);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Importe";
            Column1.Name = "Column1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 56, 132);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 56, 132);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(600, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 450);
            panel2.TabIndex = 3;
            // 
            // FrmEnunciado3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 95, 193);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(btnCargarVentas);
            Name = "FrmEnunciado3";
            Text = "Enunciado3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargarVentas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private Panel panel1;
        private Panel panel2;
    }
}