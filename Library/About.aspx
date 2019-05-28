<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Library.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Add new Member</h1>
    <div>
            <table>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                            runat="server" ErrorMessage="Enter student name" 
                            ForeColor="Red" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td>Student ID</td>
                    <td>
                        <asp:TextBox ID="txtStudentID" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                            ErrorMessage="Enter student ID" ForeColor="Red" ControlToValidate="txtStudentID"></asp:RequiredFieldValidator>
                    </td>
                    
                </tr>
                <tr>
                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server" TextMode="Number"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                            runat="server" ErrorMessage="Enter Phone" 
                            ForeColor="Red" ControlToValidate="txtPhone"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                            runat="server" ErrorMessage="Enter address" 
                            ForeColor="Red" ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>City</td>
                    <td>
                        <asp:DropDownList ID="drpCity" runat="server">
                            <asp:ListItem Text="Select City" Value="select" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="Brampton" Value="Brampton"></asp:ListItem>
                            <asp:ListItem Text="Sault Ste. Marie" Value="Sault Ste. Marie"></asp:ListItem>                            
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="drpCity" InitialValue="Select City"
                            runat="server" ErrorMessage="Select city" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                      <asp:TextBox ID="txtemail" runat="server" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" 
                            runat="server" ErrorMessage="Enter email" 
                            ForeColor="Red" ControlToValidate="txtemail"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Button ID="btnNewMemb" runat="server" Text="Add New Member" OnClick="btnNewMemb_Click" />
                        <asp:Label ID="confirmLabel" runat="server" Visible="false"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
