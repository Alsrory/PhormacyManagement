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
    public partial class Addcategories : Form
    {
        store st = new store();
        public Addcategories()
        {
            InitializeComponent();
        }

        private void ok1_Click(object sender, EventArgs e)
        {

            string add = "insert into catogree (sci_name,trade_name,type,Company,quantity,expiration_data,price) values ('" + t_scin.Text + "','" + t_tradn.Text + "','" + t_type.Text + "', '" + t_cop.Text + "','" + t_qunt.Text + "','" + t_data.Text + "','" + t_price.Text + "')";
            st.insert(add);
            st.clear(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st.clear(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            st.close(this);
        }
    }
}
