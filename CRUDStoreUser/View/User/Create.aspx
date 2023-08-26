<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="CRUD_Usuário.View.User.Create" %>

<%@ Register Src="~/WebControl/LoginControl.ascx" TagPrefix="uc1" TagName="LoginControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:LoginControl runat="server" id="LoginControl" />
</asp:Content>
