namespace WindowsFormsApplication1
{
    partial class FormAccueil
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
            this.labTitre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtValide = new System.Windows.Forms.Button();
            this.RbIntro = new System.Windows.Forms.RadioButton();
            this.RbFamile = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitre
            // 
            this.labTitre.AutoEllipsis = true;
            this.labTitre.AutoSize = true;
            this.labTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labTitre.Location = new System.Drawing.Point(12, 9);
            this.labTitre.Name = "labTitre";
            this.labTitre.Size = new System.Drawing.Size(68, 29);
            this.labTitre.TabIndex = 0;
            this.labTitre.Text = "Titre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtValide);
            this.groupBox1.Controls.Add(this.RbIntro);
            this.groupBox1.Controls.Add(this.RbFamile);
            this.groupBox1.Location = new System.Drawing.Point(29, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix : procédez dans l\'ordre";
            // 
            // BtValide
            // 
            this.BtValide.Location = new System.Drawing.Point(461, 258);
            this.BtValide.Name = "BtValide";
            this.BtValide.Size = new System.Drawing.Size(124, 27);
            this.BtValide.TabIndex = 2;
            this.BtValide.Text = "Valider le choix";
            this.BtValide.UseVisualStyleBackColor = true;
            this.BtValide.Click += new System.EventHandler(this.BtValide_Click);
            // 
            // RbIntro
            // 
            this.RbIntro.AutoSize = true;
            this.RbIntro.Location = new System.Drawing.Point(30, 78);
            this.RbIntro.Name = "RbIntro";
            this.RbIntro.Size = new System.Drawing.Size(81, 17);
            this.RbIntro.TabIndex = 1;
            this.RbIntro.TabStop = true;
            this.RbIntro.Text = "Introduction";
            this.RbIntro.UseVisualStyleBackColor = true;
            // 
            // RbFamile
            // 
            this.RbFamile.AutoSize = true;
            this.RbFamile.Checked = true;
            this.RbFamile.Location = new System.Drawing.Point(30, 45);
            this.RbFamile.Name = "RbFamile";
            this.RbFamile.Size = new System.Drawing.Size(181, 17);
            this.RbFamile.TabIndex = 0;
            this.RbFamile.TabStop = true;
            this.RbFamile.Text = "Présentation de la famille  dupont";
            this.RbFamile.UseVisualStyleBackColor = true;
            this.RbFamile.CheckedChanged += new System.EventHandler(this.RbFamile_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labTitre);
            this.Name = "FormAccueil";
            this.Text = "EUREKA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbIntro;
        private System.Windows.Forms.RadioButton RbFamile;
        private System.Windows.Forms.Button BtValide;
        private System.Windows.Forms.Button button1;
    }
}

