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
    displayExactValues: true
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


$(window).resize(function () {
    drawVisualization();
});


