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
    public partial class emplyees : Form
    {
        store st = new store();
        public emplyees()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            st.close1(this);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            st.mian(this); 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emplyees_Load(object sender, EventArgs e)
        {
            string s = "select * From empolyee";
            
            dataGridView1.DataSource =st.viwe(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            add_emplyee add = new add_emplyee();
            st.show(add);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            string s = "select * From empolyee";

            dataGridView1.DataSource = st.viwe(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seach_emp search = new seach_emp();
            st.show(search);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updata_emp up = new updata_emp();
            st.show(up);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            updata_emp up = new updata_emp();
            st.show(up);
        }
    }
}
