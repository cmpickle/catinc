(function() {
    angular.module("vendor", ['store', 'ngRoute'])
    .config(['$routeProvider', function ($routeProvider) {
      $routeProvider
        .when('/Product/:id', {
          templateUrl: 'wwwroot/templates/product.html'
        });
    }]);
    
    angular.module("vendor").controller('VendorController', [ '$http',  function($http) {
        let vendor = this;
        vendor.vendorName = {};

        $http.get('/api/UserAPI/getVendor').then(function(data) {
            vendor.vendorName = data.data.VendorName;
        });
    }]);
})();