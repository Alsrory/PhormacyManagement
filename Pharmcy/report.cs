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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Catogree' table. You can move, or remove it, as needed.
            this.CatogreeTableAdapter.Fill(this.pharmacyDataSet.Catogree);

            this.reportViewer1.RefreshReport();
        }
    }
}
