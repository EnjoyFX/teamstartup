(function (angular) {

    angular
        .module("homeModule")
        .controller("TalentsController", TalentsController);

    TalentsController.$inject = ['$scope', 'talentService'];

    function TalentsController($scope, talentService) {
        var vm = this;

        vm.talents = [];

        activate();

        function activate() {

            talentService.getTalents()
                .then(function (response) {
                    $scope.$applyAsync(function () {
                        vm.talents = response.data.talents;
                    });
                }, function (response) {
                    console.log("[talents.controller] talentService.getTalents() failed");
                });
        }

    }

})(angular);