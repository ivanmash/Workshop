using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кнопка_Нажми_меня
{
    public partial class Form1 : Form
    {
        private int i;
        public Form1()
        {
            InitializeComponent();
            i = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            i++;
            if(i < 2)
            {
                button1.Text = "Вы нажа-а-а-а-ли меня!!!!";
            }
            else
            Close();
        }
    }
}
