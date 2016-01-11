(function (angular, $) {

    angular
        .module("homeModule")
        .factory("startupMarketService", startupMarketService);

    function startupMarketService() {

        var service = {
            getMostPopular: getMostPopular
        };

        return service;

        function getMostPopular() {
            var promise = $.ajax({
                type: "GET",
                dataType: "json",
                url: "/Home/GetStartupMarkets"
            });
            return promise;
        }
    }

})(angular, $);