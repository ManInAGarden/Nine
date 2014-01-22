using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nine
{
    public partial class FormEnterWord : Form
    {
        public FormEnterWord()
        {
            InitializeComponent();
        }

        private void cancelBU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public char[] TheWord
        {
            get
            {
                char[] answ = new char[9];

                answ[0] = gwTB0.Text[0];
                answ[1] = gwTB1.Text[0];
                answ[2] = gwTB2.Text[0];
                answ[3] = gwTB3.Text[0];
                answ[4] = gwTB4.Text[0];
                answ[5] = gwTB5.Text[0];
                answ[6] = gwTB6.Text[0];
                answ[7] = gwTB7.Text[0];
                answ[8] = gwTB8.Text[0];

                return answ;
            }
        }
    }
}
