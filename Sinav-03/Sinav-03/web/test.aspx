<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Sinav_03.web.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptKullanicilar" runat="server">
                <HeaderTemplate>
                    <table class="table table-hover">
                        <thead>
                            <tr>
                                <th>kullaniciID</th>
                                <th>Ad Soyad</th>
                                <th>Kullanıcı Adı</th>
                                <th>E-Posta</th>
                                <th>Şifre</th>
                                <th>Yetki(ler)</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("kullaniciID") %></td>
                        <td><%#Eval("adSoyad") %></td>
                        <td><%#Eval("kullaniciAdi") %></td>
                        <td><%#Eval("ePosta") %></td>
                        <td><%#Eval("sifre") %></td>
                        <td><%#Eval("yetkiAdi") %></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
