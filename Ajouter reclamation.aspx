<%@ Page Title="" Language="C#" MasterPageFile="~/Accuille.Master" AutoEventWireup="true" CodeBehind="Ajouter reclamation.aspx.cs" Inherits="chi_EFM.Ajouter_reclamation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="ID Reclamation :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tb_id" runat="server" Width="199px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Numero :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="205px">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Date Reclamation :"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="tb_date" runat="server" OnTextChanged="TextBox2_TextChanged" Width="198px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Objectif :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tb_obejectif" runat="server" Width="199px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Etat Reclamation :"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" Height="18px" Width="205px">
    </asp:DropDownList>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Reclamer" Width="81px" OnClick="Button1_Click" />
&nbsp;
</asp:Content>
