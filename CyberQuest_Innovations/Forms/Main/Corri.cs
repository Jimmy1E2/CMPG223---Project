using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberQuest_Innovations.Forms
{
    public partial class Corri : Form
    {
        public Corri()
        {
            InitializeComponent();
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            tbCor_Description.Text = "Insert Corridor Description here !!";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Forms.Add_Room().Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            new Forms.Remove_Room().Show();
        }
    }
}
