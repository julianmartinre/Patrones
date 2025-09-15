namespace Patrones.Facade
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
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnExamen = new System.Windows.Forms.Button();
            this.btnCuota = new System.Windows.Forms.Button();
            this.btnSueldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(12, 12);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(776, 355);
            this.lstLog.TabIndex = 0;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInscribir.Location = new System.Drawing.Point(12, 373);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(137, 23);
            this.btnInscribir.TabIndex = 1;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnExamen
            // 
            this.btnExamen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExamen.Location = new System.Drawing.Point(155, 373);
            this.btnExamen.Name = "btnExamen";
            this.btnExamen.Size = new System.Drawing.Size(137, 23);
            this.btnExamen.TabIndex = 2;
            this.btnExamen.Text = "Pagar examen";
            this.btnExamen.UseVisualStyleBackColor = true;
            this.btnExamen.Click += new System.EventHandler(this.btnExamen_Click);
            // 
            // btnCuota
            // 
            this.btnCuota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCuota.Location = new System.Drawing.Point(298, 373);
            this.btnCuota.Name = "btnCuota";
            this.btnCuota.Size = new System.Drawing.Size(137, 23);
            this.btnCuota.TabIndex = 3;
            this.btnCuota.Text = "Pagar cuota";
            this.btnCuota.UseVisualStyleBackColor = true;
            this.btnCuota.Click += new System.EventHandler(this.btnCuota_Click);
            // 
            // btnSueldo
            // 
            this.btnSueldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSueldo.Location = new System.Drawing.Point(441, 373);
            this.btnSueldo.Name = "btnSueldo";
            this.btnSueldo.Size = new System.Drawing.Size(137, 23);
            this.btnSueldo.TabIndex = 4;
            this.btnSueldo.Text = "Liquidar sueldo";
            this.btnSueldo.UseVisualStyleBackColor = true;
            this.btnSueldo.Click += new System.EventHandler(this.btnSueldo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.btnSueldo);
            this.Controls.Add(this.btnCuota);
            this.Controls.Add(this.btnExamen);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.lstLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnExamen;
        private System.Windows.Forms.Button btnCuota;
        private System.Windows.Forms.Button btnSueldo;
    }
}

