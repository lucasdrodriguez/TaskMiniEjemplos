using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_iniciarLongTask2_Click(object sender, EventArgs e)
        {


        }

        private async void btn_iniciarLongTask_Click(object sender, EventArgs e)
        {

            this.lb_informacion.Text = await GestorDatos.TraerRegistros2Async();

        }


    }
}
