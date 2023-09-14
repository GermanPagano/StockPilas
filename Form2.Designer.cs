namespace YacoPila
{
    partial class StockPilas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockPilas));
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.MidnightBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(882, 390);
            dataGridView1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(100, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 100);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.None;
            btnPrint.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.Location = new Point(525, 410);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(250, 100);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // StockPilas
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(882, 553);
            Controls.Add(btnPrint);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StockPilas";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockPilas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnPrint;
    }
}