<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="AplicacionWeb.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 367px;
        }
    </style>
</head>
<body>
    <form id="frmCalentamiento" runat="server" title="Forma de prueba">
        <div style="height: 361px">
            Hello World<br />
            Parámetros de entrada:<asp:Calendar ID="cldFechaDeEntrada" runat="server" OnSelectionChanged="cldFechaDeEntrada_SelectionChanged"></asp:Calendar>
            <br />
            Fecha seleccionada: <asp:Label ID="lblFechaSeleccionada" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
