function WonFilter() {

    return function (item) {

        return item ? 'Already Won' : 'Not Yet Won';

    };
}

var app = angular.module('umbraco.filters');
app.filter('wonfilter', WonFilter); 