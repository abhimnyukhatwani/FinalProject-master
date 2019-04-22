<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Marvelcharacters.aspx.cs" Inherits="FinalGrpXML.Marvelcharacters" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/design.css" />
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
</head>
<body class="container">
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark sticky-top">
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" href="/Home.aspx"><em>Home</em></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Marvelcharacters.aspx"><em>Marvel Characters</em></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/IncomeByCounty.aspx"><em>Income By County</em></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="RegionService.aspx"><em>Region Service</em></a>
                </li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="mt">
            <asp:Label ID="Label1" runat="server" Text="Click on the button to get the marvel movie details"></asp:Label>
            <asp:Button ID="Button2" Class="btn btn-primary" runat="server" Text="Get Movies" OnClick="Button2_Click" />
        </div>
    </form>
    <div class ="content">
        <%=DisplayResults() %>
    </div>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" ></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" ></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
</body>
</html>
