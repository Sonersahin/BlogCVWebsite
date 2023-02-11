<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KonferansListesi.aspx.cs" Inherits="BlogWebsite.KonferansListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
            <table class="table table-bordered">

                <tr>
                    <th>ID</th>
                    <th>KONFERANS VE SERTİFİKALAR</th>
                    <th>İŞLEMLER</th>
                </tr>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th><%# Eval("ID") %></th>
                                <td><%# Eval("KONFERANS") %></td>
                                <td>
                                    <asp:HyperLink NavigateUrl='<%#"KonferansSil.aspx?ID=" +  Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                    <asp:HyperLink NavigateUrl='<%# "KonferansGuncelle.aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-primary">Güncelle</asp:HyperLink>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>

            </table>
        <asp:HyperLink NavigateUrl="~/KonferansEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Konferans ve Sertifika Ekle</asp:HyperLink>
    </form>
</asp:Content>
