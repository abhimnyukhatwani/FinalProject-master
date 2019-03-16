<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="income.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/design.css" />
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
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
    <div class="row">
        <div class="col-6">
            <br />
            <br />
        </div>
        <div class="col-6">
            <br />
            <br />
        </div>
    </div>
    <div class="row">
        <div class="col-6">
            <a href="/IncomeByCounty.aspx">
                 <img src="vertical.png" width="20"  height="250"/>
                <img src="income.jpg" alt="Income for a county" width="350" height="250"/></a>
                        <img src="vertical.png" width="20"  height="250"/>
            
        </div>
        <div class="col-6">
            <a href="/Marvelcharacters.aspx">
                     <img src="vertical.png" width="20"  height="250"/>
                <img src="marvel.png" alt="Marvel movies" /></a>
                 <img src="vertical.png" width="20"  height="250"/>
         
           
        </div>
        <div class="col-6"><h4>Income of US Counties</h4></div>
        <div class="col-6"><h4>Marvel movies </h4> </div>
    </div>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
