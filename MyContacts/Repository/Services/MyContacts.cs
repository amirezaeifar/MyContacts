using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyContacts.Repository.Services
{
    internal class MyContactsRepository : IMyContactsRepository
    {

        private string connectionKey = "Data Source=. ; Initial Catalog= MyContacts; Integrated Security = true";
        public bool Delete(int ContactId)
        {
            SqlConnection connection = new SqlConnection(connectionKey);
            try 
            {
                string query = "Delete From Contacts Where id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", ContactId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }

            catch 
            {
                return false;
            }

            finally 
            {
                connection.Close();
            }
        }

        public bool Insert(string FirstName, string LastName, string MobileNumber, string Birthday, string Email, string Address)
        {
            SqlConnection connection = new SqlConnection(connectionKey);

            try
            {
                string query = "Insert Into Contacts (FirstName, LastName, MobileNumber, Birthday, Email, Address) Values (@fname,@lname,@number, @birthday, @email, @address)";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@fname", FirstName);
                command.Parameters.AddWithValue("@lname", LastName);
                command.Parameters.AddWithValue("@number", MobileNumber);
                command.Parameters.AddWithValue("@birthday", Birthday);
                command.Parameters.AddWithValue("@email", Email);
                command.Parameters.AddWithValue("@address", Address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally 
            {
                connection.Close();
            }
        }

        public DataTable Search(string parameter)
        {
            string query = "Select * From Contacts Where FirstName Like @parameter or LastName Like @parameter";
            SqlConnection connection = new SqlConnection(connectionKey);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAll()
        {
            string query = "Select * From Contacts";
            SqlConnection connection = new SqlConnection(connectionKey);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

        public DataTable SelectRow(int ContactId)
        {
            string query = "Select * From Contacts Where id ="+ ContactId;
            SqlConnection connection = new SqlConnection(connectionKey);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(int ContactId, string FirstName, string LastName, string Email, string MobileNumber, string Birthday, string Address)
        {
            SqlConnection connection = new SqlConnection(connectionKey);

            try
            {
                string query = $"UPDATE Contacts SET FirstName = @fname, LastName= @lname, MobileNumber = @number, Birthday = @birthday, Email = @email, Address = @address Where id = {ContactId}";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", ContactId);
                command.Parameters.AddWithValue("@fname", FirstName);
                command.Parameters.AddWithValue("@lname", LastName);
                command.Parameters.AddWithValue("@number", Email);
                command.Parameters.AddWithValue("@birthday", MobileNumber);
                command.Parameters.AddWithValue("@email", Birthday);
                command.Parameters.AddWithValue("@address", Address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
             
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
