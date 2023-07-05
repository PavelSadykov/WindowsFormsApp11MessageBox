using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp11MessageBox
{
    public partial class Form1 : Form
    {
        MessageBoxButtons _buttons;
        MessageBoxIcon icon;
        Color[] _colors = { Color.White, Color.IndianRed, Color.LightGreen, Color.LightBlue };
        Random random = new Random();
        int i = 1;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.OrangeRed;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.GreenYellow;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void SelectedButtons(string item)
        {
            switch (item)
            {
                case "AbortRetryIgnore": _buttons = MessageBoxButtons.AbortRetryIgnore; break;
                case "OK": _buttons = MessageBoxButtons.OK; break;
                case "OKCancel": _buttons = MessageBoxButtons.OKCancel; break;
                case "RetryCancel": _buttons = MessageBoxButtons.RetryCancel; break;
                case "YesNo": _buttons = MessageBoxButtons.YesNo; break;
                case "YesNoCancel": _buttons = MessageBoxButtons.YesNoCancel; break;
                default: _buttons = MessageBoxButtons.OK; break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedButtons(comboBox1.SelectedItem.ToString());
        }
        private void SelectedIcon(string item)
        {
            switch (item)
            {
                case "предупреждение": icon = MessageBoxIcon.Warning; break;
                case "стоп": icon = MessageBoxIcon.Stop; break;
                case "запрос": icon = MessageBoxIcon.Question; break;
                case "информация": icon = MessageBoxIcon.Information; break;
                default: icon = MessageBoxIcon.None; break;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIcon(listBox1.SelectedItem.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text, "Message Box", _buttons, icon);

            
           
        }
        private void chb_rgb_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_rgb.Checked)
            {
                timer1.Start();

            }
            else
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == _colors.Length)
                i = 0;
            this.BackColor = _colors[i++];
        }


    }
}
