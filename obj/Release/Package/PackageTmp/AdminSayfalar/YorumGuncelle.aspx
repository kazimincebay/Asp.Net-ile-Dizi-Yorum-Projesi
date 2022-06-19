<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="diziYorum.AdminSayfalar.YorumGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Blog Başlık"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" enabled="false"></asp:TextBox>
        <br />

        <asp:Label ID="Label2" runat="server" Text="Kullanıcı Adı"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
        <br />



        <asp:Label ID="Label6" runat="server" Text="Yorum İçeriği"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" TextMode="MultiLine" style="height: 100px;"></asp:TextBox>
        <br />
        <br />

        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click" />

    </form>
</asp:Content>
