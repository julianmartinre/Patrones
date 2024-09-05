namespace Patrones.Builder
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
            this.lstEntregas = new System.Windows.Forms.ListBox();
            this.btnConstruír = new System.Windows.Forms.Button();
            this.cboLineas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEntregas
            // 
            this.lstEntregas.FormattingEnabled = true;
            this.lstEntregas.Location = new System.Drawing.Point(11, 71);
            this.lstEntregas.Margin = new System.Windows.Forms.Padding(2);
            this.lstEntregas.Name = "lstEntregas";
            this.lstEntregas.Size = new System.Drawing.Size(722, 173);
            this.lstEntregas.TabIndex = 7;
            // 
            // btnConstruír
            // 
            this.btnConstruír.Location = new System.Drawing.Point(186, 29);
            this.btnConstruír.Margin = new System.Windows.Forms.Padding(2);
            this.btnConstruír.Name = "btnConstruír";
            this.btnConstruír.Size = new System.Drawing.Size(121, 24);
            this.btnConstruír.TabIndex = 6;
            this.btnConstruír.Text = "Constuír Pizza";
            this.btnConstruír.UseVisualStyleBackColor = true;
            this.btnConstruír.Click += new System.EventHandler(this.btnConstruír_Click);
            // 
            // cboLineas
            // 
            this.cboLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineas.FormattingEnabled = true;
            this.cboLineas.Location = new System.Drawing.Point(11, 32);
            this.cboLineas.Margin = new System.Windows.Forms.Padding(2);
            this.cboLineas.Name = "cboLineas";
            this.cboLineas.Size = new System.Drawing.Size(138, 21);
            this.cboLineas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione línea de montaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 259);
            this.Controls.Add(this.lstEntregas);
            this.Controls.Add(this.btnConstruír);
            this.Controls.Add(this.cboLineas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Patrón Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEntregas;
        private System.Windows.Forms.Button btnConstruír;
        private System.Windows.Forms.ComboBox cboLineas;
        private System.Windows.Forms.Label label1;
    }
}

