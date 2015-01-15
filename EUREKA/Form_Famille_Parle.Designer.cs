namespace WindowsFormsApplication1
{
    partial class FormFamilleParle
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
            this.pictureFils = new System.Windows.Forms.PictureBox();
            this.pictureFIlle = new System.Windows.Forms.PictureBox();
            this.picturePere = new System.Windows.Forms.PictureBox();
            this.pictureMere = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtSuite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFIlle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMere)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFils
            // 
            this.pictureFils.Image = global::WindowsFormsApplication1.Properties.Resources.Fils;
            this.pictureFils.Location = new System.Drawing.Point(390, 257);
            this.pictureFils.Name = "pictureFils";
            this.pictureFils.Size = new System.Drawing.Size(152, 153);
            this.pictureFils.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFils.TabIndex = 3;
            this.pictureFils.TabStop = false;
            this.pictureFils.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureFIlle
            // 
            this.pictureFIlle.Image = global::WindowsFormsApplication1.Properties.Resources.Fille;
            this.pictureFIlle.Location = new System.Drawing.Point(130, 257);
            this.pictureFIlle.Name = "pictureFIlle";
            this.pictureFIlle.Size = new System.Drawing.Size(177, 153);
            this.pictureFIlle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFIlle.TabIndex = 2;
            this.pictureFIlle.TabStop = false;
            this.pictureFIlle.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picturePere
            // 
            this.picturePere.Image = global::WindowsFormsApplication1.Properties.Resources.Pere;
            this.picturePere.Location = new System.Drawing.Point(457, 63);
            this.picturePere.Name = "picturePere";
            this.picturePere.Size = new System.Drawing.Size(140, 165);
            this.picturePere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePere.TabIndex = 1;
            this.picturePere.TabStop = false;
            this.picturePere.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureMere
            // 
            this.pictureMere.Image = global::WindowsFormsApplication1.Properties.Resources.Mere;
            this.pictureMere.Location = new System.Drawing.Point(48, 59);
            this.pictureMere.Name = "pictureMere";
            this.pictureMere.Size = new System.Drawing.Size(182, 169);
            this.pictureMere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMere.TabIndex = 0;
            this.pictureMere.TabStop = false;
            this.pictureMere.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(55, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliquez sur les images pour faire connaissance avec la famille.";
            // 
            // BtSuite
            // 
            this.BtSuite.Location = new System.Drawing.Point(567, 448);
            this.BtSuite.Name = "BtSuite";
            this.BtSuite.Size = new System.Drawing.Size(115, 30);
            this.BtSuite.TabIndex = 5;
            this.BtSuite.Text = "Poursuivre";
            this.BtSuite.UseVisualStyleBackColor = true;
            this.BtSuite.Click += new System.EventHandler(this.BtSuite_Click);
            // 
            // FormFamilleParle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 503);
            this.Controls.Add(this.BtSuite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureFils);
            this.Controls.Add(this.pictureFIlle);
            this.Controls.Add(this.picturePere);
            this.Controls.Add(this.pictureMere);
            this.Name = "FormFamilleParle";
            this.Text = "MOI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFamille_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFIlle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMere;
        private System.Windows.Forms.PictureBox picturePere;
        private System.Windows.Forms.PictureBox pictureFIlle;
        private System.Windows.Forms.PictureBox pictureFils;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtSuite;
    }
}