(function() {
    var app = angular.module("store", []);

    app.service("ProductService", function ($http) {
        this.getProducts = function () {
            return $http.get('/api/productapi/getall');
        };
    });

    app.controller('ProductController', [ '$http',  function($http) {
        let product = this;
        product.vendorName = {};

        $http.get('/api/UserAPI/getVendor').then(function(data) {
            product.vendorName = data.data.VendorName;
        });

        product.products = [];

        $http.get('/api/ProductAPI/GetAll').then(function(data) {
            product.products = data.data;
        });
    }]);
})();