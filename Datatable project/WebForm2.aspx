<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Datatable_project.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="EMPGRIDDATA1" runat="server" BackColor="White" BorderColor="#E7E7FF"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Calibri" Font-Size="Larger"
                GridLines="Horizontal">

                <AlternatingRowStyle BackColor="#F7F7F7" />

                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />

                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />

                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />

                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />

                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />

                <SortedAscendingCellStyle BackColor="#F4F4FD" />

                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />

                <SortedDescendingCellStyle BackColor="#D8D8F0" />

                <SortedDescendingHeaderStyle BackColor="#3E3277" />

            </asp:GridView>
            <asp:Button id="Button2" runat="server" text="Add Accountant" OnClick="Button2_Click" />
            <br />
            <br />
            Enter Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
            <br />
Enter Address<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
            <br />
<asp:Button ID="Button1" runat="server" Text="Edit" /> 
        </div>
    </form>
</body>
</html>
