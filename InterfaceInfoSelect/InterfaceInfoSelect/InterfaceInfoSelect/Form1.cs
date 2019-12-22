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
    public partial class Form1 : Form
    {
        public string path = @"D:\InterfaceInfoSelect\InterfaceInfoSelect\InterfaceInfoSelect\models.json";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("          Developed by NStoilkov\r\n" +
                "                 Version 1.0.0\r\n" +
                "                 Contact me at\r\n" +
                "       nikolaistoilkov98@gmail.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        

        private void Create_Click(object sender, EventArgs e)
        {
            New_Form new_form = new New_Form();
            new_form.Show();

        }

        private void Read_Click(object sender, EventArgs e)
        {
            New_Form0 New_Form0 = new New_Form0();
            New_Form0.Show();
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

    
}
