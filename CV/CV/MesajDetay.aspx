<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CV.MesajDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div style="margin:10px;">
    <h4>MESAJ DETAY SAYFASI</h4>
    <br />
    <label>Ad Soyad</label>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"  ReadOnly="true"></asp:TextBox>
            <br />
            <label>Mail Adresi</label>
    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"  ReadOnly="true"></asp:TextBox>
            <br />
            <label>Konu</label>
    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"  ReadOnly="true"></asp:TextBox>
            <br />
            <label>Mesaj</label>
    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"  ReadOnly="true" Height="100px" TextMode="MultiLine"></asp:TextBox>

        
        </div>
</asp:Content>
