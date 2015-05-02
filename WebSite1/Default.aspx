<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="refresh" content="60"/>
     <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.8.0/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="//www.google.com/jsapi"></script>


    <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
	<link href="Content/css/style.css" rel="stylesheet" />
    <script type="text/javascript" src="Content/js/jquery.min.js"></script>
	<script type="text/javascript" src="Content/js/bootstrap.min.js"></script>
	<script type="text/javascript" src="Content/js/scripts.js"></script>
    <script type="text/javascript" src="Content/js/chart.js"> </script>
    <link href="Content/css/chart.css" rel="stylesheet"/>
    <title>GRAFICAS</title>

   

</head>
<body>
 <div class="row clearfix">
		<div class="col-md-12 column">
			<div class="jumbotron" >
				<h1>
					Transmisor :  &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
				</h1>
			</div>
		</div>
	</div>
   <form id="form1" runat="server">
  <div id="visualization"></div>
  </form> 
	
	
        	
  
    </body>
</html>