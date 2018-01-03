'use strict';

angular.
    module('creditApp').
    component('creditList', {
        template: `

          <h1>Kredi Kontrol Sistemi: </h1>
          <div class ="form-inline">

          <input type="text" ng-model="$ctrl.age" placeholder="please enter age..." class ="form-control  btn-warning">
          <input type="button"  ng-click="$ctrl.checkCreditWithAge()" value="Kontrol" class="btn btn-success">

          </div>
          <div ng-if="$ctrl.myData"><h2>Kredi Hakkınız: </h2>
          <div class ="alert alert-success" role="alert">Kredi Hakkınız : <strong>{{' '+$ctrl.myData.value}}</strong></div>
          </div>
          `,
        controller: ['$http', function PhoneListController($http) {

            var vm = this;

            vm.checkCreditWithAge = function () {

                $http.get('/api/user/' + vm.age)
                    .then(function successCallback(response) {
                        vm.myData = {
                            value: ''
                        };
                        vm.myData.value = response.data.value;
                        
                    }, function errorCallback(response) {
                        console.log(response.error);
                    });

            };
        }]
    });