using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_Odevler
{
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

      

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string[] data = txtMailAdresi.Text.ToLower().Split('@');
            string mail =data[1];

            switch (mail)
            {
                case "hotmail.com":
                    lstHotmailCom.Items.Add(mail);
                    break;
                case "hotmail.com.tr":
                    lstHotmailComTr.Items.Add(mail);
                    break;
                case "hotmail.net":
                    lstHotmailNet.Items.Add(mail);
                    break;
                case "gmail.com.tr":
                    lstGmailComTr.Items.Add(mail);
                    break;
                case "gmail.com":
                    lstGmailCom.Items.Add(mail);
                    break;
                case "gmail.net":
                    lstGmailNet.Items.Add(mail);
                    break;
                default:
                    lstCop.Items.Add(mail);
                    break;
            }

                    }

       

        private void btnAyristir_Click(object sender, EventArgs e)
        {
            lblHotmailCom.Text = lstHotmailCom.Items.Count.ToString();
            lblHotmailComTr.Text = lstHotmailComTr.Items.Count.ToString();
            lblHotmailNet.Text = lstHotmailNet.Items.Count.ToString();
            lblGmailCom.Text = lstGmailCom.Items.Count.ToString();
            lblGmailComTr.Text = lstGmailComTr.Items.Count.ToString();
            lblGmailNet.Text = lstGmailNet.Items.Count.ToString();
        }
    }
}
