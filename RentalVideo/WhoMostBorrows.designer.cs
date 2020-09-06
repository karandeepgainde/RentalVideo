namespace RentalVideo
{
    partial class WhoMostBorrows
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
            this.gridViewCustomerList = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewCustomerList
            // 
            this.gridViewCustomerList.AllowUserToAddRows = false;
            this.gridViewCustomerList.AllowUserToDeleteRows = false;
            this.gridViewCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCustomerList.Location = new System.Drawing.Point(66, 86);
            this.gridViewCustomerList.Name = "gridViewCustomerList";
            this.gridViewCustomerList.ReadOnly = true;
            this.gridViewCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewCustomerList.Size = new System.Drawing.Size(628, 317);
            this.gridViewCustomerList.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(178, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(418, 37);
            this.label10.TabIndex = 49;
            this.label10.Text = "Most Rental Customer List";
            // 
            // WhoMostBorrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentalVideo.Properties.Resources.blue_gradient_background;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gridViewCustomerList);
            this.Name = "WhoMostBorrows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostBorrows";
            this.Load += new System.EventHandler(this.MostBorrows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewCustomerList;
        private System.Windows.Forms.Label label10;
    }
}