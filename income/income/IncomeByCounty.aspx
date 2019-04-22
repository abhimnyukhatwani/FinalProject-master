<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IncomeByCounty.aspx.cs" Inherits="income.IncomeByCounty" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Income Statement</title>
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script type="text/javascript">

        $(function () {
            $("#Counties").autocomplete({
                source: "AutoComplete.aspx"
            });

            $('#incomeLS').DataTable();
        });
    </script>
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
    <div>
        <h2>Income By County</h2>
        <form id="form1" runat="server">
            <div class="row">
                <div class="col-6">
                    <label>Select the year: </label>
                    <asp:DropDownList class="form-control element-width" ID="yearDD" runat="server">
                        <asp:ListItem Text="2013" Value="2013"></asp:ListItem>
                        <asp:ListItem Text="2014" Value="2014"></asp:ListItem>
                        <asp:ListItem Text="2015" Value="2015"></asp:ListItem>
                        <asp:ListItem Text="2016" Value="2016"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-6">
                    <label>Choose County: </label>
                    <asp:TextBox ID="Counties" runat="server" class="form-control element-width"></asp:TextBox>
                </div>
            </div>
            <div class="mt">
                <asp:Button ID="incomeSearch" class="btn btn-primary" runat="server" Text="Income Search" OnClick="incomeSearch_Click" />
            </div>
            <br />
            <div id="displayContent mt">
                <asp:GridView class="table table-striped table-bordered text-center" ID="incomeLS" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="Income Bracket (in thousands $)" DataField="key" />
                        <asp:BoundField HeaderText="Household count" DataField="value" />
                    </Columns>
                </asp:GridView>
                <asp:Table ID="TableDD" Class="table table-bordered" runat="server" Style="border: 1px solid black; font-family: Arial; width: 800px;">
                    <asp:TableRow>
                        <asp:TableCell>Select Chart type: </asp:TableCell>
                        <asp:TableCell>
                            <asp:DropDownList ID="ChartListDD" CssClass="form-control" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ChartListDD_SelectedIndexChanged">
                            </asp:DropDownList>

                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:Chart ID="incomeChart" runat="server" Width="1000px">
                                <Series>
                                    <asp:Series Name="Series1" ChartType="Line">
                                    </asp:Series>
                                </Series>
                                <ChartAreas>
                                    <asp:ChartArea Name="ChartArea1">
                                        <AxisY Title="Val"></AxisY>
                                    </asp:ChartArea>
                                </ChartAreas>
                            </asp:Chart>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>


            </div>
        </form>
    </div>
</body>
</html>
