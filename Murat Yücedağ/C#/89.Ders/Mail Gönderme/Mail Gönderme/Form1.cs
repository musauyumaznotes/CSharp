using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace Mail_Gönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new NetworkCredential("csharpdersleri@hotmail.com","12345678C#+");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(textBox1.Text);
            mesaj.From = new MailAddress("csharpdersleri@hotmail.com");
            mesaj.Subject=textBox2.Text;
            mesaj.Body = textBox3.Text;
            istemci.Send(mesaj);


        }
    }
}
