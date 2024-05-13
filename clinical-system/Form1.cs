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
    public partial class Calendar: Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAppointment add = new AddAppointment(this);
            add.Show();
            this.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Today_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Finance f = new Finance(this);
            f.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            patient_record add = new patient_record(this);
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminSettings add = new AdminSettings(this);
            add.Show();
            this.Hide();
        }
    }
}
