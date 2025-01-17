<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CVapp.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h4>MESAJ DETAYLARI</h4>

    <asp:TextBox ID="AdSoyad" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox><br />
    <asp:TextBox ID="Mail" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox><br />
    <asp:TextBox ID="Konu" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox><br />
    <asp:TextBox ID="Mesaj" TextMode="MultiLine"  runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
</asp:Content>
