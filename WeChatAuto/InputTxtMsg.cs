using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeChatAuto
{
    public partial class InputTxtMsg : Form
    {
        public InputTxtMsg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.richTextBox1.Text))
            {
                MessageBox.Show("请输入信息");
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
