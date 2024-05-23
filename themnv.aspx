<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="themnv.aspx.cs" Inherits="masterpage2.themnv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    Them nhan vien
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">
    <h2>Them Nhan Vien</h2>

    <p>
        <label>Ma nhan vien</label>
        <asp:TextBox ID="txtempid" runat="server" />
    </p>

      <p>
        <label>Ten nhan vien</label>
        <asp:TextBox ID="txtname" runat="server" />
    </p>

      <p>
       <label>Gioi tinh&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
        <asp:TextBox ID="txtgender" runat="server" />
    </p>

      <p>
        <label>Dia chi</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtaddress" runat="server" />
    </p>

      <p>
        <label>Email</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtemail" runat="server" />
    </p>

      <p>
        <label>Ma phong&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
&nbsp;<asp:DropDownList ID="ddlMaphong" runat="server" size="3" />
    </p>

      <p>
        <asp:Button ID="btnThem" runat="server" Text="Them nhan vien" OnClick="btnThem_Click" />
        <asp:Button ID="btnReturnDS" runat="server" Text="Return" PostBackUrl="~/danhsach.aspx" />
    </p>

    <p>
        <asp:Label ID="msg" runat="server" Font-Italic="true" />
    </p>
</asp:Content>
