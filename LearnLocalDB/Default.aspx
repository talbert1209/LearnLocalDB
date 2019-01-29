<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LearnLocalDB.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="customersGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="customersGridView_RowCommand">
                <Columns>
                    <asp:ButtonField Text="View" />
                    <asp:BoundField DataField="Name" HeaderText="Customer Name" />
                    <asp:BoundField DataField="Address" HeaderText="Customer Address" />
                    <asp:BoundField DataField="City" HeaderText="Customer City" />
                    <asp:BoundField DataField="State" HeaderText="Customer State" />
                    <asp:BoundField DataField="Postal_Code" HeaderText="Customer Zip Code" />
                    <asp:BoundField DataField="Notes" HeaderText="Notes About Customer" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
