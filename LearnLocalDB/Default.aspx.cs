using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnLocalDB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ACMEEntities1 db = new ACMEEntities1();

            //var customers = db.Customers;
            string result = "";

            // *** This is for the first exercise ***
            //foreach (var customer in customers)
            //{
            //    result += $"<p>{customer.Name}</p>";
            //}

            DisplayCustomers();

            resultLabel.Text = result;
        }

        protected void customersGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = customersGridView.Rows[index];

            // This is a bit risky... Take great caution.

            string customerName = row.Cells[1].Text;
            string customerAddress = row.Cells[2].Text;
            string customerCity = row.Cells[3].Text;
            string customerState = row.Cells[4].Text;
            string customerZip = row.Cells[5].Text;

            resultLabel.Text = $"{customerName} lives at {customerAddress} {customerCity}, {customerState} {customerZip}";
        }

        protected void addCustomerButton_Click(object sender, EventArgs e)
        {
            var newCustomer = new DTO.Customer()
            {
                CustomerId = Guid.NewGuid(),
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                City = cityTextBox.Text,
                State = stateTextBox.Text,
                Postal_Code = zipTextBox.Text,
                Notes = notesTextBox.Text
            };

            Domain.CustomersManager.AddCustomer(newCustomer);
            DisplayCustomers();
            ClearFields();
        }

        private void ClearFields()
        {
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            stateTextBox.Text = "";
            zipTextBox.Text = "";
            notesTextBox.Text = "";
        }

        private void DisplayCustomers()
        {
            var customers = Domain.CustomersManager.GetCustomers();

            customersGridView.DataSource = customers.ToList();
            customersGridView.DataBind();
        }
    }
}