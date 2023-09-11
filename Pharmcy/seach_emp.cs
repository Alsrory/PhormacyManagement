using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmcy
{
    public partial class seach_emp : Form
    {
        store st = new store();
        public seach_emp()
        {
            InitializeComponent();
        }

        private void seach_emp_Load(object sender, EventArgs e)
        {

            string a = "select * from empolyee";

            st.viwe2(a, comboBox1);
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                comboBox1.ValueMember = "id";
                string a = "select * from empolyee where name ='" + comboBox1.Text + "' ";
                dataGridView1.Visible = true;
                dataGridView1.DataSource = st.v(a);
                // dataGridView1.Visible = true;t
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
