<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="İletişim.aspx.cs" Inherits="CVapp.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="table table-bordered" style="margin-left:20px ; margin-right:50px">
     <tr>
         <th>ID</th>
         <th>AD SOYAD</th>
         <th>MAİL</th>
         <th>KONU</th>
         <th>MESAJI GÖR</th>

     </tr>
     <asp:Repeater ID="Repeater1" runat="server">
         <ItemTemplate>
             <tr>
                 
                 <td>    <%#Eval("ID") %></td>
                 <td>    <%#Eval("ADSOYAD") %></td>
                  <td>    <%#Eval("MAIL") %></td>
                  <td>    <%#Eval("KONU") %></td>
                 
                  
                  <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"MesajDetay.aspx?ID=" + Eval("ID")%>' CssClass=" btn btn-success" >Mesajı Gör</asp:HyperLink></td></td>

                 
                 
             </tr>

         </ItemTemplate>
     </asp:Repeater>
 </table>
</asp:Content>
