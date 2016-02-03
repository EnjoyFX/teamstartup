(function (angular) {
    angular
	.module("homeModule")
	.controller("NotableInvestorController", NotableInvestorController);

    NotableInvestorController.$inject = ['$scope', 'investorService', 'slicingService'];

    function NotableInvestorController($scope, investorService, slicingService) {
        var vm = this;

        //vm.investors = [];
        vm.interval = 1000;
        vm.noWrapSlides = false;
        vm.slides = [];
        var currIndex = 0;

        activate();



        function activate() {

            investorService.getNotableInvestors()
                .then(
                    function (response) {
                        $scope.$applyAsync(
                            function () {
                                var investors = response.data.notableInvestors;
                                addSlides(slicingService.sliceSlides(investors));
                            }
                        );
                    }
                    ,
                    function (response) {
                        console.log("[carousel.controller] investorService.getInvestors() failed");
                    }
                );
        }


        function addSlide(items) {
            vm.slides.push({
                items: items,
                id: currIndex++
            });
        };

        function addSlides(slides) {
            for (var i = 0 ; i < slides.length ; i++) {
                addSlide(slides[i]);
            }
        };




    };

})(angular);