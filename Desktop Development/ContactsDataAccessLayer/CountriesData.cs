using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;

namespace ContactsDataAccessLayer
{
	public class CountriesData
	{

		

		public static bool GetCountryByCountryID(int CountryID,ref string CountryName,ref string Code,ref string PhoneCode)
		{
			bool isFound = false;

			SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "SELECT * FROM Countries  where CountryID = @CountryID;";

			SqlCommand cmd = new SqlCommand(query, sqlConnection);

			cmd.Parameters.AddWithValue("@CountryID", CountryID);

			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if(reader.Read())
				{
					CountryName = (string)reader["CountryName"];

					Code = (reader["Code"] == System.DBNull.Value) ? "" : (string)reader["Code"];				
					PhoneCode = (reader["PhoneCode"] == System.DBNull.Value) ? "" : (string)reader["PhoneCode"];

					isFound = true;
				}
				else
				{
					isFound  = false;
				}
					
				
			}
			catch (Exception)
			{
				isFound = false;

			}
			finally { sqlConnection.Close(); }

			return isFound;
		}


		public static bool GetCountryByCountryName(ref int CountryID,  string CountryName,ref string Code,ref string PhoneCode)
		{
			bool isFound = false;

			SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "SELECT * FROM Countries  where CountryName = @CountryName;";

			SqlCommand cmd = new SqlCommand(query, sqlConnection);

			cmd.Parameters.AddWithValue("@CountryName", CountryName);

			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					CountryID = (int)reader["CountryID"];
					Code = (reader["Code"] == System.DBNull.Value) ? "" : (string)reader["Code"];
					PhoneCode = (reader["PhoneCode"] == System.DBNull.Value) ? "" : (string)reader["PhoneCode"];

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
			finally { sqlConnection.Close(); }

			return isFound;
		}

		public static int AddNewCountry(string CountryName,string Code,string PhoneCode)
		{
			SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "insert into Countries values(@CountryName,@Code,@PhoneCode);select SCOPE_IDENTITY();";

			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@CountryName", CountryName);

			if(Code != "")
			{

				sqlCommand.Parameters.AddWithValue("@Code", Code);
			}
			else
			{

				sqlCommand.Parameters.AddWithValue("@Code", System.DBNull.Value);
			}


			if (PhoneCode != "")
			{

				sqlCommand.Parameters.AddWithValue("@PhoneCode", PhoneCode);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("@PhoneCode", DBNull.Value);
			}


			int CountryID = -1;
			try
			{
				sqlConnection.Open();

				object result = sqlCommand.ExecuteScalar();

				if (result != null && int.TryParse(result.ToString(), out int InsintionId))
				{
					CountryID = InsintionId;

				}
				else
				{
					CountryID = -1;
				}




			}
			catch (Exception)
			{
				CountryID = -1;
			}finally { sqlConnection.Close(); }

			return CountryID;

		}


		public static bool UpdateCountry(int CountryID,string CountryName,string Code,string PhoneCode)
		{
			SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "Update Countries set CountryName = @CountryName,Code = @Code,PhoneCode = @phoneCode where CountryID = @CountryID";

			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@CountryID", CountryID);
			sqlCommand.Parameters.AddWithValue("@CountryName", CountryName);
			sqlCommand.Parameters.AddWithValue("@Code", Code);
			sqlCommand.Parameters.AddWithValue("@PhoneCode", PhoneCode);

			int RowsEfficted = 0;

			try
			{
				sqlConnection.Open();

				RowsEfficted = sqlCommand.ExecuteNonQuery();


			}
			catch (Exception)
			{
				RowsEfficted = 0;
			}
			finally { sqlConnection.Close(); }

			return (RowsEfficted > 0);
		}

		public static bool DeleteCountry(int CountryID)
		{
			SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "Delete from Countries where CountryID = @CountryID";

			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@CountryID", CountryID);

			int RowsEfficted = -1;
			try
			{
				sqlConnection.Open();

				RowsEfficted = sqlCommand.ExecuteNonQuery();

			}
			catch (Exception)
			{
				RowsEfficted = -1;
			}finally { sqlConnection.Close(); }

			return (RowsEfficted > 0);
		}

		public static DataTable CountriesList()
		{
			DataTable dt = new DataTable();

			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "select * from Countries";

			SqlCommand sqlCommand = new SqlCommand(query, connection);

			try
			{
				connection.Open();

				SqlDataReader reader = sqlCommand.ExecuteReader();

				if(reader.HasRows)
				{
					dt.Load(reader);
				}
				else
				{
					return null;
				}
			}
			catch (Exception)
			{
				return null;
			}
			finally
			{
				connection.Close();
			}

			return dt; 
		}


		public static bool IsCountryExist(string countryName)

		{
			bool isFound = false;

			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "select Found = 1 from Countries where CountryName = @CountryName; ";

			SqlCommand sqlCommand = new SqlCommand(query, connection);

			sqlCommand.Parameters.AddWithValue("@CountryName", countryName);

			try
			{
				connection.Open();

				SqlDataReader reader = sqlCommand.ExecuteReader();

				if(reader.HasRows)
				{
					isFound = true;
				}
				else
				{
					isFound= false;
				}

			}
			catch (Exception)
			{
				isFound= false;
			}finally { connection.Close(); }

			return isFound;
		}
	}
}
