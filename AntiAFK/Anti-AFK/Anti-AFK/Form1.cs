using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Hotkeys;
using WindowsInput;
using WindowsInput.Native;


namespace Anti_AFK
{
    public partial class Form1 : Form
    {
        private bool click = false;
        private GlobalHotkey globalHotkey;
        private InputSimulator inputSimulator;
        private InputSimulator key;
        private double hour = 0.0;
        private double minutes = 0.0;
        private int _ticks;

        public Form1()
        {
            InitializeComponent();
            button1.BackColor = System.Drawing.Color.Red;
            globalHotkey = new GlobalHotkey(Constants.SHIFT, Keys.Up, this);
            inputSimulator = new InputSimulator();
            key = new InputSimulator();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            key.Keyboard.KeyPress(VirtualKeyCode.SHIFT);
            key.Keyboard.KeyPress(VirtualKeyCode.UP);

            click = false;
            if (!click)
            {

                button1.BackColor = System.Drawing.Color.Red;
                button2.BackColor = System.Drawing.Color.Green;

                _ticks = 0;
                hour = 0;
                minutes = 0;
                timer1.Start();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            

            click = true;
            if (click)
            {
                button1.BackColor = System.Drawing.Color.Green;
                button2.BackColor = System.Drawing.Color.Red;
                timer1.Stop();
                _ticks = 0;
                this.label3.Text = "00:00:00";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = _ticks.ToString();

            //System.Threading.Thread.Sleep(1000);
            timer1.Interval = 1000;
            _ticks++;

            ConfigureIncreasement();

            MoveForwards();

            PrintIncreasementTime();
        }
        private void MoveForwards()
        {
            if (_ticks == 30 || _ticks == 59)
            {
                HandleHotKey();
            }
        }
        private void PrintIncreasementTime()
        {
            string hour = ShowHours();
            string minutes = ShowMinutes();
            string seconds = ShowSeconds();

            this.label3.Text = $"{hour}:{minutes}:{seconds}";
        }

        private VirtualKeyCode SpecificButton()
        {
            switch (comboBox1.Text)
            {
                case "A":
                    return VirtualKeyCode.VK_A;
                case "B":
                    return VirtualKeyCode.VK_B;
                case "C":
                    return VirtualKeyCode.VK_C;
                case "D":
                    return VirtualKeyCode.VK_D;
                case "E":
                    return VirtualKeyCode.VK_E;
                case "F":
                    return VirtualKeyCode.VK_F;
                case "G":
                    return VirtualKeyCode.VK_G;
                case "H":
                    return VirtualKeyCode.VK_H;
                case "I":
                    return VirtualKeyCode.VK_I;
                case "J":
                    return VirtualKeyCode.VK_J;
                case "K":
                    return VirtualKeyCode.VK_K;
                case "L":
                    return VirtualKeyCode.VK_L;
                case "M":
                    return VirtualKeyCode.VK_M;
                case "N":
                    return VirtualKeyCode.VK_N;
                case "O":
                    return VirtualKeyCode.VK_O;
                case "P":
                    return VirtualKeyCode.VK_P;
                case "Q":
                    return VirtualKeyCode.VK_Q;
                case "R":
                    return VirtualKeyCode.VK_R;
                case "S":
                    return VirtualKeyCode.VK_S;
                case "T":
                    return VirtualKeyCode.VK_T;
                case "U":
                    return VirtualKeyCode.VK_U;
                case "V":
                    return VirtualKeyCode.VK_V;
                case "W":
                    return VirtualKeyCode.VK_W;
                case "X":
                    return VirtualKeyCode.VK_X;
                case "Y":
                    return VirtualKeyCode.VK_Y;
                case "Z":
                    return VirtualKeyCode.VK_Z;
                case "0":
                    return VirtualKeyCode.VK_0;
                case "1":
                    return VirtualKeyCode.VK_1;
                case "2":
                    return VirtualKeyCode.VK_2;
                case "3":
                    return VirtualKeyCode.VK_3;
                case "4":
                    return VirtualKeyCode.VK_4;
                case "5":
                    return VirtualKeyCode.VK_5;
                case "6":
                    return VirtualKeyCode.VK_6;
                case "7":
                    return VirtualKeyCode.VK_7;
                case "8":
                    return VirtualKeyCode.VK_8;
                case "9":
                    return VirtualKeyCode.VK_9;
                default:
                    return VirtualKeyCode.SPACE;
            }

        }

        private void HandleHotKey() => inputSimulator.Keyboard.KeyPress(SpecificButton());

        
        #region Timer
        private string ShowHours()
        {
            if (hour == 0 && hour <= 9)
            {
                return this.label3.Text = $"0{hour}";
            }

            return this.label3.Text = $"{hour}";
        }
        private string ShowMinutes()
        {
            if (minutes == 0 || minutes <= 9)
            {
                return this.label3.Text = $"0{minutes}";
            }

            return this.label3.Text = $"{minutes}";
        }
        private string ShowSeconds()
        {
            if (_ticks == 0 || _ticks <= 9)
            {
                return this.label3.Text = $"0{_ticks}";
            }

            return this.label3.Text = $"{_ticks}";
        }
        #endregion
        private void ConfigureIncreasement()
        {
            if (_ticks == 60)
            {
                minutes++;
                _ticks = 0;
            }
            else if (minutes == 60)
            {
                hour++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is made by Nikolai Stoilkov.\r\n\r\n\r\n The program press automatically specific key while you are AFK.");

        }
        #region Empty Methods
        private void Form1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

       
    }
}
