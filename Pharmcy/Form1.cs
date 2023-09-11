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
    public partial class Form1 : Form
    {
        //Form1 f1 = new Form1();
        store st = new store();
        public Form1()
        {
            InitializeComponent();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = textuser.Text;
                int pass = Convert.ToInt32(textpass.Text);
                if (st.user(user, pass))
                {
                    st.mian_inter(this);
                }
                else
                    MessageBox.Show("كلمة السر غير صحيحة يرجى ادخال كلمة سر صحيحة");
                //Form1 f = new Form1();
                //f.Show();
                // this.Hide();}
            }
            catch (Exception ee) {
                MessageBox.Show("كلمة السر غير صحيحة يرجى ادخال كلمة سر صحيحة"+ee.Message);
            
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            st.close(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
