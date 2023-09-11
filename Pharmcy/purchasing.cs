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
    public partial class purchasing : Form
    {
        store st = new store();
        public purchasing()
        {
            InitializeComponent();
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

        private void purchasing_Load(object sender, EventArgs e)
        {

            string a = "select * from supplier";

            st.viwe2(a, comboBox1);
            comboBox1.DisplayMember = "company";
            comboBox1.ValueMember = "id";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            st.close1(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            st.clear(this);
        }
    }
}
