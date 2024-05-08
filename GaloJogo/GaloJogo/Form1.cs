using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaloJogo
{
    public partial class Form1 : Form
    {
        int turnC = 0, P1W = 0, P2W = 0, Ties = 0;
        bool i = true;
        int P1C = 0, P2C = 0;

        private void B1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "")
            {
                if(i)
                {
                    btn.Text = "X";
                    turnC++;
                    turnCount.Text = turnC.ToString();
                    i = !i;
                    checkwin();
                }
                else
                {
                    btn.Text = "O";
                    turnC++;
                    turnCount.Text = turnC.ToString();
                    i = !i;
                    checkwin();
                }
            }
        }

        public void limpar()
        {
            System.Windows.Forms.Timer timer;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // Define o intervalo para 2000 milissegundos (2 segundos)
            timer.Tick += (sender, e) =>
            {
                // Limpa os botões após o atraso
                B1.Text = B2.Text = B3.Text = B4.Text = B5.Text = B6.Text = B7.Text = B8.Text = B9.Text = "";
                B1.ForeColor =B2.ForeColor = B3.ForeColor = B4.ForeColor = B5.ForeColor = B6.ForeColor = B7.ForeColor = B8.ForeColor = B9.ForeColor = Color.White;
                turnC = 0;
                turnCount.Text = turnC.ToString();
                i = !i;
                timer.Stop(); // Para o Timer
            };
            timer.Start(); // Inicia o Timer
        }
        public void checkwin()
        {
            //horizontal
            if(B1.Text == B2.Text && B1.Text == B3.Text && B1.Text != "")
            {
                B1.ForeColor = B2.ForeColor = B3.ForeColor = Color.Red;
                if(B1.Text == "X")
                {
                    P1Count.Text = (++P1C).ToString();
                }
                else if(B1.Text == "O")
                {
                    P2Count.Text = (++P2C).ToString();
                }
                limpar();
            }
            else if (B4.Text == B5.Text && B4.Text == B6.Text && B4.Text != "")
            {
                B4.ForeColor = B5.ForeColor = B6.ForeColor = Color.Red;
                if (B4.Text == "X")
                {
                    P1Count.Text = (++P1C).ToString();
                }
                else if (B4.Text == "O")
                {
                    P2Count.Text = (++P2C).ToString();
                }
                limpar();
            }
            else if (B7.Text == B8.Text && B7.Text == B9.Text && B7.Text != "")
            {
                B7.ForeColor = B8.ForeColor = B9.ForeColor = Color.Red;
                if (B7.Text == "X")
                {
                    P1Count.Text = (++P1C).ToString();
                }
                else if (B7.Text == "O")
                {
                    P2Count.Text = (++P2C).ToString();
                }
                limpar();
            }
            //vertical
            if (B1.Text == B4.Text && B1.Text == B7.Text && B1.Text != "")
            {
                B1.ForeColor = B4.ForeColor = B7.ForeColor = Color.Red;
                if (B1.Text == "X")
                {
                    P1Count.Text = (++P1C).ToString();
                }
                else if (B1.Text == "O")
                {
                    P2Count.Text = (++P2C).ToString();
                }
                limpar();
            }
            else if (B2.Text == B5.Text && B2.Text == B8.Text && B2.Text != "")
            {
                B2.ForeColor = B5.ForeColor = B8.ForeColor = Color.Red;
                if (B2.Text == "X")
                {
                    P1Count.Text = (++P1C).ToString();
                }
                else if (B2.Text == "O")
                {
                    P2Count.Text = (++P2C).ToString();
                }
                limpar();
            }
            else if (B3.Text == B6.Text && B3.Text == B9.Text && B3.Text != "")
            {
                B3.ForeColor = B6.ForeColor = B9.ForeColor = Color.Red;
                if (B3.Text == "X")
                {
                    P1Count.Text = (++P1C).ToString();
                }
                else if (B3.Text == "O")
                {
                    P2Count.Text = (++P2C).ToString();
                }
                limpar();
            }
            //diagonal
            if (B1.Text == B5.Text && B1.Text == B9.Text && B1.Text != "")
            {
                B1.ForeColor = B5.ForeColor = B9.ForeColor = Color.Red;
                if (B1.Text == "X")
                {
                    P1Count.Text = (++P1C).ToString();
                }
                else if (B1.Text == "O")
                {
                    P2Count.Text = (++P2C).ToString();
                }
                limpar();
            }
            else if (B3.Text == B5.Text && B3.Text == B7.Text && B3.Text != "")
            {
                B3.ForeColor = B5.ForeColor = B7.ForeColor = Color.Red;
                if (B3.Text == "X")
                {
                    P1Count.Text = (++P1C).ToString();
                }
                else if (B3.Text == "O")
                {
                    P2Count.Text = (++P2C).ToString();
                }
                limpar();
            }
            //empate
            else if (B1.Text != "" && B2.Text != "" && B3.Text != "" && B4.Text != "" && B5.Text != "" && B6.Text != "" && B7.Text != "" && B8.Text != "" && B9.Text != "")
            {
                TieCount.Text = (++Ties).ToString();
                limpar();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        /*public void Count(int i)
        {
            if ((B1.Text != "") || (B2.Text != "") || (B3.Text != "") || (B4.Text != "") || (B5.Text != "") || (B6.Text != "") || (B7.Text != "") || (B8.Text != "") || (B9.Text != ""))
            {
                turnCount.Text = i.ToString();
                i++;
            }
        }*/
    }
}
