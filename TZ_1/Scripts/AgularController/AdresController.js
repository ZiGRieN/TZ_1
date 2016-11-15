/*{{adr.Country}}</td>
<td>{{adr.City}}</td>
<td>{{adr.Street}}</td>
<td>{{adr.House}}</td>
<td>{{adr.Indeks}}</td>
<td>{{adr.Data}}*/

    var app = angular.module('AdresApp', []);
    app.controller('HomeController', function ($scope, AdresService) {
    AdresService.getAdres().success(function (adr) {
        $scope.adreses = adr;
 
    }); 
});
app.factory('AdresService', ['$http',function ($http) {
    var AdresService = {}
    AdresService.getAdres = function () {
        return $http.get('/Home/GetAdres');
    }
    return AdresService;
}]);
