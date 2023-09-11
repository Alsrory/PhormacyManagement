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
    public partial class search_client : Form
    {
        store st = new store();
        public search_client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                comboBox1.ValueMember = "id";
                string a = "select * from clients where name ='" + comboBox1.Text + "' ";
                dataGridView1.Visible = true;
                dataGridView1.DataSource = st.v(a);
                // dataGridView1.Visible = true;t
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void search_client_Load(object sender, EventArgs e)
        {
            
            string a = "select * from clients";
            
           st.viwe2(a,comboBox1);
           comboBox1.DisplayMember = "name";
           comboBox1.ValueMember = "id";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    comboBox1.ValueMember = "id";
            //    string a = "select * from clients where name ='" + comboBox1.Text + "' ";
            //    //  listView1.Items.Clear();
            //    st.viwe3(a, listView1);
            //    listView1.Visible = true;
            //}

            ////   // dataGridView1.DataSourc}e = st.viwe(a);
            ////   // dataGridView1.Visible = true;
            ////}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message);
            //}
        }

            //dataGridView1.DataSource = st.viwe3(a, comboBox1);
            
             
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            st.close(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = "Delete  from clients where id=" + dataGridView1.CurrentRow.Cells[0].Value + "";
            st.delete(a);
        }
    }
}
