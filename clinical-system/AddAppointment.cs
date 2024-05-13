using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinical_system
{
    public partial class AddAppointment : Form
    {
        private Calendar f1;
        public AddAppointment(Calendar f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            f1.Visible = true;
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
