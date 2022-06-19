<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="diziYorum.AdminSayfalar.Yorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Id</th>
            <th>Kullanıcı Adı</th>
            <th>E-Posta Adresi</th>
            <th>Yorum Yapılan Blog Adı</th>
            <th>Yorum</th>
            <th>Güncelle</th>
            <th>Sil</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr">
                    <td><%# Eval("yorumId") %></td>
                    <td><%# Eval("kullaniciAd") %></td>
                    <td><%# Eval("mail") %></td>
                    <td><%# Eval("blogBaslik") %></td>
                    <td><%# Eval("yorumicerik") %></td>
                    <td> <asp:HyperLink ID="HyperLink1"  CssClass="btn btn-warning" runat="server"  NavigateUrl='<%# "/AdminSayfalar/YorumGuncelle.aspx?yorumId="+ Eval("yorumId") %>'>Güncelle</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" CssClass="btn btn-danger" runat="server" NavigateUrl='<%# "YorumSil.aspx?yorumId="+ Eval("yorumId") %>'>Sil</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
</asp:Content>
