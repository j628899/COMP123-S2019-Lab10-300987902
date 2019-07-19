using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_300987902
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           // Application.Run(new StartForm());
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Hide();
            Program.endForm.Show();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
