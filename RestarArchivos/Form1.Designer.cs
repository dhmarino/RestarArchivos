namespace RestarArchivos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnArchivoOriginal = new System.Windows.Forms.Button();
            this.BtnArchivoRestar = new System.Windows.Forms.Button();
            this.BtnSaveResult = new System.Windows.Forms.Button();
            this.lblArchivoOriginal = new System.Windows.Forms.Label();
            this.lblArchivoDescontar = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnArchivoOriginal
            // 
            this.BtnArchivoOriginal.Location = new System.Drawing.Point(217, 70);
            this.BtnArchivoOriginal.Name = "BtnArchivoOriginal";
            this.BtnArchivoOriginal.Size = new System.Drawing.Size(356, 60);
            this.BtnArchivoOriginal.TabIndex = 0;
            this.BtnArchivoOriginal.Text = "Seleccionar Archivo Original";
            this.BtnArchivoOriginal.UseVisualStyleBackColor = true;
            this.BtnArchivoOriginal.Click += new System.EventHandler(this.BtnArchivoOriginal_Click);
            // 
            // BtnArchivoRestar
            // 
            this.BtnArchivoRestar.Location = new System.Drawing.Point(217, 222);
            this.BtnArchivoRestar.Name = "BtnArchivoRestar";
            this.BtnArchivoRestar.Size = new System.Drawing.Size(356, 60);
            this.BtnArchivoRestar.TabIndex = 1;
            this.BtnArchivoRestar.Text = "Selecciona archivo a descontar";
            this.BtnArchivoRestar.UseVisualStyleBackColor = true;
            this.BtnArchivoRestar.Click += new System.EventHandler(this.BtnArchivoRestar_Click);
            // 
            // BtnSaveResult
            // 
            this.BtnSaveResult.Location = new System.Drawing.Point(217, 391);
            this.BtnSaveResult.Name = "BtnSaveResult";
            this.BtnSaveResult.Size = new System.Drawing.Size(356, 60);
            this.BtnSaveResult.TabIndex = 2;
            this.BtnSaveResult.Text = "Guardar archivo resultante";
            this.BtnSaveResult.UseVisualStyleBackColor = true;
            this.BtnSaveResult.Click += new System.EventHandler(this.BtnSaveResult_Click_1);
            // 
            // lblArchivoOriginal
            // 
            this.lblArchivoOriginal.Location = new System.Drawing.Point(12, 138);
            this.lblArchivoOriginal.Name = "lblArchivoOriginal";
            this.lblArchivoOriginal.Size = new System.Drawing.Size(750, 76);
            this.lblArchivoOriginal.TabIndex = 3;
            this.lblArchivoOriginal.Text = "Archivo Original";
            this.lblArchivoOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchivoDescontar
            // 
            this.lblArchivoDescontar.Location = new System.Drawing.Point(12, 289);
            this.lblArchivoDescontar.Name = "lblArchivoDescontar";
            this.lblArchivoDescontar.Size = new System.Drawing.Size(750, 76);
            this.lblArchivoDescontar.TabIndex = 4;
            this.lblArchivoDescontar.Text = "Archivo Descontar";
            this.lblArchivoDescontar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(597, 495);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(165, 25);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version X.X.X.X";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblArchivoDescontar);
            this.Controls.Add(this.lblArchivoOriginal);
            this.Controls.Add(this.BtnSaveResult);
            this.Controls.Add(this.BtnArchivoRestar);
            this.Controls.Add(this.BtnArchivoOriginal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restar Archivos de texto lineas repetidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnArchivoOriginal;
        private System.Windows.Forms.Button BtnArchivoRestar;
        private System.Windows.Forms.Button BtnSaveResult;
        private System.Windows.Forms.Label lblArchivoOriginal;
        private System.Windows.Forms.Label lblArchivoDescontar;
        private System.Windows.Forms.Label lblVersion;
    }
}

