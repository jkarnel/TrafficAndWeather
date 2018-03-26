$(function () {
    $("#countries").on("change", event => {
        $.ajax({
            url: '/WT/GetTowns',
            data: {
                countryId: event.target.value
            },
            success: (data) => {
                let $towns = $("#towns");
                $towns.empty();
                for (let i = 0; i < data.length; i++) {
                    if (data[i].selected) {
                        $towns.append(`<option selected='selected' value='${data[i].value}'>${data[i].text}</option>`);
                    }
                    else {
                        $towns.append(`<option value='${data[i].value}'>${data[i].text}</option>`);
                    }
                }
                $towns.change();
            },
        });
    });

    $("#towns").on("change", event => {
        let countryId = event.target.value;
        $.ajax({
            url: '/WT/GetWeatherViewPartial',
            data: {
                regionCode: countryId
            },
            success: (html) => {
                $("#weather").replaceWith(html);
            },
        });
        $.ajax({
            url: '/WT/GetTrafficViewPartial',
            data: {
                regionCode: countryId
            },
            success: (html) => {
                $("#traffic").replaceWith(html);
            },
        });
    });
});