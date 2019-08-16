function InstantWinController(
    $scope,
    instantWinResource,
    notificationsService)
 {

    $scope.init = function ()
    {
        instantWinResource.getLimitOptions()
            .then(
                function (response) {
                    if (response && response.Success) {
                        $scope.limitOptions = response.Data.LimitOptions;
                    }
                    else {
                        notificationsService.error(
                            "Error",
                            "Could not retrieve limit options: No response from server");
                    }
                },
                function (error) {
                    notificationsService.error(
                        "Error",
                        "Could not retrieve limit options: " + error.message);
                }
            );

        instantWinResource.getPrizes()
            .then(
                function (response) {
                    if (response && response.Success) {
                        $scope.prizes = response.Data.Prizes;
                    }
                    else {
                        notificationsService.error(
                            "Error",
                            "Could not retrieve prizes: No response from server");
                    }
                },
                function (error) {
                    notificationsService.error(
                        "Error",
                        "Could not retrieve prizes: " + error.message);
                }
            );
    };

    $scope.generate = function () {
        if (!$scope.isGenerating) {
            $scope.isGenerating = true;
            instantWinResource.generateMoments()
            .then(function (response) {
                if (response && response.Success) {
                    notificationsService.success(
                        "Success",
                        "Generation status: " + response.Message +
                        ", Number: " + response.Data.GeneratedNumber);
                    $scope.isGenerating = false;
                }
                else if (response) {
                    notificationsService.error(
                        "Error",
                        "Error from server: " + response.Message);
                    $scope.isGenerating = false;
                }
                else {
                    notificationsService.error(
                        "Error",
                        "No response from server");
                    $scope.isGenerating = false;
                }
            },
            function (error) {
                notificationsService.error(
                    "Error",
                    "Instant win generation failed: " + error.message);
                $scope.isGenerating = false;
            });
        }
    };

    $scope.isGenerating = false;
    $scope.buttonLabel = $scope.isGenerating ? 'Please wait...' : 'Generate';
    $scope.prizes = [];
    $scope.limitOptions = [];
}

angular.module('umbraco').controller(
    "instantwin.controller",
    InstantWinController);