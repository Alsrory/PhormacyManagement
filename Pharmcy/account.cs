using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pharmcy
{
    public partial class accouent : Form
    {
        store st = new store();
        public accouent()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void accouent_Load(object sender, EventArgs e)
        {
            try
            {
                //string a = "select supp_name from supplier";
                // string [] nmae=new string[100];

                string a = "select * from supplier";

                st.viwe2(a, comboBox1);
                comboBox1.DisplayMember = "supp_name";
                comboBox1.ValueMember = "id";
               // DataTable h = st.viwe(a);
              // string b = h.ToString();
                //string[] v = new string[100]
              // comboBox1.Items.Add(h.Site);
                //for(int i=0;i<5;i++){

                
            }
            catch (OleDbException ee)
            {
                MessageBox.Show("هناك خطا!!!" + ee.Message);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a = "select * from supplier";
            dataGridView1.Visible = true;
            dataGridView1.DataSource = st.viwe(a);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            st.close(this);
        }
    }
}
