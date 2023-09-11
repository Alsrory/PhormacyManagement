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
    public partial class search_catogree : Form
    {
        store st = new store();
        public search_catogree()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void search_catogree_Load(object sender, EventArgs e)
        {
            string a = "select * from catogree";

            st.viwe2(a, comboBox1);
            comboBox1.DisplayMember = "trade_name";
            comboBox1.ValueMember = "id";

             //dataGridView1.DataSource = st.viwe(a);
            //

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            try
            {
                
                comboBox1.ValueMember = "id";
                string a = "select * from catogree where trade_name ='" + comboBox1.Text + "' ";
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
            string a="Delete  from catogree where id="+dataGridView1.CurrentRow.Cells[0].Value+"";
            st.delete(a);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            st.close(this);
        }
    }
}
