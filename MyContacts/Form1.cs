using MyContacts.Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class form1 : Form
    {
        IMyContactsRepository repository;
        public form1()
        {
            repository = new MyContactsRepository();
            InitializeComponent();
        }
        private void MyContacts_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            FormInsertorEdit NewContact = new FormInsertorEdit();
            NewContact.ShowDialog();
            BindGrid();
        }
        void BindGrid()
        {
            dgContact.AutoGenerateColumns = false;
            dgContact.DataSource = repository.SelectAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string fname = dgContact.CurrentRow.Cells[1].Value.ToString();
            string lname = dgContact.CurrentRow.Cells[2].Value.ToString();
            string fullname = fname + " " + lname;
            if (dgContact.CurrentRow != null)
            {
                if (MessageBox.Show($"Do you want to Delete {fullname}", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int ContactId = int.Parse(dgContact.CurrentRow.Cells[0].Value.ToString());
                    repository.Delete(ContactId);
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgContact.CurrentRow != null)
            {
                int ContactId = int.Parse(dgContact.CurrentRow.Cells[0].Value.ToString());
                FormInsertorEdit frm = new FormInsertorEdit();
                frm.ContactId = ContactId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                   
                }
            }
            BindGrid();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgContact.DataSource = repository.Search(tbSearch.Text);
        }
    }
}
