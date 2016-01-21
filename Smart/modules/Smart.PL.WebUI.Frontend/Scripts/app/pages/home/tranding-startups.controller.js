(function (angular) {

    angular
        .module("homeModule")
        .controller("TrandingStartupsController", TrandingStartupsController);

    TrandingStartupsController.$inject = ['$scope', 'trandingStartupsService'];

    function TrandingStartupsController($scope, trandingStartupsService) {
        var vm = this;

        vm.startups = [];

        activate();

        function activate() {

            trandingStartupsService.getTrandingStartups()
                .then(function (response) {
                    $scope.$applyAsync(function () {
                        vm.startups = response.data.startups;
                    });
                }, function (response) {
                    console.log("[tranding-startups.controller] trandingStartupsService.getTrandingStartups() failed");
                });
        }

    }

})(angular);