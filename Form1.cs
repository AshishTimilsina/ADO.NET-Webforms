using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //Connection String
        String constr = @"Data Source =DESKTOP-HBL9VCS\SQLEXPRESS ;Initial Catalog = ADONETdb ; Integrated Security =SSPI";
        public Form1()
        {
            InitializeComponent();
            getdata();
        }

        //Using DataSet and DataAdapter
        private void getdata()
        {
            try
            {
                String getallEmp = "SELECT * FROM Employees";
                SqlDataAdapter da = new SqlDataAdapter(getallEmp, constr);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void selbtn_Click(object sender, EventArgs e)
        {
            //Connection String
            String constr = @"Data Source =DESKTOP-HBL9VCS\SQLEXPRESS ;Initial Catalog = ADONETdb ; Integrated Security =SSPI";
            //Connection
            SqlConnection con = new SqlConnection(constr);

            try
            {

                if (!String.IsNullOrEmpty(eidtxtbox.Text))
                {
                    string sqlquery = "SELECT * FROM [dbo].[Employees] WHERE Id=CAST(@ID as VARCHAR)";

                    //command
                    SqlCommand cmd = new SqlCommand(sqlquery, con);
                    cmd.Parameters.AddWithValue("@ID", eidtxtbox.Text);
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        fntxtbox.Text = reader.GetString(1);
                        lntxtbox.Text = reader.GetString(2);
                        gntxtbox.Text = reader.GetString(3);
                        ctytxtbox.Text = reader.GetString(4);
                        isatxtbox.Text = reader.GetString(5);

                    }
                }
                else
                {
                    MessageBox.Show("Employee ID cannot be blank");
                }

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

        private void addbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            try
            {
                /*Ok so instead of applying query in this way we can either use parameterized query i.e using parameter in sqlquery
                 As this is a effective method as it also protect from slq injection attacks.
                 */
                /* string addEmployee = @"INSERT INTO [dbo].[Employees]
                     VALUES('" + fntxtbox.Text + "','" + lntxtbox.Text + "','" + gntxtbox.Text + "','" + ctytxtbox.Text + "','" + isatxtbox.Text + "')";
                 SqlCommand cmd = new SqlCommand(addEmployee, con);*/

                String addEmployee = @"INSERT INTO [dbo].[Employees]
                    VALUES(@FirstName,@LastName,@Gender,@IsActive,@City)";
                SqlCommand cmd = new SqlCommand(addEmployee, con);
                cmd.Parameters.AddWithValue("@FirstName", fntxtbox.Text);
                cmd.Parameters.AddWithValue("@LastName", lntxtbox.Text);
                cmd.Parameters.AddWithValue("@Gender", gntxtbox.Text);
                cmd.Parameters.AddWithValue("@City", ctytxtbox.Text);
                cmd.Parameters.AddWithValue("@IsActive", isatxtbox.Text);

                con.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Record Inserted Successfully");
                    getdata();
                }
                else
                {
                    MessageBox.Show("Record Inserted Successfully");
                }

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            try
            {

                string updateEmpsql = @"UPDATE [dbo].[Employees]
                                    SET[FirstName]=@FirstName,
                                       [LastName]=@LastName,
                                       [Gender]=@Gender,
                                       [City]=@City,
                                       [IsActive]=@IsActive
                                       WHERE Id=@ID";

                SqlCommand cmd = new SqlCommand(updateEmpsql, con);
                cmd.Parameters.AddWithValue("@ID", eidtxtbox.Text);
                cmd.Parameters.AddWithValue("@FirstName", fntxtbox.Text);
                cmd.Parameters.AddWithValue("@LastName", lntxtbox.Text);
                cmd.Parameters.AddWithValue("@Gender", gntxtbox.Text);
                cmd.Parameters.AddWithValue("@City", ctytxtbox.Text);
                cmd.Parameters.AddWithValue("@IsActive", isatxtbox.Text);
                con.Open();

                int rowaffected = cmd.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Record Updatad Successsfully");
                    getdata();
                }
                else
                {
                    MessageBox.Show("Failed To Update Record");
                }
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

        private void delbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            try
            {

                string updateEmpsql = @"DELETE FROM [dbo].[Employees] WHERE Id=@ID";

                SqlCommand cmd = new SqlCommand(updateEmpsql, con);
                cmd.Parameters.AddWithValue("@ID", eidtxtbox.Text);
                con.Open();

                int rowaffected = cmd.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Record Deleted Successsfully");
                    getdata();
                }
                else
                {
                    MessageBox.Show("Failed To Delete Record");
                }
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
}
