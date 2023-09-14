namespace YacoPila
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            ComboBoxCOD = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            textCantidadSell = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // ComboBoxCOD
            // 
            ComboBoxCOD.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxCOD.FormattingEnabled = true;
            ComboBoxCOD.Location = new Point(272, 99);
            ComboBoxCOD.Margin = new Padding(3, 4, 3, 4);
            ComboBoxCOD.Name = "ComboBoxCOD";
            ComboBoxCOD.Size = new Size(400, 49);
            ComboBoxCOD.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(48, 300);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(694, 101);
            button1.TabIndex = 1;
            button1.Text = "Sell";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 102);
            label1.Name = "label1";
            label1.Size = new Size(96, 41);
            label1.TabIndex = 2;
            label1.Text = "Code:";
            // 
            // textCantidadSell
            // 
            textCantidadSell.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textCantidadSell.Location = new Point(272, 184);
            textCantidadSell.Margin = new Padding(3, 4, 3, 4);
            textCantidadSell.Name = "textCantidadSell";
            textCantidadSell.Size = new Size(400, 47);
            textCantidadSell.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(104, 190);
            label3.Name = "label3";
            label3.Size = new Size(145, 41);
            label3.TabIndex = 6;
            label3.Text = "Quantity:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(782, 453);
            Controls.Add(label3);
            Controls.Add(textCantidadSell);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ComboBoxCOD);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            Text = "StockPilas";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxCOD;
        private Button button1;
        private Label label1;
        private TextBox textCantidadSell;
        private Label label3;
    }
}