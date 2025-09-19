using Microsoft.VisualBasic.PowerPacks.Printing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESUTOT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            //BOTON PARA IMPRIMIR//

            PrintForm printForm = new PrintForm();
            printForm.Form = this;
            printForm.PrinterSettings.DefaultPageSettings.Landscape = true;
            printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm.Print(this, PrintForm.PrintOption.FullWindow);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
