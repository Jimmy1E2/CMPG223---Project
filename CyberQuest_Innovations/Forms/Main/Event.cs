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
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            new Add_Event().Show();
        }

        private void tbSelected_TextChanged(object sender, EventArgs e)
        {

        }

        private void cal1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            new Update_Event().Show();
        }

        private void btnCRemove_Click(object sender, EventArgs e)
        {
            new Remove_Event().Show();
        }
    }
}
