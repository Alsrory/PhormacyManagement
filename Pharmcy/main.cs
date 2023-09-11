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
    
    public partial class main : Form
    {store st=new store();
        public main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();

            st.close1(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            emplyees emp = new emplyees();
            st.show2(emp, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            catogree cat = new catogree();
            st.show2(cat, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client cli = new client();
            st.show2(cli, this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            supplier sup = new supplier();
            st.show2(sup, this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            salesandpro sal = new salesandpro();
            st.show2(sal,this);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
