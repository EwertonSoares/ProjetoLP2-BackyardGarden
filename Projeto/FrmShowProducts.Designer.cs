﻿namespace Login
{
    partial class showProducts
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
            this.showData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showData)).BeginInit();
            this.SuspendLayout();
            // 
            // showData
            // 
            this.showData.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.showData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.showData.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.showData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showData.Location = new System.Drawing.Point(1, 1);
            this.showData.Name = "showData";
            this.showData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showData.Size = new System.Drawing.Size(345, 250);
            this.showData.TabIndex = 0;
            // 
            // showProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(346, 263);
            this.Controls.Add(this.showData);
            this.Name = "showProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.showProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showData;
    }
}