namespace pryControlesBasicos
{
    partial class Formulario2
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
            this.txtEscribir = new System.Windows.Forms.TextBox();
            this.lblEscribir = new System.Windows.Forms.Label();
            this.lblTransformacion = new System.Windows.Forms.Label();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEscribir
            // 
            this.txtEscribir.Location = new System.Drawing.Point(17, 38);
            this.txtEscribir.Name = "txtEscribir";
            this.txtEscribir.Size = new System.Drawing.Size(200, 22);
            this.txtEscribir.TabIndex = 0;
            this.txtEscribir.TextChanged += new System.EventHandler(this.txtEscribir_TextChanged);
            // 
            // lblEscribir
            // 
            this.lblEscribir.AutoSize = true;
            this.lblEscribir.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscribir.Location = new System.Drawing.Point(12, 9);
            this.lblEscribir.Name = "lblEscribir";
            this.lblEscribir.Size = new System.Drawing.Size(95, 26);
            this.lblEscribir.TabIndex = 1;
            this.lblEscribir.Text = "Escribir:";
            // 
            // lblTransformacion
            // 
            this.lblTransformacion.AutoSize = true;
            this.lblTransformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransformacion.Location = new System.Drawing.Point(56, 78);
            this.lblTransformacion.Name = "lblTransformacion";
            this.lblTransformacion.Size = new System.Drawing.Size(148, 25);
            this.lblTransformacion.TabIndex = 2;
            this.lblTransformacion.Text = "Transformacion";
            this.lblTransformacion.Click += new System.EventHandler(this.lblTransformacion_Click);
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAzul.Location = new System.Drawing.Point(33, 140);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(63, 24);
            this.optAzul.TabIndex = 3;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRojo.Location = new System.Drawing.Point(156, 140);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(64, 24);
            this.optRojo.TabIndex = 4;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(40, 179);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(164, 52);
            this.btnAsignar.TabIndex = 5;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 256);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.lblTransformacion);
            this.Controls.Add(this.lblEscribir);
            this.Controls.Add(this.txtEscribir);
            this.Name = "Formulario2";
            this.Text = "Formulario2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.Label lblEscribir;
        private System.Windows.Forms.Label lblTransformacion;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.Button btnAsignar;
    }
}