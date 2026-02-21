namespace FrmMaquinaExpendedora
{
    partial class FrmDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataBase));
            Txt_PrecioProducto = new TextBox();
            Txt_CantidadProducto = new TextBox();
            Txt_NombreProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Btn_Uptade = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Txt_PrecioProducto
            // 
            Txt_PrecioProducto.Location = new Point(266, 229);
            Txt_PrecioProducto.Name = "Txt_PrecioProducto";
            Txt_PrecioProducto.Size = new Size(261, 39);
            Txt_PrecioProducto.TabIndex = 0;
            // 
            // Txt_CantidadProducto
            // 
            Txt_CantidadProducto.Location = new Point(266, 305);
            Txt_CantidadProducto.Name = "Txt_CantidadProducto";
            Txt_CantidadProducto.Size = new Size(261, 39);
            Txt_CantidadProducto.TabIndex = 1;
            // 
            // Txt_NombreProducto
            // 
            Txt_NombreProducto.Location = new Point(266, 132);
            Txt_NombreProducto.Name = "Txt_NombreProducto";
            Txt_NombreProducto.Size = new Size(261, 39);
            Txt_NombreProducto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("High Tower Text", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(4, 132);
            label1.Name = "label1";
            label1.Size = new Size(245, 36);
            label1.TabIndex = 3;
            label1.Text = "Nombre Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("High Tower Text", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(13, 229);
            label2.Name = "label2";
            label2.Size = new Size(221, 36);
            label2.TabIndex = 4;
            label2.Text = "Precio Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("High Tower Text", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(-5, 308);
            label3.Name = "label3";
            label3.Size = new Size(262, 36);
            label3.TabIndex = 5;
            label3.Text = "Cantidad Producto";
            // 
            // Btn_Uptade
            // 
            Btn_Uptade.Font = new Font("High Tower Text", 12F, FontStyle.Bold | FontStyle.Italic);
            Btn_Uptade.Location = new Point(352, 388);
            Btn_Uptade.Name = "Btn_Uptade";
            Btn_Uptade.Size = new Size(150, 46);
            Btn_Uptade.TabIndex = 6;
            Btn_Uptade.Text = "Uptade";
            Btn_Uptade.UseVisualStyleBackColor = true;
            Btn_Uptade.Click += Btn_Uptade_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 497);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(825, 333);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("High Tower Text", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.Firebrick;
            button1.Location = new Point(625, 143);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmDataBase
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(825, 830);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Btn_Uptade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txt_NombreProducto);
            Controls.Add(Txt_CantidadProducto);
            Controls.Add(Txt_PrecioProducto);
            Name = "FrmDataBase";
            Text = "FrmDataBase";
            Load += FrmDataBase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox Txt_PrecioProducto;
        private TextBox Txt_NombreProducto;
        private TextBox Txt_CantidadProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Btn_Uptade;
        private DataGridView dataGridView1;
        private Button button1;
    }
}