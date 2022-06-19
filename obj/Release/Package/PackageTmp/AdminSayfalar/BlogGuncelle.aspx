<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="BlogGuncelle.aspx.cs" Inherits="diziYorum.AdminSayfalar.BlogGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Blog Başlık"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="Blog Tarih"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="Blog Görsel"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox><br />

        <asp:Label ID="Label4" runat="server" Text="Blog Tür"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="turAdi" DataValueField="turId"></asp:DropDownList><br />
        <br />

        <asp:Label ID="Label5" runat="server" Text="Blog Kategori"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" DataTextField="kategoriAd" DataValueField="kategoriId"></asp:DropDownList><br />
        <br />

        <asp:Label ID="Label6" runat="server" Text="Blog İçeriği"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" TextMode="MultiLine" style="height:100px;"></asp:TextBox><br />
        <br />

        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click"  />

    </form>
</asp:Content>
