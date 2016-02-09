<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="OzluSozlukAPI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="ButtonInsert" runat="server" Text="Button" OnClick="ButtonInsert_OnClick" />
        <asp:Label ID="LabelError" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
