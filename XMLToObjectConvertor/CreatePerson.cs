using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlToObjectConvertor.DataAccessLayer;

namespace XmlToObjectConvertor
{
    public partial class CreatePerson : Form
    {
        List<Person> newPersonList = new List<Person>();
        DBConnection dbc = new DBConnection();
        Form pForm;

        public CreatePerson(Form parentForm)
        {
            InitializeComponent();
            pForm = parentForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text) && !string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtAge.Text))
                {
                    newPersonList.Add(new Person(Int32.Parse(txtID.Text), txtFirstName.Text, txtLastName.Text, Int32.Parse(txtAge.Text)));
                    dbc.Insert(newPersonList);
                    this.Close();
                }
                else
                    MessageBox.Show("All fields must be initialized!", "Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}
