<%@ Page Title="Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Fraction._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Fraction 1:</h1>
    <asp:TextBox ID="Fraction1" class="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator1" runat="server" ControlToValidate="Fraction1" ErrorMessage="Fraction 1 is required"></asp:RequiredFieldValidator><br />
    <asp:RegularExpressionValidator ForeColor="Red" ID="RegularExpressionValidator2" runat="server" ErrorMessage="Numbers and / only" ControlToValidate="Fraction1" ValidationExpression="^[0-9](\/[0-9])?$"/>
    <asp:Label runat="server" ForeColor="Red" ID="error1"></asp:Label><br />

    <h1>Fraction 2:</h1>
    <asp:TextBox ID="Fraction2" class="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator2" runat="server" ControlToValidate="Fraction2" ErrorMessage="Fraction 2 is required"></asp:RequiredFieldValidator><br />
    <asp:RegularExpressionValidator ForeColor="Red" ID="RegularExpressionValidator1" runat="server" ErrorMessage="Numbers and / only" ControlToValidate="Fraction2" ValidationExpression="[0-9](\/[0-9])?$"/>
    <asp:Label runat="server" ForeColor="Red" ID="error2"></asp:Label><br /><br />

    <asp:Button ID="Add" onClick="Add_Click" class="btn btn-success" runat="server" Text="Add" /> 
    <asp:Button ID="Subtract" class="btn btn-danger" OnClick="Subtract_Click" runat="server" Text="Subtract" />
    <asp:Button ID="Multiply" class="btn btn-primary" OnClick="Multiply_Click" runat="server" Text="Multiply" />
    <asp:Button ID="Divide" class="btn btn-warning" onClick="Divide_Click" runat="server" Text="Divide" />
    <br />
    <h1>Output:</h1>
    <asp:Label ID="Output" runat="server"></asp:Label>
</asp:Content>
