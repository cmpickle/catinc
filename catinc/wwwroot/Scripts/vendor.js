(function() {
    var app = angular.module("vendor", ['store']);
    
    app.controller('VendorController', [ '$http',  function($http) {
        let vendor = this;
        vendor.vendorName = {};
        // this.products = gems;

        $http.get('/api/UserAPI/getVendor').then(function(data) {
            vendor.vendorName = data.data.VendorName;
        });
    }]);

    // app.service("VendorService", function ($http) {
    //     this.getVendorName = function () {
    //         return $http.get('/api/UserAPI/getVendor');
    //     };
    // });

    // app.controller("VendorController", function ($scope, VendorService) {
    //     $scope.divVendorName = false;
    //     GetVendorName();
    //     function GetVendorName() {
    //         var getData = VendorService.getVendorName();
    //         getData.then(function (name) {
    //             $scope.vendorName = name.data;
    //         }, function () {
    //             alert('Error in getting records');
    //         });
    //     };

    //     this.getVendor = function() {
    //         return $scope.vendorName;
    //     };
    // });
})();