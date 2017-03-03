<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="_01_Web.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Teknopark İlk Web Projesi</h3>
        </div>






        <asp:Repeater ID="rptKisiler" runat="server">
            <HeaderTemplate>
                <table class="table table-hover">
                    <thead>
                        <tr>
                            <th>Kişi ID</th>
                            <th>Adı</th>
                            <th>Soyadı</th>
                            <th>Tarih</th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("kisiID") %></td>
                    <td><%#Eval("ad") %></td>
                    <td><%#Eval("soyad") %></td>
                    <td><%#Eval("tarih") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody>
                </table>
            </FooterTemplate>
        </asp:Repeater>


        <asp:Button Text="Kaydet" CssClass="btn btn-success btn-lg" runat="server" />
    </form>
</body>
</html>
