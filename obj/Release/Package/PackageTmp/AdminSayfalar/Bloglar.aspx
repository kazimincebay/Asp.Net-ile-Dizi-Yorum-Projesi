<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Bloglar.aspx.cs" Inherits="diziYorum.AdminSayfalar.Bloglar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Id</th>
            <th>Başlık</th>
            <th>Tarih</th>
            <th>Tür</th>
            <th>Kategori</th>
            <th>Güncelle</th>
            <th>Sil</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr">
                    <td><%# Eval("blogId") %></td>
                    <td><%# Eval("blogBaslik") %></td>
                    <td><%# Eval("blogTarih") %></td>
                    <td><%# Eval("blogTur") %></td>
                    <td><%# Eval("blogKategori") %></td>
                    <td> <asp:HyperLink ID="HyperLink1"  CssClass="btn btn-warning" runat="server"  NavigateUrl='<%# "/AdminSayfalar/BlogGuncelle.aspx?blogId="+ Eval("blogId") %>'>Güncelle</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" CssClass="btn btn-danger" runat="server" NavigateUrl='<%# "BlogSil.aspx?blogId="+ Eval("blogId") %>'>Sil</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="/AdminSayfalar/YeniBlog.aspx" class="btn btn-primary">Yeni Blog Ekle</a>
</asp:Content>
