using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
namespace Pharmcy
{
    class store
    {
         

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pharmacy.accdb");
        OleDbDataAdapter Dat;
        DataTable Dt = new DataTable();
        DataTable dt2 = new DataTable();
        OleDbCommand cmd;
        OleDbDataReader reader;
        string desDir;

     public  Boolean user(string u, int p) {
            string user = "wajdi";
            int pass = 1234;
            if (user == u && pass == p)
            {
                return true;
            }
            else
                return false;

        }
        public DataTable viwe(string a)
        {
            Dt.Clear();
            Dat = new OleDbDataAdapter(a, con);
            Dat.Fill(Dt);
            return Dt;
        }
        public DataTable view1(string a)
        {
            //Dt.Clear();
            Dat = new OleDbDataAdapter(a, con);
            Dat.Fill(Dt);
            return Dt;
        }
        public DataTable v(string a)
        {
            dt2.Clear();
            Dat = new OleDbDataAdapter(a, con);
            Dat.Fill(dt2);
            return dt2;
        }

        public void viwe2(string a, ComboBox t) {
            Dat = new OleDbDataAdapter(a, con);
            Dat.Fill(Dt);
          t.DataSource = Dt;
           // t .DisplayMember = "name";
            //t.ValueMember = "id";
        }
        
        //    t.DataSource = Dt;
        //    t.DisplayMember = "name";
        //    t.ValueMember = "id";
        //    return Dt.Select("id="  t.SelectedValue);
        
                //Dat = new OleDbDataAdapter(a, con);
                //Dat.Fill(Dt);
                //for(int i=0;i<Dt.Rows.Count;i++)
                //{
                //    DataRow dr = Dt.Rows[i];
                //    ListViewItem item = new ListViewItem(dr["id"].ToString());
                //    item.SubItems.Add(("name"));
                //    item.SubItems.Add(("address"));
                //    item.SubItems.Add(("phone_nu"));
                //    item.SubItems.Add(("accounet"));
                //    t.Items.Add(item);
        
        //}
        public void insert( string a) {
            try
            {
                cmd = new OleDbCommand(a, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت الاضافة بنجاح");
            }
            catch (OleDbException e)
            {
                MessageBox.Show("هناك خطا ما!!!"+e.Message);
            }
            finally
            {
                con.Close();
            
            }
        
        
        
        }
       
        public void delete(string a){
            try
            {
                cmd = new OleDbCommand(a, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت الحذف بنجاح");
            }
            catch (OleDbException e)
            {
                MessageBox.Show("هناك خطا ما!!!" + e.Message);
            }
            finally
            {
                con.Close();

            }
        
        }
        public void updata(string a)
        {
            try
            {
                cmd = new OleDbCommand(a, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" تم تعديل البيانات بنجاح");
            }
            catch (OleDbException e)
            {
                MessageBox.Show("هناك خطا ما!!!" + e.Message);
            }
            finally
            {
                con.Close();

            }

        }

        public void mian_inter( Form k )
        {
            main f = new main();
            f.Show();
            k.Hide();
        }
        public void mian(Form k)
        {
            main f = new main();
            f.Show();
            k.Close();
        }


        public void close(Form f)
        {
            f.Close();


        }
        public void close1(Form b )
        {
            b.Close();
            Application.Exit();

        }
        public void clear(Form f)
        {
            try
            {
                TextBox t;
                ComboBox cm;
                foreach (Control h in f.Controls)
                {
                    if (h.GetType() == typeof(TextBox) || h.GetType() == typeof(ComboBox))
                    {
                        t = (TextBox)h;
                        t.Clear();

                    }

                }
            }catch(Exception){
            }





        }
      
        public void show(Form f)
        {
            f.Show();
        }
        public void show2(Form h, Form f)
        {
            h.Show();
            f.Close();
        }

    }
}
