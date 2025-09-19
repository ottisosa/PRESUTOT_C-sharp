using Microsoft.VisualBasic.PowerPacks.Printing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PREOSUTOT
{

    public partial class Form2 : Form
    {
        private int n = 0;

        public Form2()
        {
            InitializeComponent();
        }

        //CONDICION PARA QUE SE LLENEN TODOS LOS CAMPOS

        private void Forms2_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;            
        }
        private void validarCampo()
        {
            //PARA HABILITAR EL BOTON PARA AGREGAR A LA PLANILLA//

            var vr = !string.IsNullOrEmpty(txtbM.Text) &&
            !string.IsNullOrEmpty(txtbC.Text) &&
            !string.IsNullOrEmpty(txtbU.Text) &&
            !string.IsNullOrEmpty(txtbP.Text);
            btnAgregar.Enabled = vr;

        }
      
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
          
        }

        private void btnTotal_Click(object sender, EventArgs e) 
        {
            //BOTON QUE ME SUMA EL TOTAL DE TODO//
            sumaTotal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
         
   
                //VARIABLES//
                //HACEN LA SUMA DEL RESULTADO DE ESE MATERIAL// 

                double N1 = double.Parse(txtbP.Text);
                double N2 = double.Parse(txtbC.Text);
                double resultado = N1 * N2;

            //NUEVO RENGLON//

            int A = DGVtableta.Rows.Add();
     
        
            //PARA AGREGAR LA INFORMACION//


                DGVtableta.Rows[A].Cells[0].Value = txtbM.Text;            
                DGVtableta.Rows[A].Cells[1].Value = txtbU.Text;
                DGVtableta.Rows[A].Cells[2].Value = txtbC.Text;
                DGVtableta.Rows[A].Cells[3].Value = txtbP.Text;
                DGVtableta.Rows[A].Cells[4].Value = resultado;

           

        }

        //ADVERTENCIAS PARA LOS CAMPOS(SOLO NUMEROS---SOLO LETRAS)//

        private void txtbCC(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ADVERTENCIA, SOLO NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbPP(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ADVERTENCIA, SOLO NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbMM(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("ADVERTENCIA, SOLO LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbM_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtbC_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtbU_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtbP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbP_TextChanged_1(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //BOTON PARA LIMPIAR LOS CAMPOS//

            txtbP.Clear();
            txtbC.Clear();
            txtbU.Clear();
            txtbM.Clear();
        }
        private void labeli(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                lbli.Text = (string)DGVtableta.Rows[n].Cells[0].Value;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BOTON PARA LIMPIAR  LA TABLA//
    
            if (n!= -1)
            {
                DGVtableta.Rows.RemoveAt(n);
            }
           
        }

        private void DGVtableta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            //TEXT BOX QUE ME MUESTRA EL TOTAL DE TODO//
            
  
        }
        private void sumaTotal()
        {
            //PARA SUMAR EL TOTAL EN EL TEXT BOX DE TOTAL//
            decimal total = 0;
            foreach(DataGridViewRow row in DGVtableta.Rows)
            {
                if (Convert.ToString(row.Cells["PTmaterial"].Value) == txtTotal.Text);
                total += Convert.ToDecimal(row.Cells["PTmaterial"].Value);
            }
            txtTotal.Text = total.ToString();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            //BOTON DE IMPRIMIR//

             PrintForm printForm = new PrintForm();
            printForm.Form = this;
          // printForm.PrinterSettings.DefaultPageSettings.Landscape = true;
            printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm.Print(this, PrintForm.PrintOption.FullWindow);
         



        }

    }

}
