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
    public partial class supplier : Form
    {
        store st = new store();
        public supplier()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            st.mian(this);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            st.close1(this);
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            string s = "select * From supplier";

            dataGridView2.DataSource = st.viwe(s);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_supplier add = new add_supplier();
            st.show(add);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            accouent a = new accouent();

            st.show(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "select * From supplier";

            dataGridView2.DataSource = st.viwe(s);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
