using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalVideo
{
    public partial class NewCustomer : Form
    {
        Database VR_db = new Database();
        public NewCustomer()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool valid = checkValidation();
            if (valid == true)
            {
                int cust = VR_db.NewCustomer(firstname.Text, lastName.Text, address.Text, phone_no.Text);
                if (cust == 1)
                {
                    lblCustId.Text = "";

                    ClearTextBoxes();
                    customerList();

                    MessageBox.Show("Successfully Add Customer");
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }
        
        public void customerList()
        {
            DataTable dt = new DataTable();

            dt = VR_db.CustomerList();
            gridViewCustomer.DataSource = dt;
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            customerList();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
       

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        public bool checkValidation()
        {
            if (string.IsNullOrEmpty(firstname.Text))
            {
                MessageBox.Show("First Name is required");
                return false;
            }
            else if (string.IsNullOrEmpty(lastName.Text))
            {
                MessageBox.Show("Last Name is required");
                return false;
            }
            else if (string.IsNullOrEmpty(address.Text))
            {
                MessageBox.Show("Address is required");
                return false;
            }
            else if (string.IsNullOrEmpty(phone_no.Text))
            {
                MessageBox.Show("Phone No. is required");
                return false;
            }
            return true;
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCustId.Text))
            {
                MessageBox.Show("Please Select the Customer for Update");
                return;
            }
            int cust = VR_db.UpdateCustomer(firstname.Text, lastName.Text, address.Text, phone_no.Text, Convert.ToInt32(lblCustId.Text));
            if (cust == 1)
            {
                lblCustId.Text = "";

                ClearTextBoxes();
                customerList();

                MessageBox.Show("Successfully Update Customer");
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCustId.Text))
            {
                MessageBox.Show("Please Select the Customer for Delete");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS Customer ??", "Customer Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int cust = VR_db.DeleteCustomer(Convert.ToInt32(lblCustId.Text));
                if (cust == 1)
                {
                    lblCustId.Text = "";

                    ClearTextBoxes();
                    customerList();

                    MessageBox.Show("Successfully Delete Customer");
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }



            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void gridViewCustomer_Click(object sender, EventArgs e)
        {
            if (gridViewCustomer.Rows.Count > 0)
            {
                lblCustId.Text = gridViewCustomer.CurrentRow.Cells[0].Value.ToString();
                firstname.Text = gridViewCustomer.CurrentRow.Cells[1].Value.ToString();
                lastName.Text = gridViewCustomer.CurrentRow.Cells[2].Value.ToString();
                address.Text = gridViewCustomer.CurrentRow.Cells[3].Value.ToString();
                phone_no.Text = gridViewCustomer.CurrentRow.Cells[4].Value.ToString();
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
