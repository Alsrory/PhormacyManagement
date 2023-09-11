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
    public partial class sales : Form
    {
        store st = new store();
        public sales()
        {
            InitializeComponent();
        }

        private void t_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_price_MouseLeave(object sender, EventArgs e)
        {
            
            
                if (t_price.Text != "" && t_quan.Text != "")
                {
                    int x = Convert.ToInt32(t_quan.Text);
                    int y = Convert.ToInt32(t_price.Text);
                    double a = x * y;
                    t_total.Text = Convert.ToString(a);

                }
                else { t_total.Text = Convert.ToString(0); }
            
           
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            string add = "insert into sales (trade_name,quantity,price,total) values ('" + t_traden.Text + "','" + t_quan.Text + "','" + t_price.Text + "','" + t_total.Text + "')";
            st.insert(add);
            st.clear(this);
            string a = "select id from sales";
            DataTable dt = st.viwe(a);
            int y = dt.Rows.Count;
            dataGridView1.DataSource = dt.Rows[y];
           dataGridView1.Visible = true;
        }

        private void sales_Load(object sender, EventArgs e)
        {
            
            
            string B = "select * from clients";

            st.viwe2(B, comboBox1);
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

            string a = "select id from sales";
            DataTable dt = st.viwe(a);
            int y = dt.Rows.Count;
            te_id.Text = Convert.ToString(y + 1);
           
            

           

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            string a = "select trade_name from cotgree like % '" + textBox1.Text + "'";
            listBox1.DataSource = st.view1(a);
        }
    }
}
