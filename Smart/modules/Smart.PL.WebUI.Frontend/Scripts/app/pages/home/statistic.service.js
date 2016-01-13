(function (angular) {

    angular
        .module("homeModule")
        .factory("statisticService", statisticService);

    function statisticService($http) {

        var service = {
            getStatistic: getStatistic
        };

        return service;

        function getStatistic() {
            var promise = $http.get("/Home/GetStatistic");
            return promise;
        }
    }

})(angular);