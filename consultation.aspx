<%@ Page Title="" Language="C#" MasterPageFile="~/Accuille.Master" AutoEventWireup="true" CodeBehind="consultation.aspx.cs" Inherits="chi_EFM.consultation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
   

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" Width="634px" OnRowCommand="GridView1_RowCommand" Height="173px">
        <Columns>
            <asp:ButtonField CommandName="Annulertach" Text="Anuler"  />
            <asp:ButtonField CommandName="aficher" Text="Afficher" />
        </Columns>
    </asp:GridView>
           
            <asp:GridView ID="GridView2" runat="server" Width="365px">
            </asp:GridView>
          
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
