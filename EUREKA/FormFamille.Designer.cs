namespace WindowsFormsApplication1
{
    partial class FormFamille
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtSuite = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbQuoi = new System.Windows.Forms.RadioButton();
            this.RbQui = new System.Windows.Forms.RadioButton();
            this.RbOu = new System.Windows.Forms.RadioButton();
            this.RbQuand = new System.Windows.Forms.RadioButton();
            this.RbCOmment = new System.Windows.Forms.RadioButton();
            this.RbPourquoi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interrogez les membres de la famille en  cliquant sur les images.";
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
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.Fils;
            this.pictureBox4.Location = new System.Drawing.Point(530, 257);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 153);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.Fille;
            this.pictureBox3.Location = new System.Drawing.Point(323, 257);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 153);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.Pere;
            this.pictureBox2.Location = new System.Drawing.Point(542, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Mere;
            this.pictureBox1.Location = new System.Drawing.Point(318, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 335);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbPourquoi);
            this.groupBox1.Controls.Add(this.RbCOmment);
            this.groupBox1.Controls.Add(this.RbQuand);
            this.groupBox1.Controls.Add(this.RbOu);
            this.groupBox1.Controls.Add(this.RbQui);
            this.groupBox1.Controls.Add(this.RbQuoi);
            this.groupBox1.Location = new System.Drawing.Point(19, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QQOQCP";
            // 
            // RbQuoi
            // 
            this.RbQuoi.AutoSize = true;
            this.RbQuoi.Checked = true;
            this.RbQuoi.Location = new System.Drawing.Point(7, 30);
            this.RbQuoi.Name = "RbQuoi";
            this.RbQuoi.Size = new System.Drawing.Size(52, 17);
            this.RbQuoi.TabIndex = 0;
            this.RbQuoi.TabStop = true;
            this.RbQuoi.Text = "QUOI";
            this.RbQuoi.UseVisualStyleBackColor = true;
            // 
            // RbQui
            // 
            this.RbQui.AutoSize = true;
            this.RbQui.Location = new System.Drawing.Point(6, 62);
            this.RbQui.Name = "RbQui";
            this.RbQui.Size = new System.Drawing.Size(44, 17);
            this.RbQui.TabIndex = 1;
            this.RbQui.Text = "QUI";
            this.RbQui.UseVisualStyleBackColor = true;
            this.RbQui.Visible = false;
            // 
            // RbOu
            // 
            this.RbOu.AutoSize = true;
            this.RbOu.Location = new System.Drawing.Point(7, 97);
            this.RbOu.Name = "RbOu";
            this.RbOu.Size = new System.Drawing.Size(41, 17);
            this.RbOu.TabIndex = 2;
            this.RbOu.Text = "OU";
            this.RbOu.UseVisualStyleBackColor = true;
            this.RbOu.Visible = false;
            // 
            // RbQuand
            // 
            this.RbQuand.AutoSize = true;
            this.RbQuand.Location = new System.Drawing.Point(7, 132);
            this.RbQuand.Name = "RbQuand";
            this.RbQuand.Size = new System.Drawing.Size(64, 17);
            this.RbQuand.TabIndex = 4;
            this.RbQuand.Text = "QUAND";
            this.RbQuand.UseVisualStyleBackColor = true;
            this.RbQuand.Visible = false;
            // 
            // RbCOmment
            // 
            this.RbCOmment.AutoSize = true;
            this.RbCOmment.Location = new System.Drawing.Point(8, 167);
            this.RbCOmment.Name = "RbCOmment";
            this.RbCOmment.Size = new System.Drawing.Size(80, 17);
            this.RbCOmment.TabIndex = 5;
            this.RbCOmment.Text = "COMMENT";
            this.RbCOmment.UseVisualStyleBackColor = true;
            this.RbCOmment.Visible = false;
            // 
            // RbPourquoi
            // 
            this.RbPourquoi.AutoSize = true;
            this.RbPourquoi.Location = new System.Drawing.Point(8, 205);
            this.RbPourquoi.Name = "RbPourquoi";
            this.RbPourquoi.Size = new System.Drawing.Size(83, 17);
            this.RbPourquoi.TabIndex = 6;
            this.RbPourquoi.Text = "POURQUOI";
            this.RbPourquoi.UseVisualStyleBackColor = true;
            this.RbPourquoi.Visible = false;
            // 
            // FormFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtSuite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormFamille";
            this.Text = "Qu\'a à dire la famille.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFamille_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtSuite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbPourquoi;
        private System.Windows.Forms.RadioButton RbCOmment;
        private System.Windows.Forms.RadioButton RbQuand;
        private System.Windows.Forms.RadioButton RbOu;
        private System.Windows.Forms.RadioButton RbQui;
        private System.Windows.Forms.RadioButton RbQuoi;
    }
}