namespace Login
{
    partial class FrmInicial
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
            this.btn_mylist = new System.Windows.Forms.Button();
            this.btn_newlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mylist
            // 
            this.btn_mylist.Location = new System.Drawing.Point(69, 115);
            this.btn_mylist.Name = "btn_mylist";
            this.btn_mylist.Size = new System.Drawing.Size(289, 29);
            this.btn_mylist.TabIndex = 2;
            this.btn_mylist.Text = "Meus relatórios";
            this.btn_mylist.UseVisualStyleBackColor = true;
            this.btn_mylist.Click += new System.EventHandler(this.btn_mylist_Click);
            // 
            // btn_newlist
            // 
            this.btn_newlist.Location = new System.Drawing.Point(413, 115);
            this.btn_newlist.Name = "btn_newlist";
            this.btn_newlist.Size = new System.Drawing.Size(289, 29);
            this.btn_newlist.TabIndex = 3;
            this.btn_newlist.Text = "Novo relatório";
            this.btn_newlist.UseVisualStyleBackColor = true;
            this.btn_newlist.Click += new System.EventHandler(this.btn_newlist_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_newlist);
            this.Controls.Add(this.btn_mylist);
            this.Name = "FrmInicial";
            this.Text = "Página Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mylist;
        private System.Windows.Forms.Button btn_newlist;
    }
}