namespace Aplicacion_de_Identificacion
{
    partial class FormProdigy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSerial = new System.Windows.Forms.TextBox();
            this.TxtMaterial = new System.Windows.Forms.TextBox();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            this.PicBox2 = new System.Windows.Forms.PictureBox();
            this.PicBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Serie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Material:";
            // 
            // TxtSerial
            // 
            this.TxtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerial.Location = new System.Drawing.Point(56, 70);
            this.TxtSerial.Name = "TxtSerial";
            this.TxtSerial.Size = new System.Drawing.Size(164, 28);
            this.TxtSerial.TabIndex = 2;
            this.TxtSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSerial_KeyDown);
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.Enabled = false;
            this.TxtMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaterial.Location = new System.Drawing.Point(276, 70);
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.Size = new System.Drawing.Size(164, 28);
            this.TxtMaterial.TabIndex = 3;
            this.TxtMaterial.TextChanged += new System.EventHandler(this.TxtMaterial_TextChanged);
            // 
            // PicBox1
            // 
            this.PicBox1.Location = new System.Drawing.Point(56, 132);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(902, 540);
            this.PicBox1.TabIndex = 4;
            this.PicBox1.TabStop = false;
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.Location = new System.Drawing.Point(844, 12);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(130, 30);
            this.PicBoxLogo.TabIndex = 6;
            this.PicBoxLogo.TabStop = false;
            // 
            // PicBox2
            // 
            this.PicBox2.Location = new System.Drawing.Point(21, 163);
            this.PicBox2.Name = "PicBox2";
            this.PicBox2.Size = new System.Drawing.Size(487, 461);
            this.PicBox2.TabIndex = 7;
            this.PicBox2.TabStop = false;
            // 
            // PicBox3
            // 
            this.PicBox3.Location = new System.Drawing.Point(514, 163);
            this.PicBox3.Name = "PicBox3";
            this.PicBox3.Size = new System.Drawing.Size(486, 461);
            this.PicBox3.TabIndex = 8;
            this.PicBox3.TabStop = false;
            // 
            // FormProdigy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 727);
            this.Controls.Add(this.PicBox3);
            this.Controls.Add(this.PicBox2);
            this.Controls.Add(this.PicBoxLogo);
            this.Controls.Add(this.PicBox1);
            this.Controls.Add(this.TxtMaterial);
            this.Controls.Add(this.TxtSerial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProdigy";
            this.ShowIcon = false;
            this.Text = "Seleccion de Adaptador";
            this.Load += new System.EventHandler(this.FormProdigy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSerial;
        private System.Windows.Forms.TextBox TxtMaterial;
        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.PictureBox PicBoxLogo;
        private System.Windows.Forms.PictureBox PicBox2;
        private System.Windows.Forms.PictureBox PicBox3;
    }
}