<%@ Page Title="" Language="C#" MasterPageFile="~/kullanici.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="diziYorum.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="content-grids">
            <div class="col-md-8 content-main">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="content-grid">
                            <div class="content-grid-info">
                                <a href="blogDetay.aspx?blogId=<%# Eval("blogId") %>"> <img src="<%# Eval("blogGorsel") %>" alt="" style="height:250px;" /></a>
                                <div class="post-info">
                                    <h4><a href="blogDetay.aspx?blogId=<%# Eval("blogId") %>"><%# Eval("blogBaslik") %></a> <%# Eval("blogTarih") %></h4>
                                    <p><%# Eval("blogIcerik") %></p>
                                    <a href="blogDetay.aspx?blogId=<%# Eval("blogId") %>"><span></span>Devamını Oku</a>
                                </div>
                            </div>


                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="col-md-4 content-right">
                <div class="recent">
                    <h3>Son Postlar</h3>
                    <ul>
                        <asp:Repeater ID="Repeater3" runat="server"><ItemTemplate>
                        <li><a href="blogDetay.aspx?blogId=<%# Eval("blogId") %>"><%# Eval("blogBaslik") %></a></li></ItemTemplate></asp:Repeater>
                    </ul>
                </div>
                <div class="comments">
                    <h3>Son Yorumlar</h3>
                    <ul>
                        <asp:Repeater ID="Repeater4" runat="server"><ItemTemplate><li><%# Eval("KullaniciAd") %> : <%# Eval("yorumIcerik") %></li></ItemTemplate></asp:Repeater>
                        
                    </ul>
                </div>
                <div class="clearfix"></div>
                <div class="archives">
                    <h3>Arşivler</h3>
                    <ul>
                        <li><a href="#">Haziran 2022</a></li>
                        <li><a href="#">Temmuz 2022</a></li>
                        <li><a href="#">Ağustos 2022</a></li>
                        <li><a href="#">Eylül 2022</a></li>
                    </ul>
                </div>
                <div class="categories">
                    <h3>Kategoriler</h3>
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server"><ItemTemplate>
                        <li><a href="kategoriDetay.aspx?kategoriId=<%# Eval("kategoriId") %>"><%# Eval("kategoriAd") %></a></li></ItemTemplate></asp:Repeater>
                       
                    </ul>
                </div>
                <div class="clearfix"></div>
            </div>
            <div class="clearfix"></div>
        </div>
    </div>
</asp:Content>
