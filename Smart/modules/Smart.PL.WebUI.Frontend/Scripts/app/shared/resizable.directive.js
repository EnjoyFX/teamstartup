(function (angular) {
    angular
        .module('homeModule')
        .directive('resizable', resizableDirective);

    resizableDirective.$inject = [ '$window' ];

    function resizableDirective ($window) {
        return function ($scope) {
            $scope.initializeWindowSize = function () {
                $scope.windowHeight = $window.innerHeight;
                $scope.windowWidth = $window.innerWidth;
            };
            $scope.initializeWindowSize();
            return angular.element($window).bind('resize', function () {
                $scope.initializeWindowSize();
                $scope.controller('CarouselController').$apply();
                return $scope.$apply();
            });
        };
    }
})(angular);

