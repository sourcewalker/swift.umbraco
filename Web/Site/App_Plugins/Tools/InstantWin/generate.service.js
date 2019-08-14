function InstantWinService($http) {
    return {
        generateMoments: function (file) {
            var request = {
                file: file
            };
            return $http(
                {
                    method: 'POST',
                    url: "backoffice/api/InstantWinApi/Generate",
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
    "instantWinService",
    InstantWinService);