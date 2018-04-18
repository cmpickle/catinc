(function(){
    // var app = angular.module('store', []);
    var app = angular.module('store').factory('Products', function($http) {
        var Products = function(data) {
            angular.extend(this, data);
        }

        Products.getAll = function() {
            return $http.get('api/productapi').then(function(repsonce) {
                var products = [];
                for(var i = 0; i < responce.data.length; ++i) {
                    products.push(new Product(responce.data[i]));
                }
                return products;
            });
        }
    });

    app.controller('ProductController', function(Products) {
        this.products = Products.getAll();

        this.Test = "Hello World";
    });

})();