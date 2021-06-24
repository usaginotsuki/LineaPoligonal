
namespace LineaPoligonal
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
            this.picLienzo = new System.Windows.Forms.PictureBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLienzo
            // 
            this.picLienzo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picLienzo.Location = new System.Drawing.Point(27, 48);
            this.picLienzo.Name = "picLienzo";
            this.picLienzo.Size = new System.Drawing.Size(744, 375);
            this.picLienzo.TabIndex = 0;
            this.picLienzo.TabStop = false;
            this.picLienzo.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLienzo_MouseDown);
            this.picLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picLienzo_MouseMove);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(229, 12);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(54, 12);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.picLienzo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLienzo;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
    }
}

