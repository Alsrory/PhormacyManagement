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
    public partial class add_emplyee : Form
    {
        store st = new store();
         
        public add_emplyee()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                panel1.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                panel1.Visible = true;
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            //int x = Convert.ToInt32(t_id.Text);
            string add = "insert into empolyee (id,name,address,N_phone) values ('" + t_id.Text + "','" + t_name.Text + "','" + t_address.Text + "', '" + t_phone.Text + "')";
            st.insert(add);
            st.clear(this);
            st.close(this);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            st.clear(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            st.close(this);
        }

        private void add_emplyee_Load(object sender, EventArgs e)
        {
            string a = "select id from empolyee";
            DataTable dt = st.viwe(a);
            int y = dt.Rows.Count;
            t_id.Text = Convert.ToString(y +1);
           
        }
    }
}
