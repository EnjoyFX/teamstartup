(function (angular) {

    angular
        .module("homeModule")
        .controller("CallToActionController", CallToActionController);

    CallToActionController.$inject = ['$scope', 'callToActionService'];

    function CallToActionController($scope, callToActionService) {
        var vm = this;

        vm.descriptions = {};

        activate();

        function activate() {

            callToActionService.getActionDescription()
                .then(function (response) {
                    $scope.$applyAsync(function () {
                        vm.descriptions = response.data.descriptions;
                    });
                }, function (response) {
                    console.log("[CallToActionController.controller] callToActionService.getActionDescription() failed");
                });
        }

    }

})(angular);