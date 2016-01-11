(function (angular) {

    angular
        .module("homeModule")
        .controller("PresentationBarController", PresentationBarController);

    PresentationBarController.$inject = ['$scope', 'startupMarketService', 'jobMarketService', 'investorService', 'startupService'];

    function PresentationBarController($scope, startupMarketService, jobMarketService, investorService, startupService) {
        var vm = this;

		vm.startupMarkets = [];
		vm.jobMarkets = [];
		vm.notableInvestors = [];
		vm.topRatedStartups = [];

		activate();

		function activate() {
		    startupMarketService.getMostPopular()
                .done(function (data) {
                    //Array.prototype.push.apply($scope.startupMarkets, data.startupMarkets);
                    $scope.$applyAsync(function () {
                        vm.startupMarkets = data.startupMarkets;
                    });
                })
                .fail(function () {
                    console.log("[presentation-bar.controller] startupMarketService.getMostPopular() failed");
                });

		    jobMarketService.getMostPopular()
                .done(function (data) {
                    //Array.prototype.push.apply($scope.startupMarkets, data.startupMarkets);
                    $scope.$applyAsync(function () {
                        vm.jobMarkets = data.jobMarkets;
                    });
                })
                .fail(function () {
                    console.log("[presentation-bar.controller] jobMarketService.getMostPopular() failed");
                });

		    investorService.getNotable()
                .then(function (response) {
                    $scope.$applyAsync(function () {
                        vm.notableInvestors = response.data.notableInvestors;
                    });
                }, function (response) {
                    console.log("[presentation-bar.controller] investorService.getNotable() failed");
                });

		    startupService.getTopRated()
                .then(function (response) {
                    $scope.$applyAsync(function () {
                        vm.topRatedStartups = response.data.topRatedStartups;
                    });
                }, function (response) {
                    console.log("[presentation-bar.controller] startupService.getTopRated() failed");
                });
		}

	}

})(angular);