(function (angular) {

    angular
        .module("homeModule")
        .factory("trandingStartupsService", trandingStartupsService);

    function trandingStartupsService($http) {

        var service = {
            getTrandingStartups: getTrandingStartups
        };

        return service;

        function getTrandingStartups() {
            var promise = $http.get("/Home/GetTrandingStartups");
            return promise;
        }
    }

})(angular);