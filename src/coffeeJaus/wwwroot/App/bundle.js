var app = angular.module("app", ['ui.bootstrap', 'ngRoute']);

(function (angular) {
    'use strict';

    app.config([
            '$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
                $routeProvider
               .when('/', {
                   templateUrl: '/Views/home.html',
                   title: 'Home'
               }).when('/Unit/New', {
                   templateUrl: '/Views/unitNew.html',
                   title: 'New Unit'
               });

                $routeProvider.otherwise({
                    redirectTo: '/'
                });

                $locationProvider.html5Mode(true);
            }
        ]);

})(window.angular);

var unit = {
    Name: '',
    Abrev : ''
};
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