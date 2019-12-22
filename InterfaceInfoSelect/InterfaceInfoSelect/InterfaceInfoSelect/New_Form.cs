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
    public partial class New_Form : Form
    {
        
        public string pathTxt = @"D:\InterfaceInfoSelect\InterfaceInfoSelect\InterfaceInfoSelect\models.txt";


        public New_Form()
        {
            InitializeComponent();
        }

        private void New_Form_Load(object sender, EventArgs e)
        {
            
        }

        private string MyDictionaryToJson(Dictionary<int, int> dict)
        {
            var entries = dict.Select(d =>
                string.Format("\"{0}\": [{1}]", d.Key, string.Join(",", d.Value)));
            return "{" + string.Join(",", entries) + "}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        public string ConvertToString()
        {
            string s = string.Empty;

            return s;
        }

        public void FileChecker()
        {
            foreach (var line in File.ReadAllLines(pathTxt))
            {
                char[] spliter = {'{', '\"',':', ' ', '[',']','}' };


                string[] str = line.Split(spliter, StringSplitOptions.RemoveEmptyEntries);

                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);

                _Collect.Add(a, b);

            }

            _counter++;
        }
        
        
        public Dictionary<int, int> _Collect = new Dictionary<int, int>();

        public void CheckMyDictionary(int id)
        {
            // count if some key are insde of the file twice!
            int counter = 0;


            //Foreach every line in Dictionary
            foreach (var key in _Collect.Keys)
            {

                //Check if key are true or same key are twice in the file.
                if (key == id)
                {
                    isHere = true;
                    insdeID = key;
                    counter++;


                    if (counter > 1)
                    {
                        _Collect.Remove(key);
                    }
                }
            }
        }

        public bool isHere = false;

        public int insdeID = 0;

        public int _counter = 0;

        

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(ID_Append.Text);
                int Amount = int.Parse(Amount_Append.Text);

                //Fill up the dict!
                if (_counter == 0)
                {
                    FileChecker();
                }
               

                //Check if exist!
                 CheckMyDictionary(ID);

                if (isHere)
                {
                    _Collect.Remove(insdeID);
                    _Collect.Add(ID, Amount);
                }
                else
                {
                    _Collect.Add(ID, Amount);
                }


                OverWriteTheFile();
               
                
               
                this.Close();
            }
            catch
            {

                MessageBox.Show("Please,Enter a value!");
            }
        }

        public void OverWriteTheFile()
        {
            string newLine = Environment.NewLine;
            foreach (var item in _Collect)
            {
                File.WriteAllText(pathTxt, MyDictionaryToJson(item.) + newLine);
            }
        }

        public void AppendObjectToFile()
        {
            File.AppendAllText(pathTxt, MyDictionaryToJson(_Collect));
        }
    }
}
