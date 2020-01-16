using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountVerifier;
using System.Windows.Forms;

namespace BankAccuntManager
{
    public partial class Form1 : Form
    {
        GetAccountCoincidence accData = new GetAccountCoincidence();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }

        public string BoxValueOfAccount()
        {
            // didnt get value from box that are wrote!
            string box = AccountId_TextBox.Text;
            return box;
        }

        public void Login_Button_Click(object sender, EventArgs e)
        {
            
            accData.ReadAccountsFile(sender, e);
            if (accData.CheckIfExistThisId(AccountId_TextBox.Text))
            {
                if (progressBar1.Value == 100)
                {
                    progressBar1.Value = 0;
                }
                this.timer1.Start();


            }


            MessageBox.Show("Access Grant!");

        }

        public string idBoxValue = string.Empty;
        public string boxValue = string.Empty;
        public void AccountId_TextBox_TextChanged(object sender, EventArgs e)
        {



        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);
        }
    }
}
