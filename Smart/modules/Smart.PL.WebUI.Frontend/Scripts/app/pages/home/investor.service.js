(function (angular) {

    angular
        .module("homeModule")
        .service("investorService", investorService);

    function investorService($http) {
        this.getNotable = function () {
            var promise = $http({
                method: "GET",
                url: "/Home/GetNotableInvestors",
            });
            return promise;
        };
    }

})(angular);