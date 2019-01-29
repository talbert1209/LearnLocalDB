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
            ACMEEntities db = new ACMEEntities();

            var customers = db.Customers;
            string result = "";

            // *** This is for the first exercise ***
            //foreach (var customer in customers)
            //{
            //    result += $"<p>{customer.Name}</p>";
            //}

            customersGridView.DataSource = customers.ToList();
            customersGridView.DataBind();

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
    }
}