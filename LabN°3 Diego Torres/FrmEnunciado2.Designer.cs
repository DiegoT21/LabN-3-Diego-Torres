namespace LabN_3_Diego_Torres
{
    partial class FrmEnunciado2
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            txtNumeroEliminar = new TextBox();
            btnEliminar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(183, 209);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(256, 181);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(131, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(537, 167);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtNumeroEliminar
            // 
            txtNumeroEliminar.Location = new Point(509, 240);
            txtNumeroEliminar.Name = "txtNumeroEliminar";
            txtNumeroEliminar.Size = new Size(100, 23);
            txtNumeroEliminar.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(522, 283);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 58, 132);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(112, 450);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 58, 132);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(688, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 450);
            panel2.TabIndex = 5;
            // 
            // FrmEnunciado2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 95, 191);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(txtNumeroEliminar);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmEnunciado2";
            Text = "FrmEnunciado2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private TextBox txtNumeroEliminar;
        private Button btnEliminar;
        private Panel panel1;
        private Panel panel2;
    }
}