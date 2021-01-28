using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_Semaforo
{
    public partial class Form1 : Form

    {
        private Semaforo luz;
        int caso;

        public Form1()
        {
            InitializeComponent();
            luz = this.luz = new Semaforo();
            luz.setLuz1(int.Parse("8"));
            luz.setLuz1(int.Parse("1"));
            atualizaSemaforo();

        }

        public void zerarRua2()
        {
            luz.setLuz0(int.Parse("8"));
            luz.setLuz0(int.Parse("7"));
            luz.setLuz0(int.Parse("6"));
        }

        public void zerarRua1()
        {
            luz.setLuz0(int.Parse("3"));
            luz.setLuz0(int.Parse("2"));
            luz.setLuz0(int.Parse("1"));
        }

        private void btnVml2_Click(object sender, EventArgs e)
        {
            zerarRua2();
            luz.setLuz1(int.Parse("8"));
            atualizaSemaforo();
        }

        private void btnAm2_Click(object sender, EventArgs e)
        {
            zerarRua2();
            luz.setLuz1(int.Parse("7"));
            atualizaSemaforo();
        }

        private void btnVd2_Click(object sender, EventArgs e)
        {
            zerarRua2();
            luz.setLuz1(int.Parse("6"));
            atualizaSemaforo();
        }

        private void btnVrm1_Click(object sender, EventArgs e)
        {
            zerarRua1();
            luz.setLuz1(int.Parse("3"));
            atualizaSemaforo();
        }

        private void btnAm1_Click(object sender, EventArgs e)
        {
            zerarRua1();
            luz.setLuz1(int.Parse("2"));
            atualizaSemaforo();
        }

        private void btnVd1_Click(object sender, EventArgs e)
        {
            zerarRua1();
            luz.setLuz1(int.Parse("1"));
            atualizaSemaforo();
        }

        public void atualizaSemaforo()
        {
            pictureSemaforo2.Image = (luz.getLuz(8)) ? projeto_Semaforo.Properties.Resources.vml : pictureSemaforo2.Image = (luz.getLuz(7)) ? projeto_Semaforo.Properties.Resources.amr : projeto_Semaforo.Properties.Resources.vd;
            pictureSemaforo1.Image = (luz.getLuz(3)) ? projeto_Semaforo.Properties.Resources.vml : pictureSemaforo1.Image = (luz.getLuz(2)) ? projeto_Semaforo.Properties.Resources.amr : projeto_Semaforo.Properties.Resources.vd;
            lblEstado.Text = Convert.ToString(luz.getLuz(),2);
        }

        private void radLiga_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void radDesliga_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            zerarRua1();
            zerarRua2();
            luz.setLuz1(int.Parse("8"));
            luz.setLuz1(int.Parse("1"));
            atualizaSemaforo();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(caso)
            {
                case 0:
                    zerarRua1();
                    zerarRua2();
                    luz.setLuz1(int.Parse("8"));
                    luz.setLuz1(int.Parse("1"));
                    atualizaSemaforo();
                    timer1.Interval = 3000;
                    caso = 1;
                    break;
                case 1:
                    zerarRua1();
                    zerarRua2();
                    luz.setLuz1(int.Parse("7"));
                    luz.setLuz1(int.Parse("2"));
                    atualizaSemaforo();
                    timer1.Interval = 3000;
                    caso = 2;
                    break;
                case 2:
                    zerarRua1();
                    zerarRua2();
                    luz.setLuz1(int.Parse("6"));
                    luz.setLuz1(int.Parse("3"));
                    atualizaSemaforo();
                    timer1.Interval = 5000;
                    caso = 3;
                    break;
                case 3:
                    zerarRua1();
                    zerarRua2();
                    luz.setLuz1(int.Parse("7"));
                    luz.setLuz1(int.Parse("2"));
                    atualizaSemaforo();
                    timer1.Interval = 5000;
                    caso = 0;
                    break;
            }
        }
    }
}
