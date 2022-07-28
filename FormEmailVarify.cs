using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace DUET_Hall_Dining_Management_System
{
    public partial class FormEmailVarify : Form
    {
        public FormEmailVarify()
        {
            InitializeComponent();
        }
        public string randomCode;
        public static string to;
        public bool sendCoder(string usrName)
        {
            string from, password, MessageBody;
            Random rndm = new Random();
            randomCode = rndm.Next(999999).ToString();
            MailMessage milMesg = new MailMessage();
            to = textBoxEmail.Text;
            from = "supersecrebits@gmail.com";
            password = "S_hacker@02";
            MessageBody = "Your Reset Code is: "+randomCode + " and User_name is: "+usrName;
            milMesg.To.Add(to);
            milMesg.From = new MailAddress(from);
            milMesg.Body = MessageBody;
            milMesg.Subject = "Password reaseting code.";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, password);
            try
            {
                smtp.Send(milMesg);
                MessageBox.Show("Code send successfully.");
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        private void buttonCodeGo_Click(object sender, EventArgs e)
        {
            ClassDataRetrive dr = new ClassDataRetrive();
            foreach(string x in dr.eMailAdmin())
            {
                if(textBoxEmail.Text == x)
                {
                    
                    if (sendCoder(dr.singlAdminUserName(x)) == false)
                    {
                        MessageBox.Show("Please Cheak Out Your Internet connection.");
                        FormLogin li = new FormLogin();
                        li.Show();
                        this.Close();
                        return;
                    }
                    FormCodeVarify cv = new FormCodeVarify(randomCode, x,'A'); // 'A' represent Admin table identefir
                    this.Hide();
                    cv.Show();
                    return;
                }
            }
            foreach (string x in dr.eMailGenerel())
            {
                if (textBoxEmail.Text == x)
                {
                    
                    //MessageBox.Show(s[0]);
                    if (sendCoder(dr.singlGenerelUserName(x)) == false)
                    {
                        MessageBox.Show("Please Cheak Out Your Internet connection.");
                        FormLogin li = new FormLogin();
                        li.Show();
                        this.Close();
                        return;
                    }
                    FormCodeVarify cv = new FormCodeVarify(randomCode,x,'G');// 'G' represent generenl/user table identefir
                    this.Hide();
                    cv.Show();
                    return;
                }
            }
            MessageBox.Show("The Emile is invalid.");
        }
    }
}
