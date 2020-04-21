using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginpage
{
    public partial class REGForm : Form
    {
        public REGForm()
        {
            InitializeComponent();
        }

        private void REGForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }
        private void textBoxfn_Enter(object sender, EventArgs e)
        {
            String fn = textBoxfn.Text;
            if (fn.Equals("First Name"))
            {
                textBoxfn.Text = "";
                textBoxfn.ForeColor = Color.Black;
            }
        }

        private void textBoxfn_Leave(object sender, EventArgs e)
        {
            String fn = textBoxfn.Text;
            if (fn.Equals("First Name"))
            {
                textBoxfn.Text = "First Name";
                textBoxfn.ForeColor = Color.Gray;
            }
        }

        private void textBoxln_Enter(object sender, EventArgs e)
        {

            String ln = textBoxln.Text;
            if (ln.Equals("Last Name"))
            {
                textBoxln.Text = "";
                textBoxln.ForeColor = Color.Black;
            }
        }

        private void textBoxln_Leave(object sender, EventArgs e)
        {

            String ln = textBoxln.Text;
            if (ln.Equals("Last Name"))
            {
                textBoxln.Text = "Last Name";
                textBoxln.ForeColor = Color.Gray;
            }
        }

        private void textBoxemadd_Enter(object sender, EventArgs e)
        {

            String ema = textBoxemadd.Text;
            if (ema.Equals("Email Address"))
            {
                textBoxemadd.Text = "";
                textBoxemadd.ForeColor = Color.Black;
            }
        }

        private void textBoxemadd_Leave(object sender, EventArgs e)
        {

            String ema = textBoxemadd.Text;
            if (ema.Equals("Email Address"))
            {
                textBoxemadd.Text = "Email Address";
                textBoxemadd.ForeColor = Color.Gray;
            }
        }

        private void textBoxurn_Enter(object sender, EventArgs e)
        {

            String usr = textBoxurn.Text;
            if (usr.Equals("Username"))
            {
                textBoxurn.Text = "";
                textBoxurn.ForeColor = Color.Black;
            }
        }

        private void textBoxurn_Leave(object sender, EventArgs e)
        {

            String usr = textBoxurn.Text;
            if (usr.Equals("Username"))
            {
                textBoxurn.Text = "Username";
                textBoxurn.ForeColor = Color.Gray;
            }
        }

        private void textBoxpass_Enter(object sender, EventArgs e)
        {
            String pw = textBoxpass.Text;
            if (pw.Equals("Password"))
            {
                textBoxpass.Text = "";
                textBoxpass.UseSystemPasswordChar = true;
                textBoxpass.ForeColor = Color.Black;
            }
        }

        private void textBoxpass_Leave(object sender, EventArgs e)
        {

            String pw = textBoxpass.Text;
            if (pw.Equals("Password"))
            {
                textBoxpass.Text = "Password";
                textBoxpass.UseSystemPasswordChar = false;
                textBoxpass.ForeColor = Color.Gray;
            }
        }

        private void textBoxcmp_Enter(object sender, EventArgs e)
        {
            String cpw = textBoxcmp.Text;
            if (cpw.Equals("Confirm Password"))
            {
                textBoxcmp.Text = "";
                textBoxcmp.UseSystemPasswordChar = true;
                textBoxcmp.ForeColor = Color.Black;
            }
        }

        private void textBoxcmp_Leave(object sender, EventArgs e)
        {

            String cpw = textBoxcmp.Text;
            if (cpw.Equals("Confirm Password"))
            {
                textBoxcmp.Text = "Confirm Password";
                textBoxcmp.UseSystemPasswordChar = false;
                textBoxcmp.ForeColor = Color.Gray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // this.Close();
            Application.Exit();
        }


        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`fname`, `lname`, `email`, `username`, `password`) VALUES (@fn, @ln, @ema, @usr, @pw)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxfn.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxln.Text;
            command.Parameters.Add("@ema", MySqlDbType.VarChar).Value = textBoxemadd.Text;
            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = textBoxurn.Text;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = textBoxpass.Text;

            db.openConnection();
            if(checkUsername())
            {
                MessageBox.Show("Already in");
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
           

            db.closedConnection();

        }

        private void gh(object sender, EventArgs e)
        {

        }
        public Boolean checkUsername()
        {

            DB db = new DB();
            String username = textBoxuname.Text;
            

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
           

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
