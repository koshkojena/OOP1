using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Привязываем обработчик события изменения размера формы
            this.Resize += Form1_Resize;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Активируем все кнопки при изменении размера формы
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
        }
    }
}
