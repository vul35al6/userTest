using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0613_ListBox {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            listBox.Items.Add("你好你好");
        }

        private void button2_Click(object sender, EventArgs e) {
            listBox.Items.Remove("你好你好");           
        }

        private void button3_Click(object sender, EventArgs e) {
            listBox.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e) {
            listBox.Items[2]= "謝謝您的惠顧";
        }

        private void button5_Click(object sender, EventArgs e) {
            button5.Text = ("OK");
        }

        private void button6_Click(object sender, EventArgs e) {
            MessageBox.Show("第一次實驗");
        }

        private void button7_Click(object sender, EventArgs e) {
            button7.Text = listBox.SelectedItem.ToString();
        }

        private void button8_Click(object sender, EventArgs e) {
            button8.Text = listBox.SelectedIndex.ToString();
        }

        private void button9_Click(object sender, EventArgs e) {
            int i = listBox.SelectedIndex;
            if (i < 0)
                button9.Text = ("沒選到喔!");
            else
                button9.Text = listBox.Items[i].ToString();

        }
    }
}
