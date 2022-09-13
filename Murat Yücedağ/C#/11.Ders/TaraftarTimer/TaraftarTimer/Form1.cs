using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaraftarTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (checkBoxFb.Checked==true)
            {
              
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.DarkBlue;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.DarkBlue;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.DarkBlue;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.DarkBlue;
                }
                else if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.DarkBlue;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.DarkBlue;
                    button5.BackColor = Color.DarkBlue;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.DarkBlue;
                    button8.BackColor = Color.Yellow;
                }
            }
            else if (checkBoxGs.Checked==true)
            {
               
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Red;
                }
                else if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Yellow;
                }
            }
            else if (checkBoxBjk.Checked == true)
            {
               
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button6.BackColor = Color.Black;
                    button7.BackColor = Color.White;
                    button8.BackColor = Color.Black;
                }
                else if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.Black;
                    button8.BackColor = Color.White;
                }
            }
            else if (checkBoxTs.Checked == true)
            {
                
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.DarkRed;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.DarkRed;
                    button4.BackColor = Color.Blue;
                    button5.BackColor = Color.Blue;
                    button6.BackColor = Color.DarkRed;
                    button7.BackColor = Color.Blue;
                    button8.BackColor = Color.DarkRed;
                }
                else if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Blue;
                    button2.BackColor = Color.DarkRed;
                    button3.BackColor = Color.Blue;
                    button4.BackColor = Color.DarkRed;
                    button5.BackColor = Color.DarkRed;
                    button6.BackColor = Color.Blue;
                    button7.BackColor = Color.DarkRed;
                    button8.BackColor = Color.Blue;
                }
            }

        }

        private void checkBoxFb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFb.Checked == true)
            {
                checkBoxGs.Enabled = false;
                checkBoxTs.Enabled = false;
                checkBoxBjk.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\4.Ders\Müzikler\fb.mp3";
                timer1.Enabled = true;

            }
           
        }

        private void checkBoxBjk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBjk.Checked == true)
            {
                checkBoxGs.Enabled = false;
                checkBoxTs.Enabled = false;
                checkBoxFb.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\4.Ders\Müzikler\bjk.mp3";
                timer1.Enabled = true;
            }
           
        }

        private void checkBoxGs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGs.Checked == true)
            {
                checkBoxFb.Enabled = false;
                checkBoxTs.Enabled = false;
                checkBoxBjk.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\4.Ders\Müzikler\gs.mp3";
                timer1.Enabled = true;
            }
           
        }

        private void checkBoxTs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTs.Checked==true)
            {
                checkBoxGs.Enabled = false;
                checkBoxFb.Enabled = false;
                checkBoxBjk.Enabled = false;
                axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\4.Ders\Müzikler\ts.mp3";
                timer1.Enabled = true;
            }
            
        }
    }
}
