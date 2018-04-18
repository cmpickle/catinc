(function(){
    var app = angular.module("store", []);

    app.service("ProductService", function ($http) {
        //get All Products
        this.getProducts = function () {
            return $http.get('/api/productapi');
        };
    });

    app.controller("ProductController", function ($scope, ProductService) {
        $scope.divProduct = false;
        GetAllProducts();
        function GetAllProducts() {
            // alert('home');
            var getData = ProductService.getProducts();
            getData.then(function (product) {
                $scope.products = product.data;
            }, function () {
                alert('Error in getting records');
            });
        }
    });
})();