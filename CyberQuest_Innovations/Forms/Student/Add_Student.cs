using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberQuest_Innovations.Forms
{
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStudentID.Clear();
            tbRoom_Number.Clear();
            tbEventID.Clear();
            tbField.Clear();
            tbName.Clear();
            tbLastName.Clear();
            tbCell.Clear();
            tbEmail.Clear();
        }
    }
}
