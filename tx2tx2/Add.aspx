<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="tx2tx2.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Thêm chuyến đi</h2>
    <asp:Table ID="table" runat="server">
       <asp:TableRow>
           <asp:TableCell>Tên chuyến đi</asp:TableCell>
           <asp:TableCell><asp:TextBox ID="txtTenChuyenDi" runat="server"></asp:TextBox></asp:TableCell>
       </asp:TableRow>
        <asp:TableRow>
           <asp:TableCell>Số ngày đi</asp:TableCell>
           <asp:TableCell><asp:TextBox ID="txtSoNgayDi" runat="server"></asp:TextBox></asp:TableCell>
       </asp:TableRow>
        <asp:TableRow>
           <asp:TableCell>Số người đi</asp:TableCell>
           <asp:TableCell><asp:TextBox ID="txtSoNguoiDi" runat="server"></asp:TextBox></asp:TableCell>
       </asp:TableRow>
        <asp:TableRow>
           <asp:TableCell>Phương tiện</asp:TableCell>
           <asp:TableCell><asp:DropDownList ID="drPhuongTien" runat="server" size="3"></asp:DropDownList></asp:TableCell>
       </asp:TableRow>
    </asp:Table>
     <asp:Button ID="butthem" Text="Thêm" runat="server" OnClick="butthem_Click" />
     <asp:Button ID="Butdong" Text="Đóng" runat="server" />
    <p><asp:Button runat="server" ID="butList" Text="Danh sách chuyến đi" PostBackUrl="~/List.aspx" /></p>
       
    <p>
           <asp:Label ID="error" runat="server" ForeColor="Red"> 
           </asp:Label>
       </p>

</asp:Content>
