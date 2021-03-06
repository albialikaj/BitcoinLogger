﻿$(document).ready(function () {
    $('#BitcoinPricelistTable').DataTable(
        {
            searching: false,
            ordering: true
        }
    );


    $(".c_sign").text("$");
    var exchange_rate = 1; //init

    //get exchange_rate for usd
    $.ajax({
        url: "https://api.exchangeratesapi.io/latest?symbols=USD",
        type: "GET",
        success: function (result) {
            console.log(result);

            var nomisma = result["rates"];

            exchange_rate = nomisma["USD"];
            console.log("Exchange rate is " + exchange_rate);

        },
        error: function (error) {
            console.log(error);
        }
    })







    $("#currency").change(function () {
        var current_currency = $("#currency").val();

        $(".price").each(function () {

            var price = $(this).text();

            if (current_currency == 'usd') {
                var usd_price = convertPriceToUSD(price);
                $(this).text(usd_price.toFixed(2));
                $(".c_sign").text("$");
            } else if (current_currency == 'euro') {
                var euro_price = convertPriceToEUR(price);
                $(this).text(euro_price.toFixed(2));
                $(".c_sign").text("€");
            }


        });
    });





    function convertPriceToUSD(amount) {
        return amount * exchange_rate;
    }

    function convertPriceToEUR(amount) {
        return amount / exchange_rate;
    }




});