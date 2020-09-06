namespace RentalVideo
{
    partial class MostPopularVideo
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
            this.gridViewPopularVideo = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPopularVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewPopularVideo
            // 
            this.gridViewPopularVideo.AllowUserToAddRows = false;
            this.gridViewPopularVideo.AllowUserToDeleteRows = false;
            this.gridViewPopularVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPopularVideo.Location = new System.Drawing.Point(57, 115);
            this.gridViewPopularVideo.Name = "gridViewPopularVideo";
            this.gridViewPopularVideo.ReadOnly = true;
            this.gridViewPopularVideo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewPopularVideo.Size = new System.Drawing.Size(684, 299);
            this.gridViewPopularVideo.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(238, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(332, 37);
            this.label10.TabIndex = 50;
            this.label10.Text = "Most Popular Videos";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // MostPopularVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentalVideo.Properties.Resources.blue_gradient_background;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gridViewPopularVideo);
            this.Name = "MostPopularVideo";
            this.Text = "PopularVideo";
            this.Load += new System.EventHandler(this.PopularVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPopularVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewPopularVideo;
        private System.Windows.Forms.Label label10;
    }
}