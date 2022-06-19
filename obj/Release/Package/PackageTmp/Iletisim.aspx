<%@ Page Title="" Language="C#" MasterPageFile="~/kullanici.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="diziYorum.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact-content">
        <div class="container">
            <div class="contact-info">
                <h2>İletişim</h2>
                <p>Blog'umuzda bulunan içerikler için yaşadığınız her türlü sıkıntı ya da her türlü görüş ve önerileriniz için bizimle iletişime geçebilirsiniz.</p>
            </div>
            <div class="contact-details">
                <form runat="server">
                    <asp:TextBox ID="TextBox1" placeholder="Ad Soyad" runat="server" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox2" placeholder="Email" runat="server" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox3" placeholder="Telefon" runat="server" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox4" placeholder="Konu" runat="server" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox5" placeholder="Mesajınız" runat="server" TextMode="MultiLine" Height="100" required=""></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Gönder" />
                </form>
            </div>
            <div class="contact-details">
                <div class="col-md-6 contact-map">
                    <h4>Bizi Burada Bulun</h4>
                    <div class="mapouter"><div class="gmap_canvas"><iframe width="600" height="500" id="gmap_canvas" src="https://maps.google.com/maps?q=%C4%B0stanbul&t=&z=13&ie=UTF8&iwloc=&output=embed" frameborder="0" scrolling="no" marginheight="0" marginwidth="0"></iframe><a href="https://putlocker-is.org"></a><br><style>.mapouter{position:relative;text-align:right;height:500px;width:600px;}</style><style>.gmap_canvas {overflow:hidden;background:none!important;height:500px;width:600px;}</style></div></div>
                </div>
                <div class="col-md-6 company_address">
                    <h4>Adresimiz</h4>
                    <p>İstanbul Mahallesi,</p>
                    <p>İstanbul Caddesi, No:34/34,</p>
                    <p>İstanbul/Türkiye</p>
                    <p>Phone:0212 000 00 00</p>
                    <p>Fax: 0216 000 00 00</p>
                    <p>Email: <a href="mailto:info@example.com">bilgi@sirketismi.istanbul</a></p>
                    <p>Sosyal Medya: <a href="#">Facebook</a>, <a href="#">Twitter</a></p>
                </div>
                <div class="clearfix"></div>
            </div>


        </div>
    </div>
</asp:Content>
