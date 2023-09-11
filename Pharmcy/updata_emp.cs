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
    public partial class updata_emp : Form
    {
        store st = new store();
        public updata_emp()
        {
            InitializeComponent();
        }

        private void updata_emp_Load(object sender, EventArgs e)
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
                string b = "select * from empolyee where name ='" + comboBox1.SelectedValue + "' ";
                dataGridView1.Visible = true;
                dataGridView1.DataSource = st.view1(b);
                // dataGridView1.Visible = true;t
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = "Delete  from empolyee where id=" + dataGridView1.CurrentRow.Cells[0].Value + "";
            st.delete(a);
            st.close(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            st.close(this);
        }
    }
}
