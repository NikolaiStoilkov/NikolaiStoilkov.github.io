using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace InterfaceInfoSelect
{
    public partial class New_Form0 : Form
    {
        public string pathJson = @"D:\InterfaceInfoSelect\InterfaceInfoSelect\InterfaceInfoSelect\models.json";
        public string pathTxt = @"D:\InterfaceInfoSelect\InterfaceInfoSelect\InterfaceInfoSelect\models.txt";
        public New_Form0()
        {
            InitializeComponent();
        }

        private void New_Form0_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            List<string> modelsTxt = new List<string>();

            foreach (var item in File.ReadAllLines(pathTxt))
            {
                modelsTxt.Add(item);
            }

            string newLine = Environment.NewLine;
            richTextBox1.Text = string.Join(newLine, modelsTxt);
           
        }

        private void Picture_By_ID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon!");
        }
    }
}
