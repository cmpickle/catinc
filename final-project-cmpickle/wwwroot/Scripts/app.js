(function() {
    // angular.bootstrap(vendorName, ['app']);
    var store = angular.module("store", []);
    // var app = angular.module("app", []);

    store.service("ProductService", function ($http) {
        this.getProducts = function () {
            return $http.get('/api/productapi');
        };
    });

    store.service("VendorService", function ($http) {
        this.getVendorName = function () {
            return $http.get('/api/UserAPI/getVendor');
        };
    });

    store.controller("ProductController", function ($scope, ProductService, VendorService) {
        $scope.divProduct = false;
        GetAllProducts();
        function GetAllProducts() {
            var getData = ProductService.getProducts();
            getData.then(function (product) {
                $scope.products = product.data;
            }, function () {
                alert('Error in getting records');
            });
        };

        GetVendorName();
        function GetVendorName() {
            var getData = VendorService.getVendorName();
            getData.then(function (name) {
                $scope.vendorName = name.data;
            }, function () {
                alert('Error in getting records');
            });
        };
    });

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