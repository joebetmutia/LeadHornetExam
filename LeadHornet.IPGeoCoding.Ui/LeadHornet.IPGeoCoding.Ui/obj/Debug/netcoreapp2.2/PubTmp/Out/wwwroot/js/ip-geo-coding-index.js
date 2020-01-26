var ipGeoCodingModule = (function () {

    function getUserIpAddress(callBack) {
        $.getJSON("https://jsonip.com/?callback=?", function (data) {
            callBack(data)
        });
    }

    function init() {

    }

    return {
        init: init,
        getUserIpAddress: function (callBack) {
            getUserIpAddress(callBack)
        }
    }

}());

$(document).ready(function () {
    ipGeoCodingModule.init();
})