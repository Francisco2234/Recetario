namespace Francisco
{
    partial class Menú
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
            this.agregarrecetas = new System.Windows.Forms.Button();
            this.agregaringrediente = new System.Windows.Forms.Button();
            this.cocinar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregarrecetas
            // 
            this.agregarrecetas.Location = new System.Drawing.Point(275, 329);
            this.agregarrecetas.Name = "agregarrecetas";
            this.agregarrecetas.Size = new System.Drawing.Size(231, 84);
            this.agregarrecetas.TabIndex = 0;
            this.agregarrecetas.Text = "Agregar Recetas";
            this.agregarrecetas.UseVisualStyleBackColor = true;
            this.agregarrecetas.Click += new System.EventHandler(this.Button1_Click);
            // 
            // agregaringrediente
            // 
            this.agregaringrediente.Location = new System.Drawing.Point(275, 199);
            this.agregaringrediente.Name = "agregaringrediente";
            this.agregaringrediente.Size = new System.Drawing.Size(231, 84);
            this.agregaringrediente.TabIndex = 1;
            this.agregaringrediente.Text = "Agregar Ingrediente";
            this.agregaringrediente.UseVisualStyleBackColor = true;
            // 
            // cocinar
            // 
            this.cocinar.Location = new System.Drawing.Point(275, 76);
            this.cocinar.Name = "cocinar";
            this.cocinar.Size = new System.Drawing.Size(231, 84);
            this.cocinar.TabIndex = 2;
            this.cocinar.Text = "Cocinar";
            this.cocinar.UseVisualStyleBackColor = true;
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cocinar);
            this.Controls.Add(this.agregaringrediente);
            this.Controls.Add(this.agregarrecetas);
            this.Name = "Menú";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agregarrecetas;
        private System.Windows.Forms.Button agregaringrediente;
        private System.Windows.Forms.Button cocinar;
    }
}

