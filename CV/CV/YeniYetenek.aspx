<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniYetenek.aspx.cs" Inherits="CV.YeniYetenek" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:10px;">
    <h4>YENİ YETENEK EKLEME SAYFASI</h4>
    <br />
    
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Yetenek Yazın..."></asp:TextBox>
        <br />
         <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="0-100 arasında Derece Giriniz..."></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ekle" CssClass="btn-info" OnClick="Button1_Click" />
        </div>
</asp:Content>
