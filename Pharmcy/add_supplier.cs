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
    public partial class add_supplier : Form
    {
        store st = new store();
        public add_supplier()
        {
            InitializeComponent();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            string add = "insert into supplier (id,supp_name,company,address,phone_num) values ('"+ t_id.Text + "','" + t_name.Text + "','" + t_com.Text + "','" + t_address.Text + "', '" + t_phone.Text + "')";
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
        }

        private void add_supplier_Load(object sender, EventArgs e)
        {
            string a = "select id from supplier";
            DataTable dt = st.viwe(a);
            int y = dt.Rows.Count;
            t_id.Text = Convert.ToString(y + 1);
        }
    }
}
