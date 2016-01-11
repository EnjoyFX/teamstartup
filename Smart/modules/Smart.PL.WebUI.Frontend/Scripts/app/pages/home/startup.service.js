(function (angular) {

    angular
        .module("homeModule")
        .factory("startupService", startupService);

    function startupService($http) {

        var service = {
            getTopRated: getTopRated
        };

        return service;

        function getTopRated() {
            var promise = $http.get("/Home/GetTopRatedStartups");
            return promise;
        }
    }

})(angular);