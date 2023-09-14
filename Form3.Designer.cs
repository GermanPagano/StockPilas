namespace YacoPila
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            BtnAddStock = new Button();
            txtCodigo = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtCantidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // BtnAddStock
            // 
            BtnAddStock.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddStock.Location = new Point(25, 469);
            BtnAddStock.Margin = new Padding(4, 5, 4, 5);
            BtnAddStock.Name = "BtnAddStock";
            BtnAddStock.Size = new Size(726, 106);
            BtnAddStock.TabIndex = 0;
            BtnAddStock.Text = "Add";
            BtnAddStock.UseVisualStyleBackColor = true;
            BtnAddStock.Click += BtnAddStock_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(285, 67);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(268, 47);
            txtCodigo.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(285, 177);
            txtMarca.Margin = new Padding(4, 5, 4, 5);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(268, 47);
            txtMarca.TabIndex = 2;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(285, 274);
            txtModelo.Margin = new Padding(4, 5, 4, 5);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(268, 47);
            txtModelo.TabIndex = 3;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(285, 372);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(268, 47);
            txtCantidad.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 5;
            label1.Text = "Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 192);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 6;
            label2.Text = "Brand:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(137, 289);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 32);
            label3.TabIndex = 7;
            label3.Text = "Model:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(137, 387);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 32);
            label4.TabIndex = 8;
            label4.Text = "Quantity:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(778, 599);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(txtCodigo);
            Controls.Add(BtnAddStock);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockPilas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAddStock;
        private TextBox txtCodigo;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtCantidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}