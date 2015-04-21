WMCBApp.controller('IndexCtrl', ["$scope", "wmcbService", function ($scope, wmcbService){
    $scope.latestNewsFeed = "";
    wmcbService.getLatestNewsFeed().then(function (data) {
        $scope.latestNewsFeed = data;
    });
}]);