using System.Data;

namespace MyContacts
{
    internal class InitializeComponent : IMyContactsRepository
    {
        public bool Delete(int ContactId)
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(string FirstName, string LastName, string Email, string MobileNumber, string Birthday, string Addres)
        {
            throw new System.NotImplementedException();
        }

        public DataTable Search(string parameter)
        {
            throw new System.NotImplementedException();
        }

        public DataTable SelectAll()
        {
            throw new System.NotImplementedException();
        }

        public DataTable SelectRow(int ContactId)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(int ContactId, string FirstName, string LastName, string Email, string MobileNumber, string Birthday, string Addres)
        {
            throw new System.NotImplementedException();
        }
    }
}