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
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Enter name" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td>Student ID</td>
                    <td>
                        <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtStudentID" ErrorMessage="Enter student ID" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>               
               <tr>
                    <td>Book Name</td>
                    <td>
                      <asp:DropDownList ID="drpBookName" runat="server">
                            <asp:ListItem Text="Select Book" Value="select" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="Indroduction to programming" Value="Indroduction to programming"></asp:ListItem>
                            <asp:ListItem Text="Mobile Strategy" Value="Mobile Strategy"></asp:ListItem>                            
                            <asp:ListItem Text="Software Testing and Qaulity Assurance" Value="Software Testing and Qaulity Assurance"></asp:ListItem>   
                            <asp:ListItem Text="Interaction Design Concepts" Value="Interaction Design Concepts"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="drpBookName" ErrorMessage="Select a book" ForeColor="Red" InitialValue="Select Book"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Book ID</td>
                    <td>
                     <asp:DropDownList ID="drpBookID" runat="server">
                            <asp:ListItem Text="Select Book ID" Value="select" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="AlgBk0001" Value="AlgBk0001"></asp:ListItem>
                            <asp:ListItem Text="AlgBk0002" Value="AlgBk0002"></asp:ListItem>                            
                            <asp:ListItem Text="AlgBk0003" Value="AlgBk0003"></asp:ListItem>                            
                            <asp:ListItem Text="AlgBk0004" Value="AlgBk0004"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="drpBookID" ErrorMessage="Select a book ID" ForeColor="Red" InitialValue="Select Book ID"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                 <tr>
                    <td>Return date</td>
                    <td>
                      <asp:TextBox ID="TxtReturnDate" runat="server" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtReturnDate" ErrorMessage="Select a valid date" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <br />
                <tr>
                    <td>
                        <asp:Button ID="btnCheckOut" runat="server" Text="Check-out" OnClick="btnCheckOut_Click" />
                        <asp:Label ID="confirmLabel" runat="server" Visible="false"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
