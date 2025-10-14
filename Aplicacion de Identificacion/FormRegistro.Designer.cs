namespace Aplicacion_de_Identificacion
{
    partial class FormRegistro
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
            this.TxtSerialNumber = new System.Windows.Forms.TextBox();
            this.TxtMaterialNumber = new System.Windows.Forms.TextBox();
            this.BoxImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSerialNumber
            // 
            this.TxtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerialNumber.Location = new System.Drawing.Point(72, 64);
            this.TxtSerialNumber.Name = "TxtSerialNumber";
            this.TxtSerialNumber.Size = new System.Drawing.Size(168, 28);
            this.TxtSerialNumber.TabIndex = 0;
            this.TxtSerialNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSerialNumber_KeyDown);
            // 
            // TxtMaterialNumber
            // 
            this.TxtMaterialNumber.Enabled = false;
            this.TxtMaterialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaterialNumber.Location = new System.Drawing.Point(338, 63);
            this.TxtMaterialNumber.Name = "TxtMaterialNumber";
            this.TxtMaterialNumber.Size = new System.Drawing.Size(199, 28);
            this.TxtMaterialNumber.TabIndex = 1;
            this.TxtMaterialNumber.TextChanged += new System.EventHandler(this.TxtMaterialNumber_TextChanged);
            // 
            // BoxImage
            // 
            this.BoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BoxImage.Location = new System.Drawing.Point(25, 123);
            this.BoxImage.Name = "BoxImage";
            this.BoxImage.Size = new System.Drawing.Size(939, 549);
            this.BoxImage.TabIndex = 2;
            this.BoxImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Serie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de Material:";
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.Location = new System.Drawing.Point(769, 12);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(229, 50);
            this.PicBoxLogo.TabIndex = 5;
            this.PicBoxLogo.TabStop = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 716);
            this.Controls.Add(this.PicBoxLogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxImage);
            this.Controls.Add(this.TxtMaterialNumber);
            this.Controls.Add(this.TxtSerialNumber);
            this.MaximizeBox = false;
            this.Name = "FormRegistro";
            this.ShowIcon = false;
            this.Text = "Guia de Desforre";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSerialNumber;
        private System.Windows.Forms.TextBox TxtMaterialNumber;
        private System.Windows.Forms.PictureBox BoxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PicBoxLogo;
    }
}