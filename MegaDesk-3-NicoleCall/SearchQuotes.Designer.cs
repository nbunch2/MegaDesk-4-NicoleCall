﻿namespace MegaDesk_3_NicoleCall
{
    partial class SearchQuotes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.CustomerName,
            this.Width,
            this.Depth,
            this.Drawers,
            this.SurfaceMaterial,
            this.RushOrder,
            this.FinalQuote});
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            // 
            // Depth
            // 
            this.Depth.HeaderText = "Depth";
            this.Depth.Name = "Depth";
            // 
            // Drawers
            // 
            this.Drawers.HeaderText = "Drawers";
            this.Drawers.Name = "Drawers";
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.HeaderText = "Surface Material";
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            // 
            // RushOrder
            // 
            this.RushOrder.HeaderText = "Rush Order";
            this.RushOrder.Name = "RushOrder";
            // 
            // FinalQuote
            // 
            this.FinalQuote.HeaderText = "Final Quote";
            this.FinalQuote.Name = "FinalQuote";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalQuote;
    }
}