namespace RappelWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnclickMe = new System.Windows.Forms.Button();
            this.lblInfos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclickMe
            // 
            this.btnclickMe.Location = new System.Drawing.Point(199, 136);
            this.btnclickMe.Name = "btnclickMe";
            this.btnclickMe.Size = new System.Drawing.Size(331, 127);
            this.btnclickMe.TabIndex = 0;
            this.btnclickMe.Text = "Click me !";
            this.btnclickMe.UseVisualStyleBackColor = true;
            this.btnclickMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInfos
            // 
            this.lblInfos.AutoSize = true;
            this.lblInfos.Location = new System.Drawing.Point(249, 328);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(70, 25);
            this.lblInfos.TabIndex = 1;
            this.lblInfos.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfos);
            this.Controls.Add(this.btnclickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclickMe;
        private System.Windows.Forms.Label lblInfos;
    }
}

