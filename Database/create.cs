using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class create : Form
    {
        public create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=APPLE1C2A\\SQLEXPREES;Initial Catalog=db_906;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into users values(@id,@name,@age)", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxId.Text));
                cmd.Parameters.AddWithValue("@name", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@age", int.Parse(textBoxAge.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   finally
            {
                con.Close();
            }
            getDataFormDatabase();

        }

        private void getDataFormDatabase()
        {
            SqlConnection con = new SqlConnection("Data Source=APPLE1C2A\\SQLEXPREES;Initial Catalog=db_906;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM users ORDER BY id DESC", con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void create_Load(object sender, EventArgs e)
        {
            getDataFormDatabase();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=APPLE1C2A\\SQLEXPREES;Initial Catalog=db_906;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE users SET name =  @name, age = @age WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxId.Text));
                cmd.Parameters.AddWithValue("@name", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@age", int.Parse(textBoxAge.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully!");
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            getDataFormDatabase();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=APPLE1C2A\\SQLEXPREES;Initial Catalog=db_906;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE users WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxId.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            getDataFormDatabase();
        }

        private void ClearText()
        {
            textBoxId.Text = "";
            textBoxUsername.Text = "";
            textBoxAge.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Search by name
            SqlConnection con = new SqlConnection("Data Source=APPLE1C2A\\SQLEXPREES;Initial Catalog=db_906;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE name LIKE @name", con);
                cmd.Parameters.AddWithValue("@name", "%" + textBoxUsername.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                dataGridView1.DataSource = dt;
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
