<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KonferansEkle.aspx.cs" Inherits="BlogWebsite.KonferansEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div calss="form-group">


            <div>
                <asp:Label ID="Label1" runat="server" Text="KONFERANS VE SERTİFİKALAR"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="KAYDET" CssClass="btn btn-success" OnClick="Button1_Click"  />
        </div>

    </form>
</asp:Content>
