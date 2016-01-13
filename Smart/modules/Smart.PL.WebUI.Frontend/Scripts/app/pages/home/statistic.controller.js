(function (angular) {

    angular
        .module("homeModule")
        .controller("StatisticController", StatisticController);

    StatisticController.$inject = ['$scope', 'statisticService'];

    function StatisticController($scope, statisticService) {
        var vm = this;

        vm.statistic = [];

        activate();

        function activate() {
            
            statisticService.getStatistic()
                .then(function (response) {
                    $scope.$applyAsync(function () {
                        vm.statistic = response.data.statistic;
                    });
                }, function (response) {
                    console.log("[statistic.controller] statisticService.getStatistic() failed");
                });
        }

    }

})(angular);