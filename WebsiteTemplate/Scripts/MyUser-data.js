/*
//Flot Pie Chart
$(document).ready(function () {
    
    var data = [{
        label: "Series 0",
        data: 1
    }, {
        label: "Series 1",
        data: 3
    }, {
        label: "Series 2",
        data: 9
    }, {
        label: "Series 3",
        data: 20
    }];

    var data =
        "{label: \"Series 0\", data: 1}, {label: \"Series 1\", data: 3}, {label: \"Series 2\",data: 9}, {label: \"Series 3\", data: 20}";

    var plotObj = $.plot($("#MyUserPlot"), [data], {
        series: {
            pie: {
                show: true
            }
        },
        grid: {
            hoverable: true
        },
        tooltip: true,
        tooltipOpts: {
            content: "%p.0%, %s", // show percentages, rounding to 2 decimal places
            shifts: {
                x: 20,
                y: 0
            },
            defaultTheme: false
        }
    });

});*/
/*
//Flot Pie Chart
$(document).ready(function() {
        $.ajax({
            url: '/MyUser/Get',
            method: 'GET',
            data: {},
            dataType: 'json',
            success: function (data) {
                alert('data:' + data);
                $.plot($("#MyUserPlot"),data);
            }
        });
    });
    */

$(document).ready(function () {
    $.getJSON('/MyUser/Get', function (data) {
        $.plot($('#MyUserPlot'), [data]);
        alert('data:' + data);
    });
});