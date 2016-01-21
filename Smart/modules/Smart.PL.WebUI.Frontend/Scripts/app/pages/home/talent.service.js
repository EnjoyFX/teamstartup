(function (angular) {

    angular
        .module("homeModule")
        .factory("talentService", talentService);

    function talentService($http) {

        var service = {
            getTalents: getTalents
        };

        return service;

        function getTalents() {
            var promise = $http.get("/Home/GetTalents");
            return promise;
        }
    }

})(angular);