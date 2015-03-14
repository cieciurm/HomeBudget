(function (window, angular, undefined) {
    var app = angular.module("examplesApp", []);

    app.controller("examplesController", ["$scope", "$http", function ($scope, $http) {
        $scope.title = "Strona pozwalająca na sprawdzenie pooprawności działania podstawowych usług";

        $scope.logic =
        {
            getCamelCaseObject: function () {
                $http.get("/examples/TestCamelcase")
                    .success(function (data) {
                        console.log(data);
                        $scope.model = data;
                        alert("Wykonano poprawno! Wynik zobacz w konsoli!");
                    });
            },
            checkModelBinding: function () {
                $http.post("/examples/TestCamelcaseBinding", $scope.model)
                    .success(function (data) {
                        console.log(data);
                        alert("Mapowanie wykonane poprawnie");
                    });
            },
            sendSimpleString : function() {
                $http.post("/examples/TestStringBinding", "Simple string value")
                  .success(function (data) {
                      console.log(data);
                      alert("Mapowanie wykonane poprawnie");
                  });
            }


        }


    }]);

})(window, angular, undefined);