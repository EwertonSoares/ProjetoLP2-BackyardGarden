namespace Login
{
    partial class FrmCulturas
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
            this.hotGred = new System.Windows.Forms.DataGridView();
            this.ckb1 = new System.Windows.Forms.CheckedListBox();
            this.ckb2 = new System.Windows.Forms.CheckedListBox();
            this.ckb3 = new System.Windows.Forms.CheckedListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hotGred)).BeginInit();
            this.SuspendLayout();
            // 
            // hotGred
            // 
            this.hotGred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hotGred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotGred.Location = new System.Drawing.Point(12, 28);
            this.hotGred.Name = "hotGred";
            this.hotGred.Size = new System.Drawing.Size(447, 150);
            this.hotGred.TabIndex = 0;
            // 
            // ckb1
            // 
            this.ckb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckb1.FormattingEnabled = true;
            this.ckb1.Location = new System.Drawing.Point(488, 28);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(120, 94);
            this.ckb1.TabIndex = 1;
            // 
            // ckb2
            // 
            this.ckb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckb2.FormattingEnabled = true;
            this.ckb2.Location = new System.Drawing.Point(488, 142);
            this.ckb2.Name = "ckb2";
            this.ckb2.Size = new System.Drawing.Size(120, 94);
            this.ckb2.TabIndex = 2;
            // 
            // ckb3
            // 
            this.ckb3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckb3.FormattingEnabled = true;
            this.ckb3.Location = new System.Drawing.Point(488, 255);
            this.ckb3.Name = "ckb3";
            this.ckb3.Size = new System.Drawing.Size(120, 94);
            this.ckb3.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Location = new System.Drawing.Point(61, 246);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDel.Location = new System.Drawing.Point(296, 246);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(114, 23);
            this.buttonDel.TabIndex = 5;
            this.buttonDel.Text = "Deletar";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // FrmCulturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 361);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.ckb3);
            this.Controls.Add(this.ckb2);
            this.Controls.Add(this.ckb1);
            this.Controls.Add(this.hotGred);
            this.Name = "FrmCulturas";
            this.Text = "FrmCulturas";
            this.Load += new System.EventHandler(this.FrmHortalicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotGred)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView hotGred;
        private System.Windows.Forms.CheckedListBox ckb1;
        private System.Windows.Forms.CheckedListBox ckb2;
        private System.Windows.Forms.CheckedListBox ckb3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDel;
    }
}