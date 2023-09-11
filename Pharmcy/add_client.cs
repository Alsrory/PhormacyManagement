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
    public partial class add_client : Form
    {
        store st = new store();
        public add_client()
        {
            InitializeComponent();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            string add = "insert into clients (id,name,address,phone_nu,accounet) values ('" + t_id.Text + "','" + t_name.Text + "','" + t_address.Text + "', '" + t_phone.Text + "','" + t_acc.Text + "')";
            st.insert(add);
            st.clear(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            st.close(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            st.clear(this);

            string a = "select id from clients";
            DataTable dt = st.viwe(a);
            int y = dt.Rows.Count;
            t_id.Text = Convert.ToString(y + 1);
            
        }

        private void add_client_Load(object sender, EventArgs e)
        {
            string a = "select id from clients";
            DataTable dt = st.viwe(a);
            int y = dt.Rows.Count;
            t_id.Text = Convert.ToString(y + 1);
        }

        private void t_phone_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if ((e.KeyChar < '0' || e.KeyChar < '9'))
            //    e.Handled = true;
            if ((e.KeyChar < '0' | e.KeyChar > '9'| e.KeyChar=='a'))
                e.Handled = true;





        }

        private void t_acc_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_acc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9'))
               e.Handled = true;
        }

        private void t_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_name_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
