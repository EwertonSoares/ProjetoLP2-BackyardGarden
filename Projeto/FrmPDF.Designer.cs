namespace Login
{
    partial class FrmPDF
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
            this.PDFGred = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PDFGred)).BeginInit();
            this.SuspendLayout();
            // 
            // PDFGred
            // 
            this.PDFGred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PDFGred.Location = new System.Drawing.Point(12, 27);
            this.PDFGred.Name = "PDFGred";
            this.PDFGred.Size = new System.Drawing.Size(267, 282);
            this.PDFGred.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(330, 110);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(330, 173);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(105, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FrmPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 340);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.PDFGred);
            this.Name = "FrmPDF";
            this.Text = "FrmPDF";
            this.Load += new System.EventHandler(this.FrmPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PDFGred)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PDFGred;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDel;
    }
}