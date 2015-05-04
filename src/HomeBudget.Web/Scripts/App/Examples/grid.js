(function (window, angular, undefined) {
    var app = angular.module("examplesApp", ['ngGrid']);

    app.controller("gridExampleController", ["$scope", "$http", function ($scope, $http) {
        $scope.myData = [{value: "122,00", expenseDate:'13.12.2015', category : 'Piwo', comment: 'Rudobrody mag'}];

        $scope.gridOptions = {
            data: 'myData',
            columnDefs: [{ field: 'value', displayName: 'Kwota' },
                { field: 'expenseDate', displayName: 'Data' },
                { field: 'category', displayName: 'Kategoria' },
                {field: 'comment', displayName: 'Komentarz'}
            ]
        };

    }]);

})(window, angular, undefined);