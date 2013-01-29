<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<HobbiesMVC.Models.HobbyModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	crear
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>crear</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.codigo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.codigo) %>
                <%: Html.ValidationMessageFor(model => model.codigo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.descripcion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.descripcion) %>
                <%: Html.ValidationMessageFor(model => model.descripcion) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

