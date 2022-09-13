using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_64_Sesli_Komut_İşlemleri___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);

            try
            {
                button1.Text = "Konuşun";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                button1.Text = res.Text;
            }
            catch (Exception exception)
            {

                button1.Text = "Hata :"+exception.Message;
            }
        }
    }
}
