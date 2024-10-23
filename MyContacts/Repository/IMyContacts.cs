using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyContacts
{
    internal interface IMyContactsRepository
    {

        DataTable SelectAll();
        DataTable SelectRow(int ContactId);
        DataTable Search(string parameter);
        bool Insert(string FirstName, string LastName, string Email, string MobileNumber,string Birthday, string Address);
        bool Update(int ContactId, string FirstName, string LastName, string Email, string MobileNumber, string Birthday, string Address);
        bool Delete(int ContactId);


    }
}
