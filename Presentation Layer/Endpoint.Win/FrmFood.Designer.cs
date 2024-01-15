namespace Endpoint.Win
{
    partial class FrmFood
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
            DgvFood = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvFood).BeginInit();
            SuspendLayout();
            // 
            // DgvFood
            // 
            DgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvFood.Dock = DockStyle.Fill;
            DgvFood.Location = new Point(0, 43);
            DgvFood.Name = "DgvFood";
            DgvFood.RowTemplate.Height = 25;
            DgvFood.Size = new Size(851, 458);
            DgvFood.TabIndex = 1;
            // 
            // FrmFood
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 501);
            Controls.Add(DgvFood);
            Name = "FrmFood";
            Text = "FrmFood";
            Load += FrmFood_Load;
            Controls.SetChildIndex(DgvFood, 0);
            ((System.ComponentModel.ISupportInitialize)DgvFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvFood;
    }
}