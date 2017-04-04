(function (angular) {
    'use strict';

    app.controller('NewUnitCtrl',
            function ($scope, $http, $location) {

                $scope.unit = unit;

                $scope.Save = function () {
                    console.log($scope.unit);
                };

                $scope.Cancel = function () {
                    $location.path('/');
                };

            });

})(window.angular);