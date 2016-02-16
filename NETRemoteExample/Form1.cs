using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETRemoteExample
{
    public partial class Form1 : Form
    {
        private Button[,] buttons;

        public Form1()
        { 
            InitializeComponent();
            buttons = new Button[9, 9];
            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Text = "B" + i + j;
                    this.tableLayoutPanel1.Controls.Add(buttons[i, j]);
                }
            }
        }
    }
}
