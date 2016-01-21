(function (angular) {

    angular
        .module("homeModule")
        .factory("popularStartupsService", popularStartupsService);

    function popularStartupsService($http) {

        var service = {
            getPopularStartups: getPopularStartups
        };

        return service;

        function getPopularStartups() {
            var promise = $http.get("/Home/GetPopularStartups");
            return promise;
        }
    }

})(angular);