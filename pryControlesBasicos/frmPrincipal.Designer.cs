namespace pryControlesBasicos
{
    partial class frmPrincipal
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.cmdFormulario2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblX.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(794, 5);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(22, 23);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblY
            // 
            this.lblY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblY.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(795, 34);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(22, 23);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(371, 188);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(262, 62);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.Visible = false;
            this.lblBienvenido.Click += new System.EventHandler(this.lblBienvenido_Click);
            this.lblBienvenido.MouseEnter += new System.EventHandler(this.lblBienvenido_MouseEnter);
            this.lblBienvenido.Move += new System.EventHandler(this.lblBienvenido_Move);
            // 
            // cmdFormulario2
            // 
            this.cmdFormulario2.Location = new System.Drawing.Point(12, 12);
            this.cmdFormulario2.Name = "cmdFormulario2";
            this.cmdFormulario2.Size = new System.Drawing.Size(75, 23);
            this.cmdFormulario2.TabIndex = 3;
            this.cmdFormulario2.Text = "Formulario 2";
            this.cmdFormulario2.UseVisualStyleBackColor = true;
            this.cmdFormulario2.Click += new System.EventHandler(this.cmdFormulario2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.cmdFormulario2);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Controles Basicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Click += new System.EventHandler(this.frmPrincipal_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            this.Move += new System.EventHandler(this.frmPrincipal_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button cmdFormulario2;
    }
}