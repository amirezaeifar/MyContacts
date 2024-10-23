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
    public partial class FormInsertorEdit : Form
    {
        IMyContactsRepository repository;
        public int ContactId = 0;

        public FormInsertorEdit()
        {
            repository = new MyContactsRepository();
            InitializeComponent();
        }

        private void FormInsertorEdit_Load(object sender, EventArgs e)
        {
            if (ContactId == 0)
            {
                this.Text = "Create New Contact";
            }
            else
            {
                this.Text = "Edit Contact";
                btnCreate.Text = "Edit";
                groupBox1.Text = "Edit Contact";
                DataTable dt = repository.SelectRow(ContactId);
                tbFname.Text = dt.Rows[0][1].ToString();
                tbLname.Text = dt.Rows[0][2].ToString();
                tbEmail.Text = dt.Rows[0][3].ToString();
                tbNumber.Text = dt.Rows[0][4].ToString();
                tbBirthday.Text = dt.Rows[0][5].ToString();
                tbAddress.Text = dt.Rows[0][6].ToString();

            }
        }
        bool ValidateInputs() 
        {

            if (tbFname.Text == "")
            {
                MessageBox.Show("Enter First name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbLname.Text == "") 
            {
                MessageBox.Show("Enter Last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (tbNumber.Text == "")
            {
                MessageBox.Show("Enter Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tbEmail.Text == "")
            {
                MessageBox.Show("Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isSuccess;
                if (ContactId == 0)
                {
                    isSuccess = repository.Insert(tbFname.Text, tbLname.Text, tbNumber.Text, tbBirthday.Text, tbEmail.Text, tbAddress.Text);
                }
                else
                {
                    isSuccess = repository.Update(ContactId, tbFname.Text, tbLname.Text, tbNumber.Text, tbBirthday.Text, tbEmail.Text, tbAddress.Text);
                }
                if (isSuccess == true)
                {
                    MessageBox.Show("Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                
            }
        }

    }
}
