(function() {
    var app = angular.module("vendor", ['store']);
    
    app.controller('VendorController', [ '$http',  function($http) {
        let vendor = this;
        vendor.vendorName = {};

        $http.get('/api/UserAPI/getVendor').then(function(data) {
            vendor.vendorName = data.data.VendorName;
        });
    }]);
})();