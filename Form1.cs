using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_1._2
{
    public partial class Form1 : Form
    {
        int count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void File_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void File_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void message_Click(object sender, EventArgs e)
        {
            string mes = "message";
            MessageBox.Show(mes);
        }

        private void text_Click(object sender, EventArgs e)
        {
            if (count % 2 == 1)
            {
                check.Checked = true;
                count++;
            }

            else if (count % 2 == 0)
            {
                check.Checked = false;
                count++;
            }

            if (check.Checked)
            {
                message.Enabled = false;
            }

            else
            {
                message.Enabled = true;
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            string abt = "Hello, Lina. The current version of this program: 1.0.0 ";
            MessageBox.Show(abt);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void format_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.T)
            {
                string t = "Check";
                MessageBox.Show(t);
            }
            if (keyData == Keys.A)
            {
                format.Show();
            }
            return true;
        }
    }
}
