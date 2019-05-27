<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Library.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
         <h1>Book Check-out</h1>
        <br />
            <table>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>Student ID</td>
                    <td>
                        <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox></td>
                </tr>               
                <tr>
                    <td>Book Name</td>
                    <td>
                      <asp:TextBox ID="txtBookName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Book ID</td>
                    <td>
                      <asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>Return date</td>
                    <td>
                      <asp:TextBox ID="TxtReturnDate" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <br />
                <tr>
                    <td>
                        <asp:Button ID="btnCheckOut" runat="server" Text="Check-out" />
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
