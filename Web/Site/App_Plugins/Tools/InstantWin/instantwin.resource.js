function InstantWinResource($http) {
    return {
        getPrizes: function () {
            return $http(
                {
                    method: 'GET',
                    url: "/umbraco/backoffice/tools/instantwin/getprizes",
                    headers: {
                        'Content-Type': 'application/json'
                    }
                })
                .then(
                    function (response) {
                        if (response) {
                            return response;
                        } else {
                            let apiResult = {
                                Success: false,
                                Data: {},
                                Message: "No data received"
                            };
                            return apiResult;
                        }
                    },
                    function (error) {
                        let apiResult = {
                            Success: false,
                            Data: error.data,
                            Message: "An http error occured"
                        };
                        return apiResult;
                    }
                );
        },
        getLimitOptions: function () {
            return $http(
                {
                    method: 'GET',
                    url: "/umbraco/backoffice/tools/instantwin/getlimitoptions",
                    headers: {
                        'Content-Type': 'application/json'
                    }
                })
                .then(
                    function (response) {
                        if (response) {
                            return response;
                        } else {
                            let apiResult = {
                                Success: false,
                                Data: {},
                                Message: "No data received"
                            };
                            return apiResult;
                        }
                    },
                    function (error) {
                        let apiResult = {
                            Success: false,
                            Data: error.data,
                            Message: "An http error occured"
                        };
                        return apiResult;
                    }
                );
        },
        generateMoments: function () {
            return $http(
                {
                    method: 'POST',
                    url: "/umbraco/backoffice/tools/instantwin/generate",
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    transformRequest: function (data) {
                        var formData = new FormData();
                        formData.append("file", data.file);
                        return formData;
                    },
                    data: request
                })
            .then(function (response) {
                if (response) {
                    return response.data;
                } else {
                    let apiResult = {
                        isSuccessful: false,
                        data: {},
                        message: "No reponse from the server"
                    };
                    return apiResult;
                }
            },
            function (error) {
                let apiResult = {
                    isSuccessful: false,
                    data: error.data,
                    message: "File could not be sent"
                };
                return apiResult;
                }
            );
        }
    };
}

angular.module("umbraco.resources").factory(
    "instantWinResource",
    InstantWinResource);