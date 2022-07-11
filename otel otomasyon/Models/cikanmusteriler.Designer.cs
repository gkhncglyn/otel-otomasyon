namespace otel_otomasyon
{
    partial class cikanmusteriler
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
            this.cikanliste = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cikanliste
            // 
            this.cikanliste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cikanliste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader27});
            this.cikanliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cikanliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikanliste.HideSelection = false;
            this.cikanliste.Location = new System.Drawing.Point(0, 0);
            this.cikanliste.Name = "cikanliste";
            this.cikanliste.Size = new System.Drawing.Size(448, 464);
            this.cikanliste.TabIndex = 2;
            this.cikanliste.UseCompatibleStateImageBehavior = false;
            this.cikanliste.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ODANO";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "AD";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "SOYAD";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "GİRİS";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "CIKIŞ";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "ODAUCRET";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "TOPLAM";
            // 
            // cikanmusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(448, 464);
            this.Controls.Add(this.cikanliste);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cikanmusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cikanmusteriler";
            this.Load += new System.EventHandler(this.cikanmusteriler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView cikanliste;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader27;
    }
}