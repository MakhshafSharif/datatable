<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Datatable_project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <script src="DataTables/jQuery-2.2.0/jquery-2.2.0.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
         <div>
        UserName:<asp:textbox id="UserName" runat="server" ></asp:textbox> <br />
        <br />  
        Password:<asp:textbox id="Password" runat="server"></asp:textbox>  <br />
        <br />  
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:Button id="Button1" runat="server" text="Login" onclick="Button1_Click"/>  
        </div>
    </form>
</body>
</html>
