(function (angular, $) {

    angular
        .module("homeModule")
        .factory("jobMarketService", jobMarketService);

    function jobMarketService() {

        var service = {
            getMostPopular: getMostPopular
        };

        return service;

        function getMostPopular() {
            var promise = $.ajax({
                type: "GET",
                dataType: "json",
                url: "/Home/GetMostPopularJobMarkets"
            });
            return promise;
        }
    }

})(angular, $);