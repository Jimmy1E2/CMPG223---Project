using CyberQuest_Innovations.Forms.Student;
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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Add_Student().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new Update_Student().Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            new Remove_Student().Show();
        }
    }
}
