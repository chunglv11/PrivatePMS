var urlGetLanguage = '/Home/GetLanguage';
var urlGetCurrency = '/Home/GetCurrency';
var urlGetData = '/Home/GetRoomAvailable';
var urlDetailRoomType = '/Home/DetailRoomType';
var urlSaveDataBooking = '/Home/SaveInfoBooking'

app.controller("controller", ['$scope', '$http', '$timeout', 'helper',
    function ($scope, $http, $timeout, helper) {
        $scope.lang = 'vi';
        $scope.currency = 'VND';
        $scope.params = {};
        $scope.datas = [];
        $scope.dataRoomBook = [];
        $scope.totalRoomBook = 0;
        $scope.totalPriceRoom = [];

        $scope.rangeArr = function (number) {
            var arr = [];
            for (var i = 0; i < number; i++) {
                arr.push(i);
            }
            return arr;
        }
        $scope.rangeArr2 = function (number) {
            var arr = [];
            for (var i = 0; i <= number; i++) {
                arr.push(i);
            }
            return arr;
        }
        $scope.getData = function () {
            $("#loader").css("display", "block")
            $http({
                url: urlGetData,
                method: 'GET',
                params: {
                    hotelCode: $scope.params.hotelCode,
                    fromDate: $scope.params.fromDate,
                    toDate: $scope.params.toDate,
                    child: $scope.params.child,
                    adults: $scope.params.adults,
                    /*infant: $scope.params.infant,*/
                    lang: $scope.lang,
                    currency: $scope.currency
                }
            }).then(function success(respone) {
                $("#loader").css("display", "none")
                $scope.datas = JSON.parse(respone.data);
                console.log($scope.datas)
            }, function error(respone) {
                $("#loader").css("display", "none")
            });

        }
        $scope.initpage = function () {
            var lang = helper.findGetParameter("lang");
            var currency = helper.findGetParameter("currency");
            $scope.params.child = helper.findGetParameter("child");
            $scope.params.adults = helper.findGetParameter("adults");
            //update infant
            /*var infant = helper.findGetParameter("infant");*/
            $scope.params.toDate = helper.findGetParameter("toDate");
            $scope.params.fromDate = helper.findGetParameter("fromDate");
            $scope.params.hotelCode = helper.findGetParameter("hotelCode");
            $scope.params.hotelKey = helper.findGetParameter("hotelKey");
            if (lang != null)
                $scope.lang = lang;
            //if (infant == null) {
            //    $scope.params.infant = 0;
            //}
            $scope.params.lang = $scope.lang
            if (currency != null)
                $scope.currency = currency;
            $scope.getData()
        };
        $scope.initpage();
        $scope.getLanguage = function () {
            $http({
                url: urlGetLanguage,
                method: 'GET'
            }).then(function success(respone) {
                $scope.languages = respone.data;
            }, function error(respone) {
            });
        };
        $scope.getCurrency = function () {
            $http({
                url: urlGetCurrency,
                method: 'GET'
            }).then(function success(respone) {
                $scope.currencies = respone.data;
            }, function error(respone) {
            });
        };
        $scope.getLanguage();
        $scope.getCurrency();
        //$scope.changeSearch = function () {
        //    var newLink = "/?hotelKey=" + $scope.params.hotelKey +
        //        "&hotelCode=" + $scope.params.hotelCode +
        //        "&lang=" + $scope.lang +
        //        "&currency=" + $scope.currency;
        //    location.href = newLink;
        //}

        //Fix language 03/03/2022
        $scope.changeSearch = function () {
            var newLink = "/Home/SelectDate?hotelKey=" + $scope.params.hotelKey +
                "&hotelCode=" + $scope.params.hotelCode +
                "&lang=" + $scope.lang +
                "&currency=" + $scope.currency;
            console.log(newLink);
            location.href = newLink;
        }
        $scope.changeLanguage = function (key) {
            $scope.lang = key;
            $scope.loadChangePage();
        };
        $scope.changeCurrency = function (currencyCode) {
            $scope.currency = currencyCode;
            $scope.loadChangePage();
        };
        $scope.loadChangePage = function () {
            var newLink = "/Home/SelectRoom?hotelKey=" + $scope.params.hotelKey +
                "&hotelCode=" + $scope.params.hotelCode +
                "&fromDate=" + $scope.params.fromDate +
                "&toDate=" + $scope.params.toDate +
                "&adults=" + $scope.params.adults +
                "&child=" + $scope.params.child +
                //update infant
                /*"&infant=" + $scope.params.infant +*/
                "&lang=" + $scope.lang +
                "&currency=" + $scope.currency;
            location.href = newLink;
        }
        $scope.showDetailRoom = function (roomTypeId) {
            $("#loader").css("display", "block")
            $http({
                url: urlDetailRoomType,
                method: 'GET',
                params: {
                    id: roomTypeId
                }
            }).then(function success(respone) {
                $("#loader").css("display", "none")
                $scope.detailRoom = respone.data;
                console.log($scope.detailRoom)
                $timeout(function () {
                    currentSlide(1)
                }, 100)
                $("#ui-id-2").html($scope.detailRoom.roomType.RoomTypeName)
                $('.detail-info-room').dialog('open');
                $('.ui-widget-overlay').css("background", "rgba(0, 0, 0, 0.7)")
            }, function error(respone) {
                $("#loader").css("display", "none")
            });
        }
        $scope.calRoomChoose = function () {
            var arrData = [];
            var totalRoomBook = 0;
            var totalPriceRoom = 0;
            var totalPriceRoomExchangeRate = 0;

            $scope.datas.forEach(x => {
                var totalRoomChoose = 0;
                if (x.PromotionHomes.findIndex(promotion => promotion.ChooseRoom > 0) >= 0)
                    arrData.push(x);
                if (x.PromotionHomes.length > 1) {
                    x.PromotionHomes.forEach(promotion => {
                        if (promotion.ChooseRoom > 0) {
                            totalRoomChoose += promotion.ChooseRoom;
                            totalPriceRoom += promotion.ChooseRoom * promotion.TotalPriceAfterPromotion;
                            if ($scope.currency != 'VND') {
                                totalPriceRoomExchangeRate += promotion.ChooseRoom * promotion.TotalPriceAfterPromotionExchangeRate;
                            }
                            if (x.NumberAvailable < totalRoomChoose) {
                                x.PromotionHomes.forEach(promotion => {
                                    promotion.ChooseRoom = 0;
                                    totalRoomChoose = 0;
                                    totalPriceRoom = 0;
                                    if ($scope.currency != 'VND') {
                                        totalPriceRoomExchangeRate = 0;
                                    }
                                });
                                if ($scope.lang == 'vi') {
                                    swal({
                                        title: "Thông báo",
                                        text: `Tổng số phòng ${x.RoomTypeName}  phải nhỏ hơn hoặc bằng  ${x.NumberAvailable}.`,
                                        icon: "warning",
                                        dangerMode: true,
                                    })
                                } else {
                                    swal({
                                        title: "Notification",
                                        text: `total number of ${x.RoomTypeName} rooms must be less than or equal to ${x.NumberAvailable}.`,
                                        icon: "warning",
                                        dangerMode: true,
                                    })

                                }
                            }
                        };
                    });
                } else {
                    x.PromotionHomes.forEach(promotion => {
                        if (promotion.ChooseRoom > 0) {

                            totalRoomChoose += promotion.ChooseRoom; // roomType
                            totalPriceRoom += promotion.ChooseRoom * promotion.TotalPriceAfterPromotion;

                            if ($scope.currency != 'VND') {
                                totalPriceRoomExchangeRate += promotion.ChooseRoom * promotion.TotalPriceAfterPromotionExchangeRate;
                            }
                        };
                    });
                }

                x.TotalRoomChoose = totalRoomChoose;
                totalRoomBook += totalRoomChoose;
        
            });

            $scope.dataRoomBook = arrData;
            $scope.totalRoomBook = totalRoomBook;
            $scope.totalPriceRoom = totalPriceRoom;
            $scope.totalPriceRoomExchangeRate = totalPriceRoomExchangeRate;
        };
        $scope.Confirm = function () {
            $scope.params.currency = $scope.currency;

            var x1 = parseFloat($scope.params.child);
            var x2 = parseFloat($scope.params.adults);
            var total = x1 + x2;
            var room = parseInt($scope.totalRoomBook);
            var totalPriceRoom = 0;
            var totalPriceRoomExchangeRate = 0;
            var arrData = [];
            var totalRoomBook = 0;
            let maxPeople = 0;
            $scope.datas.forEach(x => {
                var totalRoomChoose = 0;
                if (x.PromotionHomes.findIndex(promotion => promotion.ChooseRoom > 0) >= 0)
                    arrData.push(x);
                x.PromotionHomes.forEach(promotion => {
                    if (promotion.ChooseRoom > 0) {
                        maxPeople += x.MaxPeople * promotion.ChooseRoom;
                        totalRoomChoose += promotion.ChooseRoom;
                        totalPriceRoom += promotion.ChooseRoom * promotion.TotalPriceAfterPromotion;
                        if ($scope.currency != 'VND')
                            totalPriceRoomExchangeRate += promotion.ChooseRoom * promotion.TotalPriceAfterPromotionExchangeRate;
                    };
                });
                x.TotalRoomChoose = totalRoomChoose;
                totalRoomBook += totalRoomChoose;
            });

            $scope.dataRoomBook = arrData;
            $scope.totalRoomBook = totalRoomBook;

            if (maxPeople < total) {
                if ($scope.lang == 'vi') {
                    swal({
                        title: "Thông báo",
                        text: "Bạn chưa chọn đủ số lượng phòng tương ứng số người !",
                        icon: "warning",
                        buttons: true,
                        dangerMode: true,
                    })
                        .then((willDelete) => {
                            if (willDelete) {
                                swal("Yêu cầu đặt phòng của bạn đã được xác nhận", {
                                    icon: "success",
                                }).then((willOK) => {
                                    if (willOK) {
                                        $http({
                                            url: urlSaveDataBooking,
                                            method: 'POST',
                                            data: {
                                                data: $scope.dataRoomBook,
                                                param: $scope.params
                                            }
                                        }).then(function success(respone) {
                                            $("#loader").css("display", "none")

                                            location.href = "/Home/Confirm?lang=" + $scope.lang +
                                                "&currency=" + $scope.currency;
                                        }, function error(respone) {
                                            $("#loader").css("display", "none");
                                        });
                                    }
                                })
                            } else {
                                swal.close();
                                $("#loader").css("display", "none");
                            }
                        });
                } else {
                    swal({
                        title: "Notification",
                        text: "You have not selected a sufficient number of rooms corresponding to the number of people !",
                        icon: "warning",
                        buttons: true,
                        dangerMode: true,
                    })
                        .then((willDelete) => {

                            if (willDelete) {
                                swal("Your booking request has been confirmed", {
                                    icon: "success",
                                }).then((willOK) => {
                                    if (willOK) {
                                        $http({
                                            url: urlSaveDataBooking,
                                            method: 'POST',
                                            data: {
                                                data: $scope.dataRoomBook,
                                                param: $scope.params
                                            }
                                        }).then(function success(respone) {
                                            $("#loader").css("display", "none")

                                            location.href = "/Home/Confirm?lang=" + $scope.lang +
                                                "&currency=" + $scope.currency;
                                        }, function error(respone) {
                                            $("#loader").css("display", "none");
                                        });
                                    }
                                })
                            } else {
                                swal.close();
                                $("#loader").css("display", "none");
                            }
                        });
                }
            }
            else {
                $http({
                    url: urlSaveDataBooking,
                    method: 'POST',
                    data: {
                        data: $scope.dataRoomBook,
                        param: $scope.params
                    }
                }).then(function success(respone) {
                    $("#loader").css("display", "none")
                    location.href = "/Home/Confirm?lang=" + $scope.lang +
                        "&currency=" + $scope.currency;
                }, function error(respone) {
                    $("#loader").css("display", "none");
                });
            }

        };

    }]);