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
    public partial class catogree : Form
    {
        Form1 v = new Form1();
        store st = new store();
        public catogree()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            st.mian(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st.close1(this);
        }

        private void catogree_Load(object sender, EventArgs e)
        {

            string s = "select * From catogree";

            dataGridView2.DataSource = st.viwe(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addcategories add = new Addcategories();
            st.show(add);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_catogree search = new search_catogree();
            st.show(search);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updatacateg up = new updatacateg();
            st.show(up);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = "select * From catogree";

            dataGridView2.DataSource = st.viwe(s);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            report rept = new report();
           rept.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}