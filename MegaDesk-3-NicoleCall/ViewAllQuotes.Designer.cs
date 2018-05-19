namespace MegaDesk_3_NicoleCall
{
    partial class ViewAllQuotes
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
            this.quotesViewAll = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quotesViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // quotesViewAll
            // 
            this.quotesViewAll.AllowUserToDeleteRows = false;
            this.quotesViewAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.quotesViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotesViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.CustomerName,
            this.deskWidth,
            this.deskDepth,
            this.Drawers,
            this.SurfaceMaterial,
            this.RushOrder,
            this.FinalQuote});
            this.quotesViewAll.Location = new System.Drawing.Point(29, 44);
            this.quotesViewAll.Name = "quotesViewAll";
            this.quotesViewAll.RowTemplate.Height = 24;
            this.quotesViewAll.Size = new System.Drawing.Size(843, 362);
            this.quotesViewAll.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 67;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 127;
            // 
            // deskWidth
            // 
            this.deskWidth.HeaderText = "Width";
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Width = 73;
            // 
            // deskDepth
            // 
            this.deskDepth.HeaderText = "Depth";
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Width = 75;
            // 
            // Drawers
            // 
            this.Drawers.HeaderText = "Drawers";
            this.Drawers.Name = "Drawers";
            this.Drawers.Width = 89;
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.HeaderText = "Surface Material";
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.Width = 128;
            // 
            // RushOrder
            // 
            this.RushOrder.HeaderText = "Rush Order";
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Width = 102;
            // 
            // FinalQuote
            // 
            this.FinalQuote.HeaderText = "Final Quote";
            this.FinalQuote.Name = "FinalQuote";
            this.FinalQuote.Width = 101;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 483);
            this.Controls.Add(this.quotesViewAll);
            this.MinimumSize = new System.Drawing.Size(950, 530);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.quotesViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView quotesViewAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalQuote;
    }
}