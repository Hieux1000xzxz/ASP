<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="tx2tx2.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Danh sách chuyến đi</h2>
    <asp:GridView ID="gr1" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="macd" HeaderText="Mã chuyến đi" />
            <asp:BoundField DataField="tencd" HeaderText="Tên chuyến đi" />
            <asp:BoundField DataField="songaydi" HeaderText="Số ngày đi" />
            <asp:BoundField DataField="songuoidi" HeaderText="Số người đi" />
            <asp:BoundField DataField="mapt" HeaderText="Mã phương tiện" />
            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Button ID="xoa" CommandName="xoa" CommandArgument='<%# Bind("macd") %>' Text="Xóa" OnCommand="Xoa_Click" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sửa">
                <ItemTemplate>
                    <asp:Button ID="sua" CommandName="sua" CommandArgument='<%# Bind("macd") %>' Text="Sửa" OnCommand="Sua_Click" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <p><asp:Button runat="server" ID="butThemChuyenDi" Text="Thêm chuyến đi" PostBackUrl="~/Add.aspx" /></p>
</asp:Content>
