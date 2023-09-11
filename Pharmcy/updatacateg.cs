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
    public partial class updatacateg : Form
    {  store st = new store();
        public updatacateg()
        {
            
            InitializeComponent();
        }

        private void updatacateg_Load(object sender, EventArgs e)
        {
            string a = "select * from catogree";

            st.viwe2(a, comboBox1);
            comboBox1.DisplayMember = "trade_name";
            comboBox1.ValueMember = "id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            try
            {

                comboBox1.ValueMember = "id";
                string b = "select * from catogree where trade_name ='" + comboBox1.SelectedValue + "' ";
                dataGridView1.Visible = true;
                dataGridView1.DataSource = st.view1(b);
                // dataGridView1.Visible = true;t
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = "updata catogree set sci_name='" + dataGridView1.CurrentRow.Cells[1].Value + "',trade_name='" + dataGridView1.CurrentRow.Cells[2].Value + "',type='" + dataGridView1.CurrentRow.Cells[3].Value + "',Company='" + dataGridView1.CurrentRow.Cells[4].Value + "',quantity='" + dataGridView1.CurrentRow.Cells[5].Value + "',expiration_data='" + dataGridView1.CurrentRow.Cells[6].Value + "',price='" + dataGridView1.CurrentRow.Cells[7].Value + "'";
            st.updata(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string b = "Delete  from catogree where id=" + dataGridView1.CurrentRow.Cells[0].Value + "";
            st.delete(b);
            st.close(this);
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            st.close(this);
        }
    }
}
