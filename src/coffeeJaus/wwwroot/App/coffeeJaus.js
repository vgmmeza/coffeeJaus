(function (angular) {
    'use strict';

    angular.module('app',
        [
            'ui.bootstrap',
            'ngRoute',
        ])
        .config([
            '$routeProvider', '$locationProvider', function ($routeProvider) {
                $routeProvider
               .when('/', {
                   templateUrl: '/Views/home.html',
                   title: 'Home'
               });

                $routeProvider.otherwise({
                    redirectTo: '/'
                });

            }
        ]);

})(window.angular);

(function (angular) {
    'use strict';

    angular.module('app.controllers', [])
        .controller('unitCtrl',
            function ($scope, alerts, $routeParams, toastr, $uibModal, $http) {

                $scope.ShowMessage = function (message) {

                };

            });

})(window.angular);