using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;
using static ConsoleApp4.Program;
using System.Diagnostics.Contracts;

namespace ConsoleApp4
{
	internal class Program
	{
		static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=123456;";

		static void PrintContacts()
		{
			SqlConnection connection = new SqlConnection(connectionString);

			string query = "select * from Contacts";

			SqlCommand cmd = new SqlCommand(query, connection);

			try
			{
				connection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				int ContactId, CountryID;
				string Name, Email, Phone, Address;

				while (reader.Read())
				{
					ContactId = (int)reader["ContactID"];
					Name = (string)reader["FirstName"] + " " + (string)reader["LastName"];
					Email = (string)reader["Email"];
					Phone = (string)reader["Phone"];
					Address = (string)reader["Address"];
					CountryID = (int)reader["CountryID"];

					Console.WriteLine($"Contact ID = {ContactId}");
					Console.WriteLine($"Name       = {Name}");
					Console.WriteLine($"Email      = {Email}");
					Console.WriteLine($"Phone      = {Phone}");
					Console.WriteLine($"Address    = {Address}");
					Console.WriteLine($"Country ID = {CountryID}");
					Console.WriteLine("----------------------------");

				}
				reader.Close();
				connection.Close();


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}







		}
		static void PrintAllContactsWithFirsName(string firstName)
		{

			SqlConnection connection = new SqlConnection(connectionString);

			string query = "select * from Contacts where FirstName =@FirstName";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@FirstName", firstName);

			try
			{
				connection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				int ContactId, CountryID;
				string Name, Email, Phone, Address;

				while (reader.Read())
				{
					ContactId = (int)reader["ContactID"];
					Name = (string)reader["FirstName"] + " " + (string)reader["LastName"];
					Email = (string)reader["Email"];
					Phone = (string)reader["Phone"];
					Address = (string)reader["Address"];
					CountryID = (int)reader["CountryID"];

					Console.WriteLine($"Contact ID = {ContactId}");
					Console.WriteLine($"Name       = {Name}");
					Console.WriteLine($"Email      = {Email}");
					Console.WriteLine($"Phone      = {Phone}");
					Console.WriteLine($"Address    = {Address}");
					Console.WriteLine($"Country ID = {CountryID}");
					Console.WriteLine("----------------------------");

				}
				reader.Close();
				connection.Close();


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

		static void SearchContactsStartWith(string LettarForSearch)
		{

			SqlConnection connection = new SqlConnection(connectionString);

			string query = "select * from Contacts where FirstName Like '' + @LettarForSearch + '%' ";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@LettarForSearch", LettarForSearch);

			try
			{
				connection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				int ContactId, CountryID;
				string Name, Email, Phone, Address;

				while (reader.Read())
				{
					ContactId = (int)reader["ContactID"];
					Name = (string)reader["FirstName"] + " " + (string)reader["LastName"];
					Email = (string)reader["Email"];
					Phone = (string)reader["Phone"];
					Address = (string)reader["Address"];
					CountryID = (int)reader["CountryID"];

					Console.WriteLine($"Contact ID = {ContactId}");
					Console.WriteLine($"Name       = {Name}");
					Console.WriteLine($"Email      = {Email}");
					Console.WriteLine($"Phone      = {Phone}");
					Console.WriteLine($"Address    = {Address}");
					Console.WriteLine($"Country ID = {CountryID}");
					Console.WriteLine("----------------------------");

				}
				reader.Close();
				connection.Close();


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

		static void SearchContactsEndWith(string LettarForSearch)
		{

			SqlConnection connection = new SqlConnection(connectionString);

			string query = "select * from Contacts where FirstName Like '%' + @LettarForSearch  +'' ";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@LettarForSearch", LettarForSearch);

			try
			{
				connection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				int ContactId, CountryID;
				string Name, Email, Phone, Address;

				while (reader.Read())
				{
					ContactId = (int)reader["ContactID"];
					Name = (string)reader["FirstName"] + " " + (string)reader["LastName"];
					Email = (string)reader["Email"];
					Phone = (string)reader["Phone"];
					Address = (string)reader["Address"];
					CountryID = (int)reader["CountryID"];

					Console.WriteLine($"Contact ID = {ContactId}");
					Console.WriteLine($"Name       = {Name}");
					Console.WriteLine($"Email      = {Email}");
					Console.WriteLine($"Phone      = {Phone}");
					Console.WriteLine($"Address    = {Address}");
					Console.WriteLine($"Country ID = {CountryID}");
					Console.WriteLine("----------------------------");

				}
				reader.Close();
				connection.Close();


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

		static void SearchContactsContain(string LettarForSearch)
		{

			SqlConnection connection = new SqlConnection(connectionString);

			string query = "select * from Contacts where FirstName Like '%' + @LettarForSearch  +'%' ";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@LettarForSearch", LettarForSearch);

			try
			{
				connection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				int ContactId, CountryID;
				string Name, Email, Phone, Address;

				while (reader.Read())
				{
					ContactId = (int)reader["ContactID"];
					Name = (string)reader["FirstName"] + " " + (string)reader["LastName"];
					Email = (string)reader["Email"];
					Phone = (string)reader["Phone"];
					Address = (string)reader["Address"];
					CountryID = (int)reader["CountryID"];

					Console.WriteLine($"Contact ID = {ContactId}");
					Console.WriteLine($"Name       = {Name}");
					Console.WriteLine($"Email      = {Email}");
					Console.WriteLine($"Phone      = {Phone}");
					Console.WriteLine($"Address    = {Address}");
					Console.WriteLine($"Country ID = {CountryID}");
					Console.WriteLine("----------------------------");

				}
				reader.Close();
				connection.Close();


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

		static string GetFirstValue(int ContactID)
		{
			string firstValue = "";

			SqlConnection connection = new SqlConnection(connectionString);

			string query = "select FirstName from Contacts where ContactID = @ContactID ";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@ContactID", ContactID);

			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();

				if (value != null)
				{
					firstValue = value.ToString();
				}
				else
				{
					firstValue = "";
				}

				connection.Close();


			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return firstValue;
		}

		public struct stContactInfo
		{
			public int ContactID { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }

			public string Email { get; set; }
			public string Phone { get; set; }

			public string Address { get; set; }

			public int CountryID { get; set; }
		}

		static bool FindContactById(int ContactID,ref stContactInfo contactInfo)
		{
			bool isFound = false;

			SqlConnection sqlConnection= new SqlConnection(connectionString);

			string query = "select * from Contacts where ContactID = @ContactID ";

			SqlCommand cmd = new SqlCommand(query, sqlConnection);

			cmd.Parameters.AddWithValue("ContactID", ContactID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();



				if (reader.Read())
				{
					isFound = true;

					contactInfo.ContactID = (int)reader["ContactID"];
					contactInfo.FirstName = (string)reader["FirstName"];
					contactInfo.LastName = (string)reader["LastName"];
					contactInfo.Address = (string)reader["Address"];
					contactInfo.Phone = (string)reader["Phone"];
					contactInfo.Email = (string)reader["Email"];
					contactInfo.CountryID = (int)reader["CountryID"];

				}
				else
				{
					isFound = false;
				}

				reader.Close();
				sqlConnection.Close();

			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
			
			

			return isFound;
		}

		static void PrintContactInfo(stContactInfo ContactInfo)
		{
			Console.WriteLine($"\nContact ID = {ContactInfo.ContactID}");
			Console.WriteLine($"Name       = {ContactInfo.FirstName + " " + ContactInfo.LastName}");
			Console.WriteLine($"Email      = {ContactInfo.Email}");
			Console.WriteLine($"Phone      = {ContactInfo.Phone}");
			Console.WriteLine($"Address    = {ContactInfo.Address}");
			Console.WriteLine($"Country ID = {ContactInfo.CountryID}");
			Console.WriteLine("----------------------------");
		}

		static void AddOneContact(stContactInfo ContactInfo)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			string query = "INSERT INTO Contacts(FirstName,LastName,Email,Phone,Address,CountryID)" +
							  " values(@FirstName,@LastName,@Email,@Phone,@Address,@CountryID)";

			SqlCommand command = new SqlCommand(query, sqlConnection);

			command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
			command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
			command.Parameters.AddWithValue("@Email", ContactInfo.Email);
			command.Parameters.AddWithValue("@Phone", ContactInfo.Phone	);
			command.Parameters.AddWithValue("@Address", ContactInfo.Address);
			command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);

			try
			{
				sqlConnection.Open();

				int RowsEficter = command.ExecuteNonQuery();

				if(RowsEficter > 0 )
				{
					Console.WriteLine("Insert Contact Succesfully ..!");
				}
				else
				{
					Console.WriteLine("Insert Contact Faild ...! ");
				}

				sqlConnection.Close();

			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}

		}
		static void AddOneContactAndReturnID(stContactInfo ContactInfo)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			string query = "INSERT INTO [dbo].[Contacts]([FirstName],[LastName],[Email],[Phone],[Address],[CountryID])" +
						"VALUES(@FirstName,@LastName,@Email,@Phone,@Address,@CountryID);" +
							"select SCOPE_IDENTITY();";

			SqlCommand command = new SqlCommand(query, sqlConnection);

			command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
			command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
			command.Parameters.AddWithValue("@Email", ContactInfo.Email);
			command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
			command.Parameters.AddWithValue("@Address", ContactInfo.Address);
			command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);

			try
			{
				sqlConnection.Open();

				object value = command.ExecuteScalar();

				if (value != null)
				{
					Console.WriteLine("Insert Contact Succesfully ..!");
					Console.WriteLine($"ID is {value.ToString()}");
				}
				else
				{
					Console.WriteLine("Insert Contact Faild ...! ");
				}

				sqlConnection.Close();

			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}

		}

		static void UpdateContact(int ContactID,stContactInfo ContactInfo)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			string query = "UPDATE[dbo].[Contacts] " +
				"SET[FirstName] = @FirstName,[LastName] = @LastName ,[Email] = @Email,[Phone] = @Phone,[Address] = @Address ,[CountryID] = @CountryID " +
						"WHERE ContactID = @ContactID";

			SqlCommand command = new SqlCommand(query, sqlConnection);

			command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
			command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
			command.Parameters.AddWithValue("@Email", ContactInfo.Email);
			command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
			command.Parameters.AddWithValue("@Address", ContactInfo.Address);
			command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);
			command.Parameters.AddWithValue("@ContactID", ContactID);

			try
			{
				sqlConnection.Open();

				int RowEfficter = command.ExecuteNonQuery();

				if (RowEfficter > 0)
				{
					Console.WriteLine("Update Contact Succesfully ..!");
					
				}
				else
				{
					Console.WriteLine("Update Contact Faild ...! ");
				}

				sqlConnection.Close();

			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}

		}

		static void DeleteContact(int ContactID)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			string query = "delete Contacts where ContactID = @ContactID";

			SqlCommand command = new SqlCommand(query, sqlConnection);

			
			command.Parameters.AddWithValue("@ContactID", ContactID);

			try
			{
				sqlConnection.Open();

				int RowEfficter = command.ExecuteNonQuery();

				if (RowEfficter > 0)
				{
					Console.WriteLine("Delete Contact Successfully ..!");

				}
				else
				{
					Console.WriteLine("Delete Contact Faild ...! ");
				}

				sqlConnection.Close();

			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}

		}

		static void DeleteContactWithIn(string ContactIDs)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			string query = "delete Contacts where ContactID in ("+ContactIDs+")";

			SqlCommand command = new SqlCommand(query, sqlConnection);



			try
			{
				sqlConnection.Open();

				int RowEfficter = command.ExecuteNonQuery();

				if (RowEfficter > 0)
				{
					Console.WriteLine("Delete Contact Successfully ..!");

				}
				else
				{
					Console.WriteLine("Delete Contact Faild ...! ");
				}

				sqlConnection.Close();

			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}

		}


		static void Main(string[] args)
		{

			stContactInfo ContactInfo = new stContactInfo
			{
				FirstName = "Test2",
				LastName = "Smadi",
				Email = "ex@Gmail.com",
				Phone = "0937793120",
				Address = "Damascus",
				CountryID = 1
		
			};



			DataTable EmployeesDataTable = new DataTable();

			EmployeesDataTable.Columns.Add("ID", typeof(int));
			EmployeesDataTable.Columns.Add("Name", typeof(string));
			EmployeesDataTable.Columns.Add("Country", typeof(string));
			EmployeesDataTable.Columns.Add("Salary", typeof(Double));
			EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

			EmployeesDataTable.Rows.Add(1, "Mohammed Abu-Hadhoud", "Jordan", 5000, DateTime.Now);
			EmployeesDataTable.Rows.Add(2, "Ali Maher", "KSA", 525.5, DateTime.Now);
			EmployeesDataTable.Rows.Add(3, "Lina Kamal", "Jordan", 730.5, DateTime.Now);
			EmployeesDataTable.Rows.Add(4, "Fadi Jameel", "Egypt", 800, DateTime.Now);
			EmployeesDataTable.Rows.Add(5, "Omar Mahmoud", "Lebanon", 7000, DateTime.Now);

			int EmployeesCount = 0;
			double TotalSalaries = 0;
			double AverageSalaries = 0;
			double MinSalaries = 0;
			double MaxSalaries = 0;

			EmployeesCount = EmployeesDataTable.Rows.Count;
			TotalSalaries =
		   Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", String.Empty));
			AverageSalaries =
		   Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", String.Empty));
			MinSalaries =
		   Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", String.Empty));
			MaxSalaries =
		   Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", String.Empty));

			Console.WriteLine(EmployeesCount);
			Console.WriteLine(TotalSalaries);
			Console.WriteLine(AverageSalaries);
			Console.WriteLine(MinSalaries);
			Console.WriteLine(MaxSalaries);


			DataRow[] dataRows = EmployeesDataTable.Select("ID > 2");





			Console.WriteLine("\nEmployees List\n");
			foreach (DataRow row in dataRows)
			{
				row.Delete();
				//Console.WriteLine("ID: {0} Name: {1}Country: {2} Salary: {3} Date:{4}",row[0], row[1], row[2], row[3], row[4]);
				//Console.WriteLine("\n\n");
			}


			foreach (DataRow row in EmployeesDataTable.Rows)
			{
				/*row.Delete();*/
				Console.WriteLine("ID: {0} Name: {1}Country: {2} Salary: {3} Date:{4}", row[0], row[1], row[2], row[3], row[4]);
				Console.WriteLine("\n\n");
			}




			Console.ReadKey();
		}
	}
}
