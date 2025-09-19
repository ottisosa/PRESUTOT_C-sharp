using PRESUTOT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PREOSUTOT
{
    public partial class forms1 : Form
    {
    
        
        public forms1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            
            //BOTON PARA ACCEDER A LA CALCULADORA DE CANTIDADES//

            Form2 v1 = new Form2();

            v1.Show();
            
                
             


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BOTON PARA ACCEDER A LA CALCULADORA DE PILARES//
           Form v2 = new Form3();

            v2.Show();
        }
    }
}

