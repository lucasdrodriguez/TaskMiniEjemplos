using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading; // thread.sleep   y   cancellationTokenSource 
using System.Threading.Tasks; // task
using System.Windows.Forms;

namespace Task_09
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts;
       // CancellationToken ct;

        public Form1()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
         //   ct = cts.Token;
        }

        private async void btn_longTask_Click(object sender, EventArgs e)
        {
            try
            {
                this.lb_informacion.Text = await GestorDatos.TraerRegistros2(cts.Token);
            }
            catch (TaskCanceledException ex)
            {
                lb_informacion.Text = ex.Message;
            }

            catch (OperationCanceledException ex)
            {
                lb_informacion.Text = ex.Message;
            }
          
            catch (Exception ex)
            {
                lb_informacion.Text = ex.Message;
            }



        }

        private void btn_cancelarTarea_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
