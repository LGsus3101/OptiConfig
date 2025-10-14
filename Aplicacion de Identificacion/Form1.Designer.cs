namespace Aplicacion_de_Identificacion
{
    partial class FrmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAppRegistro = new System.Windows.Forms.Button();
            this.BtnAppProdigy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAppRegistro
            // 
            this.BtnAppRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppRegistro.Location = new System.Drawing.Point(61, 83);
            this.BtnAppRegistro.Name = "BtnAppRegistro";
            this.BtnAppRegistro.Size = new System.Drawing.Size(189, 67);
            this.BtnAppRegistro.TabIndex = 0;
            this.BtnAppRegistro.Text = "Guia de punta de Desforre";
            this.BtnAppRegistro.UseVisualStyleBackColor = true;
            this.BtnAppRegistro.Click += new System.EventHandler(this.BtnAppRegistro_Click);
            // 
            // BtnAppProdigy
            // 
            this.BtnAppProdigy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppProdigy.Location = new System.Drawing.Point(31, 194);
            this.BtnAppProdigy.Name = "BtnAppProdigy";
            this.BtnAppProdigy.Size = new System.Drawing.Size(249, 90);
            this.BtnAppProdigy.TabIndex = 1;
            this.BtnAppProdigy.Text = "Identificacion de Conector\r\n(Prodigy)";
            this.BtnAppProdigy.UseVisualStyleBackColor = true;
            this.BtnAppProdigy.Click += new System.EventHandler(this.BtnAppProdigy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccion de Operacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAppProdigy);
            this.Controls.Add(this.BtnAppRegistro);
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAppRegistro;
        private System.Windows.Forms.Button BtnAppProdigy;
        private System.Windows.Forms.Label label1;
    }
}

