using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class MDIParent1 : Form
    {


        public MDIParent1(String role)
        {
            InitializeComponent();
            label1.Text = role;
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MainWindow ss = new MainWindow();
           
            ss.MdiParent = this;
            ss.Show();
           
        }
    }
}
