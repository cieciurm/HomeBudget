(function (window, angular, undefined) {
    var app = angular.module("homeApp", []);

    app.controller("homeController", ["$scope", function($scope) {
        $scope.Home = "test";
    }]);

})(window, angular, undefined);