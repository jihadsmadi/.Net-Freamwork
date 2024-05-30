using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;

namespace ContactsDataAccessLayer
{
    public class clsContactDataAccess
    {
        public static bool GetContactInfoByID(int ID, ref  string FirstName, ref string LastName,
            ref string Email , ref string Phone, ref string Address ,
            ref DateTime DateOfBirth, ref int CountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Contacts WHERE ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ContactID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                  
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CountryID = (int)reader["CountryID"];

                    //Image Path: Allow null at database so we should handel it
                    if (reader["ImagePath"] != DBNull.Value)
                    {
						ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
               

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            { 
                connection.Close(); 
            }

            return isFound;
        }

       public static int AddNewContact(string FirstName, string LastName,
			string Email, string Phone, string Address,
			 DateTime DateOfBirth,  int CountryID,  string ImagePath)
        {


			SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "INSERT INTO Contacts(FirstName,LastName,Email,Phone,Address,DateOfBirth,CountryID,ImagePath)" +
							  " values(@FirstName,@LastName,@Email,@Phone,@Address,@DateOfBirth,@CountryID,@ImagePath);" +
							  "select SCOPE_IDENTITY();";

			SqlCommand command = new SqlCommand(query, sqlConnection);

			command.Parameters.AddWithValue("@FirstName", FirstName);
			command.Parameters.AddWithValue("@LastName", LastName);
			command.Parameters.AddWithValue("@Email", Email);
			command.Parameters.AddWithValue("@Phone", Phone);
			command.Parameters.AddWithValue("@Address", Address);
			command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
			command.Parameters.AddWithValue("@CountryID", CountryID);

            if(ImagePath == "")
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }
            else
            {
				command.Parameters.AddWithValue("@ImagePath", ImagePath);
			}

			int ContactID =-1;

			try
			{
				sqlConnection.Open();

				object result = command.ExecuteScalar();

				if (result != null && int.TryParse(result.ToString(), out int InsintionId ))
				{
                    ContactID = InsintionId;
					
				}
				else
				{
                    ContactID = -1;
				}


			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
            finally { sqlConnection.Close(); }
            return ContactID ;
        }


        public static bool UpdateContact(int ID,string FirstName, string LastName,
			string Email, string Phone, string Address,
			 DateTime DateOfBirth, int CountryID, string ImagePath)
        {


            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string qurey = "UPDATE [dbo].[Contacts]" +
                "SET [FirstName] = @FirstName," +
                "[LastName] = @LastName" +
                ",[Email] = @Email," +
                "[Phone] = @Phone," +
                "[Address] = @Address," +
                "[DateOfBirth] = @DateOfBirth," +
                "[CountryID] = @CountryID," +
                "[ImagePath] = @ImagePath" +
                " WHERE ContactID = @ID";


            SqlCommand command = new SqlCommand(qurey, sqlConnection);


			command.Parameters.AddWithValue("@FirstName", FirstName);
			command.Parameters.AddWithValue("@LastName", LastName);
			command.Parameters.AddWithValue("@Email", Email);
			command.Parameters.AddWithValue("@Phone", Phone);
			command.Parameters.AddWithValue("@Address", Address);
			command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
			command.Parameters.AddWithValue("@CountryID", CountryID);

			if (ImagePath == "")
			{
				command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
			}
			else
			{
				command.Parameters.AddWithValue("@ImagePath", ImagePath);
			}

            command.Parameters.AddWithValue("@ID", ID);

            int RowsEfficted = 0;


            try
            {
                sqlConnection.Open();

                RowsEfficted = command.ExecuteNonQuery();

               
            }
            catch (Exception)
            {

                return false;

            } finally { sqlConnection.Close(); }


            return (RowsEfficted > 0);
		}


        public static bool DeleteContact(int ID)
        {
			SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string qurey = "delete from Countries where CountryID = @ID;";


			SqlCommand command = new SqlCommand(qurey, sqlConnection);

            command.Parameters.AddWithValue("@ID", ID);

            int rowsEfficted = 0;

            try
            {
                sqlConnection.Open();

                rowsEfficted =  command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }finally { sqlConnection.Close(); }

            return (rowsEfficted > 0);
		}

        public static DataTable ContactList()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Contacts";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

            }
            catch (Exception)
            {
                return null;
            }finally { sqlConnection.Close(); }

            return dt;
        }

        public static bool IsContactExist(int ID)
        {
            bool isFound = false;

            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString) ;

            string query = "Select Found = 1 from Contacts Where ContactID = @ID";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                sqlConnection.Open();
                
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    isFound = true;
                }
                else
                {
                    isFound = false;
                }
            }
            catch (Exception)
            {
                isFound = false;
            }

            return isFound; 
        }
        

	}
}
