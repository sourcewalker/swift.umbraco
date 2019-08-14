function InstantWinController(
    $scope,
    instantWinService,
    notificationsService)
 {

    $scope.fileSelected = function (files) {
        $scope.file = files;
    };

    $scope.generate = function () {
        if (!$scope.isGenerating) {
            if ($scope.file) {
                $scope.isGenerating = true;
                instantWinService.generateMoments($scope.file)
                    .then(function (response) {
                        if (response && response.IsSuccessful) {
                            notificationsService.success(
                                "Success",
                                "Generation status: " + response.Message +
                                ", Number: " + response.Data.GeneratedNumber);
                        }
                        else if (response) {
                            notificationsService.error(
                                "Error",
                                "Error from server: " + response.Message);
                        }
                        else {
                            notificationsService.error(
                                "Error",
                                "No response from server");
                        }
                        $scope.isGenerating = false;
                    },
                    function (error) {
                        notificationsService.error(
                            "Error",
                            "Instant win generation failed: " + error.message);
                        $scope.isGenerating = false;
                    });
            } else {
                notificationsService.error(
                    "Error",
                    "Please enter at least one number");
                $scope.isGenerating = false;
            }
        }
    };

    $scope.file = false;
    $scope.isGenerating = false;
}

angular.module('umbraco').controller(
    "instantwin.controller",
    InstantWinController);