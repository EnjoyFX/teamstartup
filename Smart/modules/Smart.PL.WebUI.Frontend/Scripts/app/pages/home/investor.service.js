(function (angular) {

    angular
        .module("homeModule")
        .factory("investorService", investorService);

    function investorService($http) {
        var service = {
            getNotableInvestors: getNotableInvestors
        };
        return service;

        function getNotableInvestors() {
            var promise = $http({
                method: "GET",
                url: "/Home/GetNotableInvestors",
            });
            return promise;
        };
    }


})(angular);