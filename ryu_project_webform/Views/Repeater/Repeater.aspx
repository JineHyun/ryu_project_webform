<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="ryu_project_webform.Views.Repeater.Repeater" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <thead>
            <tr>
                <th>아이디</th>
                <th>이름</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="rptOne" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("id") %></td>
                        <td><%# Eval("name") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
