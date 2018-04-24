(function() {
    // angular.bootstrap(vendorName, ['app']);
    var app = angular.module("store", []);
    // var app = angular.module("app", []);

    app.service("ProductService", function ($http) {
        this.getProducts = function () {
            return $http.get('/api/productapi');
        };
    });

    app.controller('ProductController', [ '$http',  function($http) {
        let product = this;
        product.vendorName = {};
        // this.products = gems;

        $http.get('/api/UserAPI/getVendor').then(function(data) {
            product.vendorName = data.data.vendorName;
        });

        let products = this;

        $http.get('/api/ProductAPI').then(function(data) {
            products = data.data;
        });
    }]);

    // app.controller("ProductController", function ($scope, ProductService, VendorService) {
    //     $scope.divProduct = false;
    //     GetAllProducts();
    //     function GetAllProducts() {
    //         var getData = ProductService.getProducts();
    //         getData.then(function (product) {
    //             $scope.products = product.data;
    //         }, function () {
    //             alert('Error in getting records');
    //         });
    //     };

    //     GetVendorName();
    //     function GetVendorName() {
    //         var getData = VendorService.getVendorName();
    //         getData.then(function (name) {
    //             $scope.vendorName = name.data;
    //         }, function () {
    //             alert('Error in getting records');
    //         });
    //     };
    // });
})();