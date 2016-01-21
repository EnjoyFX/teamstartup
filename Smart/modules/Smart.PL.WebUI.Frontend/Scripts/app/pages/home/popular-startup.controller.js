(function (angular) {

    angular
        .module("homeModule")
        .controller("PopularStartupsController", PopularStartupsController);

    PopularStartupsController.$inject = ['$scope', 'popularStartupsService'];

    function PopularStartupsController($scope, popularStartupsService) {
        var vm = this;

        vm.startups = [];

        activate();

        function activate() {

            popularStartupsService.getPopularStartups()
                .then(function (response) {
                    $scope.$applyAsync(function () {
                        vm.startups = response.data.startups;
                    });
                }, function (response) {
                    console.log("[popular-startups.controller] popularStartupsService.getPopularStartups() failed");
                });
        }

    }

})(angular);