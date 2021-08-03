using _3DMD_GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DMD_GUI
{
    public partial class Main : Form
    {
        bool white = false;
        bool dark = false;
        bool blue = false;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close the program?", "Closing Program",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openfile secondWindow = new Openfile();
            secondWindow.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options thirdWindow = new Options();
            thirdWindow.Show();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void darkThemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (white == true || blue == true)
            {
                white = false;
                blue = false;
            }
            this.BackColor = Color.FromArgb(34, 36, 49);
            dark = true;
        }

        private void whiteThemeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (blue == true || dark == true)
            {
                dark = false;
                blue = false;
            }
            this.BackColor = Color.White;
            white = true;
        }

        private void darkBlueThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (white == true || dark == true)
            {
                dark = false;
                white = false;
            }
            this.BackColor = Color.FromArgb(25, 25, 112);
            blue = true;
        }
    }
}
