namespace PREOSUTOT
{
    partial class forms1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forms1));
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.lblPresutot = new System.Windows.Forms.Label();
            this.lblFacil = new System.Windows.Forms.Label();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnPilares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Computer Typewriter", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.ForeColor = System.Drawing.Color.White;
            this.lblBienvenidos.Location = new System.Drawing.Point(53, 38);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(361, 36);
            this.lblBienvenidos.TabIndex = 0;
            this.lblBienvenidos.Text = "Bienvenidos a";
            // 
            // lblPresutot
            // 
            this.lblPresutot.AutoSize = true;
            this.lblPresutot.Font = new System.Drawing.Font("crypto CRASH", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresutot.ForeColor = System.Drawing.Color.Red;
            this.lblPresutot.Location = new System.Drawing.Point(278, 99);
            this.lblPresutot.Name = "lblPresutot";
            this.lblPresutot.Size = new System.Drawing.Size(284, 65);
            this.lblPresutot.TabIndex = 1;
            this.lblPresutot.Text = "PRESUTOT";
            // 
            // lblFacil
            // 
            this.lblFacil.AutoSize = true;
            this.lblFacil.Font = new System.Drawing.Font("crypto CRASH", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacil.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFacil.Location = new System.Drawing.Point(297, 164);
            this.lblFacil.Name = "lblFacil";
            this.lblFacil.Size = new System.Drawing.Size(239, 22);
            this.lblFacil.TabIndex = 2;
            this.lblFacil.Text = "Donde Todo Es Mas Facil";
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.Color.Blue;
            this.btnCalculadora.Font = new System.Drawing.Font("crypto CRASH", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCalculadora.Location = new System.Drawing.Point(203, 255);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(466, 80);
            this.btnCalculadora.TabIndex = 3;
            this.btnCalculadora.Text = "Calcular Cantidades";
            this.btnCalculadora.UseVisualStyleBackColor = false;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnPilares
            // 
            this.btnPilares.BackColor = System.Drawing.Color.Blue;
            this.btnPilares.Font = new System.Drawing.Font("crypto CRASH", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilares.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPilares.Location = new System.Drawing.Point(203, 406);
            this.btnPilares.Name = "btnPilares";
            this.btnPilares.Size = new System.Drawing.Size(466, 80);
            this.btnPilares.TabIndex = 4;
            this.btnPilares.Text = "Calcular Pilares";
            this.btnPilares.UseVisualStyleBackColor = false;
            this.btnPilares.Click += new System.EventHandler(this.button1_Click);
            // 
            // forms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.btnPilares);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.lblFacil);
            this.Controls.Add(this.lblPresutot);
            this.Controls.Add(this.lblBienvenidos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "forms1";
            this.Text = "PRESUTOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Label lblPresutot;
        private System.Windows.Forms.Label lblFacil;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnPilares;
    }
}


