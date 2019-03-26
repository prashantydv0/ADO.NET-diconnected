<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CLIENT2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            FIRST NAME<asp:TextBox ID="textfname" runat="server"></asp:TextBox>
            <br />
            <br />
            LAST NAME<asp:TextBox ID="textlname" runat="server"></asp:TextBox>
            <br />
            <br />
            PHONE NO&gt;<asp:TextBox ID="textphnno" runat="server" Width="115px"></asp:TextBox>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" Width="311px"></asp:TextBox>
            <br />
            <br />
            ADDRESS ID<asp:TextBox ID="textid" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btninsert" runat="server" OnClick="btninsert_Click" Text="INSERT" />
        <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" Text="DELETE" />
        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="UPDATE" />
        <asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click" Text="SEARCH" />
    </form>
</body>
</html>
