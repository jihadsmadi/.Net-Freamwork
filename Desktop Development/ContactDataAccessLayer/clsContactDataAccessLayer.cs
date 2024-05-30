using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContactDataAccessLayer
{
	public class clsContactDataAccessLayer
	{

		public static bool GetContactInfo(int Id, ref string FirstName, ref string LastName, ref string Email,
									ref string Phone, ref string Address, ref int CountryID,ref DateTime DateOfBirth,ref string ImagePath)
		{

			bool isFound = false;

			SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.connectionString);

			string query = "select * from Contacts where ContactID = @ContactID ";

			SqlCommand cmd = new SqlCommand(query, sqlConnection);

			cmd.Parameters.AddWithValue("ContactID", Id);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();



				if (reader.Read())
				{
					isFound = true;

					
					FirstName = (string)reader["FirstName"];
					LastName = (string)reader["LastName"];
					Address = (string)reader["Address"];
					Phone = (string)reader["Phone"];
					Email = (string)reader["Email"];
					CountryID = (int)reader["CountryID"];
					DateOfBirth = (DateTime)reader["DateOfBirth"];
					CountryID = (int)reader["CountryID"];
					ImagePath = (string)reader["ImagePath"];

				}
				else
				{
					isFound = false;
				}

				reader.Close();
				

			}
			catch (Exception ex)
			{

				isFound = false;
			}
			finally
			{ sqlConnection.Close(); }


			return isFound;

			


		}

	}
}
