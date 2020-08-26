namespace GUI
{
    partial class fSanPham
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
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnChon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Location = new System.Drawing.Point(18, 12);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.RowTemplate.Height = 24;
            this.dtgvSanPham.Size = new System.Drawing.Size(807, 339);
            this.dtgvSanPham.TabIndex = 0;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(720, 373);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(105, 39);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Chon";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // fSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 442);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dtgvSanPham);
            this.Name = "fSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "San Pham";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.Button btnChon;
    }
}