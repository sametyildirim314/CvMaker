<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="CVapp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered" style="margin-left:20px ; margin-right:50px">
        <tr>
            <th>ID</th>
            <th>YETENEK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>

        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    
                    <td>    <%#Eval("ID") %></td>
                    <td>    <%#Eval("YETENEK") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"YetenekSil.aspx?ID=" + Eval("ID")%>' CssClass=" btn btn-danger" >SİL</asp:HyperLink></td>
                     <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"YetenekGüncelle.aspx?ID=" + Eval("ID")%>' CssClass=" btn btn-success" >Güncelle</asp:HyperLink></td></td>


                    
                </tr>

            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="YeniYetenek.aspx" class =" btn btn-primary" style="margin-left:20px">Yeni Yetenek</a>
</asp:Content>
