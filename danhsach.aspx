<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="danhsach.aspx.cs" Inherits="masterpage2.danhsach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    Danh sach nhan vien
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">

    <asp:GridView ID="grdDs" runat="server" AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField DataField="empid" HeaderText="Ma nhan vien" />
            <asp:BoundField DataField="name" HeaderText="Ten nhan vien" />
            <asp:BoundField DataField="gender" HeaderText="Gioi tinh" />
            <asp:BoundField DataField="address" HeaderText="Dia chi" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="titleid" HeaderText="Ma phong" />

            <asp:TemplateField HeaderText="Xoa">
                <ItemTemplate>
                    <asp:Button ID="xoa" CommandName="xoa" CommandArgument='<%# Bind("empid") %>'
                        Text="Xoa" OnCommand="Xoa_CLick" runat="server"
                        OnClientClick="return confirm ('Ban co chac chan muon xoa khong?')"
                        />
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Sua">
                <ItemTemplate>
                    <asp:Button ID="sua" CommandName="sua" CommandArgument='<%# Bind("empid") %>'
                        Text="Sua" OnCommand="Sua_Click" runat="server"
                        />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        

    </asp:GridView>


</asp:Content>
