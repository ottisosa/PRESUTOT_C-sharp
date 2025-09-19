namespace PREOSUTOT
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblCalc2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtbU = new System.Windows.Forms.TextBox();
            this.txtbM = new System.Windows.Forms.TextBox();
            this.txtbC = new System.Windows.Forms.TextBox();
            this.txtbP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLT = new System.Windows.Forms.Button();
            this.DGVtableta = new System.Windows.Forms.DataGridView();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTmaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbli = new System.Windows.Forms.Label();
            this.btnImpresora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtableta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalc2
            // 
            this.lblCalc2.AutoSize = true;
            this.lblCalc2.BackColor = System.Drawing.Color.Transparent;
            this.lblCalc2.Font = new System.Drawing.Font("crypto CRASH", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalc2.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblCalc2.Location = new System.Drawing.Point(11, 9);
            this.lblCalc2.Name = "lblCalc2";
            this.lblCalc2.Size = new System.Drawing.Size(564, 43);
            this.lblCalc2.TabIndex = 0;
            this.lblCalc2.Text = "Calculadora De Presupuestos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("crypto CRASH", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba El Material Que Quiere Calcular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("crypto CRASH", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(507, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite El Precio Por (Unidad o Metro Cubico)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("crypto CRASH", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(613, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "$";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(651, 777);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(153, 29);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("crypto CRASH", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(516, 774);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 30);
            this.label20.TabIndex = 9;
            this.label20.Text = "Total  $";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("crypto CRASH", 10.8F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(516, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(317, 20);
            this.label21.TabIndex = 10;
            this.label21.Text = "Seleccione La Cantidad Que Nececita";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Red;
            this.btnAgregar.Font = new System.Drawing.Font("crypto CRASH", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(173, 338);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(255, 50);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar A La Planilla";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Red;
            this.btnTotal.Font = new System.Drawing.Font("crypto CRASH", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.Location = new System.Drawing.Point(327, 773);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(169, 30);
            this.btnTotal.TabIndex = 13;
            this.btnTotal.Text = "Sumar Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("crypto CRASH", 13.2F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(541, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 23);
            this.label22.TabIndex = 14;
            this.label22.Text = "Cantidad";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("crypto CRASH", 10.8F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(40, 224);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(299, 20);
            this.label23.TabIndex = 15;
            this.label23.Text = "Digite La Unidad En La Que Se Vende";
            // 
            // txtbU
            // 
            this.txtbU.Font = new System.Drawing.Font("crypto CRASH", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbU.Location = new System.Drawing.Point(117, 263);
            this.txtbU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbU.Name = "txtbU";
            this.txtbU.Size = new System.Drawing.Size(125, 27);
            this.txtbU.TabIndex = 16;
            this.txtbU.TextChanged += new System.EventHandler(this.txtbU_TextChanged);
            // 
            // txtbM
            // 
            this.txtbM.Font = new System.Drawing.Font("crypto CRASH", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbM.Location = new System.Drawing.Point(83, 124);
            this.txtbM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbM.Name = "txtbM";
            this.txtbM.Size = new System.Drawing.Size(223, 37);
            this.txtbM.TabIndex = 17;
            this.txtbM.TextChanged += new System.EventHandler(this.txtbM_TextChanged);
            this.txtbM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbMM);
            // 
            // txtbC
            // 
            this.txtbC.Font = new System.Drawing.Font("crypto CRASH", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbC.Location = new System.Drawing.Point(660, 133);
            this.txtbC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbC.Name = "txtbC";
            this.txtbC.Size = new System.Drawing.Size(125, 27);
            this.txtbC.TabIndex = 18;
            this.txtbC.TextChanged += new System.EventHandler(this.txtbC_TextChanged);
            this.txtbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCC);
            // 
            // txtbP
            // 
            this.txtbP.Font = new System.Drawing.Font("crypto CRASH", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbP.Location = new System.Drawing.Point(651, 265);
            this.txtbP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbP.Name = "txtbP";
            this.txtbP.Size = new System.Drawing.Size(125, 27);
            this.txtbP.TabIndex = 19;
            this.txtbP.TextChanged += new System.EventHandler(this.txtbP_TextChanged_1);
            this.txtbP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPP);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("crypto CRASH", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(483, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLT
            // 
            this.btnLT.BackColor = System.Drawing.Color.Teal;
            this.btnLT.Font = new System.Drawing.Font("crypto CRASH", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLT.ForeColor = System.Drawing.Color.White;
            this.btnLT.Location = new System.Drawing.Point(43, 770);
            this.btnLT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLT.Name = "btnLT";
            this.btnLT.Size = new System.Drawing.Size(187, 39);
            this.btnLT.TabIndex = 21;
            this.btnLT.Text = "Limpiar Fila";
            this.btnLT.UseVisualStyleBackColor = false;
            this.btnLT.Click += new System.EventHandler(this.button2_Click);
            // 
            // DGVtableta
            // 
            this.DGVtableta.AllowUserToAddRows = false;
            this.DGVtableta.AllowUserToResizeColumns = false;
            this.DGVtableta.AllowUserToResizeRows = false;
            this.DGVtableta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVtableta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVtableta.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVtableta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVtableta.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVtableta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVtableta.ColumnHeadersHeight = 45;
            this.DGVtableta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVtableta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.material,
            this.unidad,
            this.cantidad,
            this.PUnidad,
            this.PTmaterial});
            this.DGVtableta.Location = new System.Drawing.Point(27, 394);
            this.DGVtableta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVtableta.Name = "DGVtableta";
            this.DGVtableta.ReadOnly = true;
            this.DGVtableta.RowHeadersWidth = 60;
            this.DGVtableta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVtableta.RowTemplate.Height = 24;
            this.DGVtableta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVtableta.Size = new System.Drawing.Size(856, 367);
            this.DGVtableta.TabIndex = 22;
            this.DGVtableta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.labeli);
            this.DGVtableta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVtableta_CellContentClick);
            // 
            // material
            // 
            this.material.HeaderText = "Material";
            this.material.MinimumWidth = 6;
            this.material.Name = "material";
            this.material.ReadOnly = true;
            this.material.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.material.Width = 105;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.MinimumWidth = 6;
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            this.unidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unidad.Width = 95;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidad.Width = 111;
            // 
            // PUnidad
            // 
            this.PUnidad.HeaderText = "Precio Por Unidad";
            this.PUnidad.MinimumWidth = 6;
            this.PUnidad.Name = "PUnidad";
            this.PUnidad.ReadOnly = true;
            this.PUnidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PUnidad.Width = 180;
            // 
            // PTmaterial
            // 
            this.PTmaterial.HeaderText = "Precio Total De El Material";
            this.PTmaterial.MinimumWidth = 6;
            this.PTmaterial.Name = "PTmaterial";
            this.PTmaterial.ReadOnly = true;
            this.PTmaterial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PTmaterial.Width = 247;
            // 
            // lbli
            // 
            this.lbli.AutoSize = true;
            this.lbli.Font = new System.Drawing.Font("crypto CRASH", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbli.ForeColor = System.Drawing.Color.White;
            this.lbli.Location = new System.Drawing.Point(15, 306);
            this.lbli.Name = "lbli";
            this.lbli.Size = new System.Drawing.Size(0, 18);
            this.lbli.TabIndex = 23;
            // 
            // btnImpresora
            // 
            this.btnImpresora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImpresora.Font = new System.Drawing.Font("crypto CRASH", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpresora.ForeColor = System.Drawing.Color.White;
            this.btnImpresora.Location = new System.Drawing.Point(696, 18);
            this.btnImpresora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImpresora.Name = "btnImpresora";
            this.btnImpresora.Size = new System.Drawing.Size(137, 39);
            this.btnImpresora.TabIndex = 24;
            this.btnImpresora.Text = "Imprimir";
            this.btnImpresora.UseVisualStyleBackColor = false;
            this.btnImpresora.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(941, 823);
            this.Controls.Add(this.btnImpresora);
            this.Controls.Add(this.lbli);
            this.Controls.Add(this.DGVtableta);
            this.Controls.Add(this.btnLT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbP);
            this.Controls.Add(this.txtbC);
            this.Controls.Add(this.txtbM);
            this.Controls.Add(this.txtbU);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCalc2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "CALCULADORA DE PRESUPUESTOS";
            this.Load += new System.EventHandler(this.Forms2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVtableta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtbU;
        private System.Windows.Forms.TextBox txtbM;
        private System.Windows.Forms.TextBox txtbC;
        private System.Windows.Forms.TextBox txtbP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLT;
        private System.Windows.Forms.DataGridView DGVtableta;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTmaterial;
        private System.Windows.Forms.Label lbli;
        private System.Windows.Forms.Button btnImpresora;
    }
}