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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.btn_mylist = new System.Windows.Forms.Button();
            this.btn_newlist = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.labelWelcomeback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mylist
            // 
            this.btn_mylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mylist.Location = new System.Drawing.Point(54, 133);
            this.btn_mylist.Name = "btn_mylist";
            this.btn_mylist.Size = new System.Drawing.Size(98, 31);
            this.btn_mylist.TabIndex = 2;
            this.btn_mylist.Text = "Meus relatórios";
            this.btn_mylist.UseVisualStyleBackColor = true;
            // 
            // btn_newlist
            // 
            this.btn_newlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_newlist.Location = new System.Drawing.Point(54, 170);
            this.btn_newlist.Name = "btn_newlist";
            this.btn_newlist.Size = new System.Drawing.Size(98, 31);
            this.btn_newlist.TabIndex = 3;
            this.btn_newlist.Text = "Novo relatório";
            this.btn_newlist.UseVisualStyleBackColor = true;
            this.btn_newlist.Click += new System.EventHandler(this.btn_newlist_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(137, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar perfil";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelWelcomeback
            // 
            this.labelWelcomeback.AutoSize = true;
            this.labelWelcomeback.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcomeback.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeback.Location = new System.Drawing.Point(5, 62);
            this.labelWelcomeback.Name = "labelWelcomeback";
            this.labelWelcomeback.Size = new System.Drawing.Size(200, 20);
            this.labelWelcomeback.TabIndex = 5;
            this.labelWelcomeback.Text = "Bem-vindo de volta!";
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(206, 231);
            this.Controls.Add(this.labelWelcomeback);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btn_newlist);
            this.Controls.Add(this.btn_mylist);
            this.Name = "FrmInicial";
            this.ShowIcon = false;
            this.Text = "Página Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mylist;
        private System.Windows.Forms.Button btn_newlist;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelWelcomeback;
    }
}