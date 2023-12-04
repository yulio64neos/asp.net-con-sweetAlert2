<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hola Mundo</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar">
                <div class="container-fluid">
                    <span class="navbar-text">
                        Web para el curso de ASP.NET
                    </span>
                </div>
            </nav>

            <div class="container">
                <h2>Guardar Imagen en el servidor</h2>
                <asp:FileUpload ID="fileUpload" runat="server" />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar Imagen" CssClass="btn btn-primary" OnClick="btnGuardar_Click"/>
                <br />
                <asp:Image ID="imgMostrar" runat="server" Visible="false" />
            </div>
        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
