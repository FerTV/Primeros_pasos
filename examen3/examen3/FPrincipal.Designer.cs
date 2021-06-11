namespace examen3
{
    partial class FPrincipal
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
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_albaranes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clientes
            // 
            this.btn_clientes.Location = new System.Drawing.Point(220, 183);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(105, 52);
            this.btn_clientes.TabIndex = 0;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_albaranes
            // 
            this.btn_albaranes.Location = new System.Drawing.Point(413, 183);
            this.btn_albaranes.Name = "btn_albaranes";
            this.btn_albaranes.Size = new System.Drawing.Size(105, 52);
            this.btn_albaranes.TabIndex = 1;
            this.btn_albaranes.Text = "Albaranes";
            this.btn_albaranes.UseVisualStyleBackColor = true;
            this.btn_albaranes.Click += new System.EventHandler(this.btn_albaranes_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_albaranes);
            this.Controls.Add(this.btn_clientes);
            this.Name = "FPrincipal";
            this.Text = "FPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_albaranes;
    }
}

