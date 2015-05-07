google.load('visualization', '1', { packages: ['corechart'] });



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
    width: 1500,
    height: 700,
    fontSize:100
};

function drawVisualization(dataValues) {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Meses');
    data.addColumn('number', '2014');
    data.addColumn('number', '2015');
   

    for (var i = 0; i < dataValues.length; i++) {
        data.addRow(
            [dataValues[i].ColumnName, dataValues[i].ValorP, dataValues[i].ValorN]
            );
    }

    var options = {
        "title": "Comparativa ",
        width: 1800,
        height: 700,
        legendFontSize:30,
        titleFontSize:26,
        tooltipFontSize: 30,
        hAxis: {title: "Meses",
            titleColor:'#cc0000',
            titleFontSize: 25
        },
        vAxes: {

        }
     
    }
    new google.visualization.ColumnChart(document.getElementById('visualization')).draw(data, options);
}


$(window).resize(function () {
    drawVisualization();
});


