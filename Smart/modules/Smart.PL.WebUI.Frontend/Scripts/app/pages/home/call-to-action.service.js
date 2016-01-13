(function (angular) {

    angular
        .module("homeModule")
        .factory("callToActionService", callToActionService);

    function callToActionService($http) {

        var service = {
            getActionDescription: getActionDescription
        };

        return service;

        function getActionDescription() {
            var promise = $http.get("/Home/getActionDescription");
            return promise;
        }
    }

})(angular);