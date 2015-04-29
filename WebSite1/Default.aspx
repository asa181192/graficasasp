<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="refresh" content="10">

<script src="//ajax.googleapis.com/ajax/libs/jquery/1.8.0/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="//www.google.com/jsapi"></script>

<meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="Content/bootstrap.min.css" rel="stylesheet">
	<link href="css/style.css" rel="stylesheet">
    <script type="text/javascript" src="js/jquery.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.min.js"></script>
	<script type="text/javascript" src="js/scripts.js"></script>

    <title>GRAFICAS</title>

    <script type="text/javascript">
        google.load('visualization', '1', { packages: ['corechart'] });
    </script>
    <script type="text/javascript">

        

        $(document).ready(function () {
            $.ajax({
                type: 'POST',
                dataType: 'json',
                contentType: 'application/json',
                url: 'Default.aspx/GetData',
                data: '{}',
                success:
                    function (response) {
                        drawVisualization(response.d);
                    }
            });
        })

        var options = {
            width: 1600,
            height: 1000,
            series: {
                0: { axis: 'distance' }, // Bind series 0 to an axis named 'distance'.
                1: { axis: 'brightness' } // Bind series 1 to an axis named 'brightness'.
            },
            axes: {
                y: {
                    distance: { label: 'parsecs' }, // Left y-axis.
                    brightness: { side: 'right', label: 'apparent magnitude' } // Right y-axis.
                }
            },
            displayExactValues:true
        };

        function drawVisualization(dataValues) {
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Meses');
            data.addColumn('number', '2014');
            data.addColumn('number', '2015');

            for (var i = 0; i < dataValues.length; i++) {
                data.addRow([dataValues[i].ColumnName, dataValues[i].ValorP, dataValues[i].ValorN]);
            }
            new google.visualization.ColumnChart(document.getElementById('visualization')).draw(data, options);
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">

    
    </form>

    <div class="container">
	<div class="row clearfix">
		<div class="col-md-12 column">
			<h3>
				Transmisor : FRAGUA
			</h3>
		</div>
	</div>
	<div class="row clearfix">
		<div class="col-md-6 column">
               
    <div id="visualization" style="width: 2000px; height: 700px;"></div>
		</div>
		<div class="col-md-6 column">
		</div>
	</div>
	<div class="row clearfix">
		<div class="col-md-12 column">
			<h3 class="text-left text-success">
				TRANSNETWORK
			</h3>
		</div>
	</div>
</div>
</body>
</html>