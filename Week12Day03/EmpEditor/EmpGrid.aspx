<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpGrid.aspx.cs" Inherits="EmpEditor.EmpGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="empGrid" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:CommandField  />
                <asp:TemplateField>
                    <EditItemTemplate>

                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Name" HeaderText="Employee name" />       
                <asp:BoundField ItemStyle-Width="100px" DataField="" HeaderText="Employee name" />
            </Columns>
        </asp:GridView>
        <asp:DropDownList runat="server" ID="ddlEmployees" DataValueField="Name" DataTextField="Name" AutoPostBack="true" OnSelectedIndexChanged="ddlEmployees_SelectedIndexChanged"></asp:DropDownList>
    <div>
        
    </div>
    </form>
</body>
</html>
