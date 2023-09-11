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
    public partial class client : Form
    {
        store st = new store();
        public client()
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void client_Load(object sender, EventArgs e)
        {

            string h = "select * From clients";

            dataGridView2.DataSource = st.viwe(h);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_client add = new add_client();
            st.show(add);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_client s = new search_client();
            st.show(s);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string h = "select * From clients";

            dataGridView2.DataSource = st.viwe(h);
        }
    }
}
