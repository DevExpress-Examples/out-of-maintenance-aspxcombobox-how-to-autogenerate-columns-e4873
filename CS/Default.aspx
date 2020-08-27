<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" DataSourceID="SqlDataSource1" OnInit="ASPxComboBox1_Init" TextFormatString="{1} {2}" ValueField="CategoryID" ValueType="System.Int32">
        </dx:ASPxComboBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
