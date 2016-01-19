(function (angular) {

    angular
        .module("homeModule")
        .controller("StatisticController", StatisticController);

    StatisticController.$inject = ['$scope', 'statisticService'];

    function StatisticController($scope, statisticService) {
        var vm = this;

        vm.statisticLeft = [];
        vm.statisticRight = [];

        activate();

        function activate() {
            
            statisticService.getStatistic()
                .then(function (response) {
                    $scope.$applyAsync(function () {
                        var arr = response.data.statistic;
                        vm.statisticLeft = arr.slice(0, arr.length/2);
                        vm.statisticRight = arr.slice(arr.length / 2 - 1, arr.length - 1);
                    });
                }, function (response) {
                    console.log("[statistic.controller] statisticService.getStatistic() failed");
                });
        }

    }

})(angular);