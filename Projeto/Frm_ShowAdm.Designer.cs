namespace Login
{
    partial class Frm_ShowAdm
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
            this.DgvAdm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAdm
            // 
            this.DgvAdm.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAdm.Location = new System.Drawing.Point(0, -1);
            this.DgvAdm.Name = "DgvAdm";
            this.DgvAdm.Size = new System.Drawing.Size(357, 284);
            this.DgvAdm.TabIndex = 0;
            // 
            // Frm_ShowAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 281);
            this.Controls.Add(this.DgvAdm);
            this.Name = "Frm_ShowAdm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Frm_ShowAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAdm;
    }
}