using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gas_control
{
    public partial class gasControlForm : Form
    {
        
        Timer timerFast = new Timer();
        Timer timerLow = new Timer();
        randomNumber random = new randomNumber();
        
        public gasControlForm()
        {
            InitializeComponent();
            initTimers();

            
        }
        
        private void TimerLow_Tick(object sender, EventArgs e)
        {                                              
            txtVelocidad.Text = random.getNumRandom(788,810);
            txtTemperatura.Text = random.getNumRandom(0, 10);
            txtCoCorregido.Text = random.getNumDoubleRandom(0.15, .30).ToString("N2");
            txtNo.Text = random.getNumDoubleRandom(0.50, 1.00).ToString("N2");
            txtZzp.Text = random.getNumRandom(0, 10);

            
        }

        private void TimerFast_Tick(object Sender, EventArgs e)
        {
            txtCO.Text = random.getNumDoubleRandom(0.2, 0.26).ToString("N2");
            txtCo2.Text = random.getNumDoubleRandom(12.50, 13.70).ToString("N2");
            txtHc.Text = random.getNumRandom(250, 500);
            txt02.Text = random.getNumDoubleRandom(2.50, 3.90).ToString("N2");
            txtLamda.Text = random.getNumDoubleRandom(1.100, 1.200).ToString("N3");
        }

        void initTimers()
        {           
            timerFast.Interval = 2000;
            timerLow.Interval = 5000;
            timerFast.Tick += new EventHandler(TimerFast_Tick);
            timerLow.Tick += new EventHandler(TimerLow_Tick);


        }

        void enableTimer(bool opt)
        {
            btnIniciar.Text = ">>";
            timerLow.Enabled = opt;
            timerFast.Enabled = opt;
           

        }

        private void txtPausar_Click(object sender, EventArgs e)
        {
            enableTimer(false);
            
        }

        private void txtIniciar_Click(object sender, EventArgs e)
        {
            enableTimer(true);
           
            if(btnIniciar.Text == ">>" )
            {
                btnIniciar.Text = ">";
                
            }





        }

        private void gasControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            enableTimer(false);
        }

        private void gasControlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
