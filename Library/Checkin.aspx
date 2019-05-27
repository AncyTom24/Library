<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkin.aspx.cs" Inherits="Library.Checkin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div>
           <h1>Book Check-in</h1>
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
                      <%--<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>--%>
                          <asp:DropDownList ID="drpBookName" runat="server">
                            <asp:ListItem Text="Select Book" Value="select" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="Indroduction to programming" Value="Indroduction to programming"></asp:ListItem>
                            <asp:ListItem Text="Mobile Strategy" Value="Mobile Strategy"></asp:ListItem>                            
                            <asp:ListItem Text="Software Testing and Qaulity Assurance" Value="Software Testing and Qaulity Assurance"></asp:ListItem>   
                            <asp:ListItem Text="Interaction Design Concepts" Value="Interaction Design Concepts"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Book ID</td>
                    <td>
                      <%--<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>--%>
                          <asp:DropDownList ID="drpBookID" runat="server">
                            <asp:ListItem Text="Select Book ID" Value="select" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="AlgBk0001" Value="AlgBk0001"></asp:ListItem>
                            <asp:ListItem Text="AlgBk0002" Value="AlgBk0002"></asp:ListItem>                            
                            <asp:ListItem Text="AlgBk0003" Value="AlgBk0003"></asp:ListItem>                            
                            <asp:ListItem Text="AlgBk0004" Value="AlgBk0004"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                    <td>Taken date</td>
                    <td>
                      <asp:TextBox ID="txtTakenDate" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>                
                <tr>
                    <td>
                        <asp:Button ID="BtnCheckin" runat="server" Text="Check-in" />
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
