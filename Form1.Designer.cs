namespace YacoPila
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnAdd = new Button();
            BtnSell = new Button();
            BtnView = new Button();
            labelCreator = new Label();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(13, 154);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(410, 123);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Add Stock";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnSell
            // 
            BtnSell.Location = new Point(13, 296);
            BtnSell.Margin = new Padding(4);
            BtnSell.Name = "BtnSell";
            BtnSell.Size = new Size(410, 123);
            BtnSell.TabIndex = 1;
            BtnSell.Text = "Sell Stock";
            BtnSell.UseVisualStyleBackColor = true;
            BtnSell.Click += BtnSell_Click;
            // 
            // BtnView
            // 
            BtnView.Location = new Point(13, 13);
            BtnView.Margin = new Padding(4);
            BtnView.Name = "BtnView";
            BtnView.Size = new Size(410, 123);
            BtnView.TabIndex = 2;
            BtnView.Text = "View Stock";
            BtnView.UseVisualStyleBackColor = true;
            BtnView.Click += BtnView_Click;
            // 
            // labelCreator
            // 
            labelCreator.Anchor = AnchorStyles.None;
            labelCreator.BackColor = Color.Transparent;
            labelCreator.ForeColor = Color.White;
            labelCreator.Location = new Point(140, 450);
            labelCreator.Margin = new Padding(0);
            labelCreator.Name = "labelCreator";
            labelCreator.Size = new Size(163, 29);
            labelCreator.TabIndex = 3;
            labelCreator.Text = "@GermanPagano 2023";
            labelCreator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(434, 511);
            Controls.Add(labelCreator);
            Controls.Add(BtnView);
            Controls.Add(BtnSell);
            Controls.Add(BtnAdd);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(450, 450);
            Name = "Form1";
            RightToLeftLayout = true;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockPilas";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAdd;
        private Button BtnSell;
        private Button BtnView;
        private Label labelCreator;
    }
}