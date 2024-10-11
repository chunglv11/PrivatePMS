var urlPut = "/Admin/PropertyProfile/Put"
var urlDetail = "/Admin/PropertyProfile/Detail"
var urlGetLanguage = "/Admin/Language/GetActive"

app.controller('controller', ['$scope', '$http', '$log', 'uiGridConstants', 'validate', 'notify',
    '$timeout',
    function ($scope, $http, $log, uiGridConstants, validate, notify, $timeout) {
        $scope.language = []
        $scope.languageChoose = 0;
        
        $scope.Put = function () {
            var v1 = validate.isNullOrEmptySingleShowError({ value: $scope.hotel.Name, key: 'Name' });
            var v2 = validate.isNullOrEmptySingleShowError({ value: $scope.hotel.Code, key: 'Code' })
            var v3 = validate.isNullOrEmptySingleShowError({ value: $scope.hotel.Email, key: 'Email' })
            var v4 = validate.isNullOrEmptySingleShowError({ value: $scope.hotel.Address, key: 'Address' })
            var v5 = validate.isNullOrEmptySingleShowError({ value: $scope.hotel.Phone, key: 'Phone' })
            if (v1 || v2 || v3 || v4 || v5) {
                notify.error('Giá trị không hợp lệ!')
                return
            }
            $("#loader").css("display", "block")
            $scope.hotel.Logo = $("#Logo").val();
            $scope.GetAdditionInfoMultiLanguage()
            $http({
                method: "POST",
                url: urlPut,
                data: $scope.hotel
            }).then(function success(respone) {
                $("#loader").css("display", "none")
                notify.success("Thành công")
            }, function error(respone) {
                $("#loader").css("display", "none")
                notify.error("Có lỗi sảy ra!")
            })
        }
        $scope.RefreshValidate = function () {
            $(".error").css("display", "none")
        }
        $scope.GetAdditionInfoMultiLanguage = function (index = -1) {
            if (index < 0)
                index = $scope.languageChoose
            var indexOld = $scope.hotel.hotelLanguages.findIndex(x => x.LanguageId == index);
            var objOld = $scope.hotel.hotelLanguages[indexOld]
            if (objOld != null) {
                objOld.Terms = CKEDITOR.instances.terms.getData()
                objOld.InforAccount = CKEDITOR.instances.infoAccountHotel.getData()
                objOld.Note = CKEDITOR.instances.noteHotel.getData()
                // Lưu các giá trị từ các trường mới
                objOld.Name = document.getElementById('hotel_Name').value;
                objOld.Code = document.getElementById('Code').value;
                objOld.Phone = document.getElementById('Phone').value;
                objOld.Hotline = document.getElementById('Hotline').value;
                objOld.Fax = document.getElementById('Fax').value;
                objOld.Email = document.getElementById('Email').value;
                objOld.Address = document.getElementById('Address').value;
                objOld.Facebook = document.getElementById('Facebook').value;
                objOld.Skyper = document.getElementById('Skyper').value;
                objOld.Google = document.getElementById('Google').value;
                objOld.Youtube = document.getElementById('Youtube').value;
                objOld.Website = document.getElementById('Website').value;
                objOld.Logo = document.getElementById('img-logo').value;
                $scope.hotel.Logo = objOld.Logo;
            }
        }
        $scope.SetAdditionInfoMultiLanguage = function (index) {
            if ($scope.hotel == null)
                return
            var indexNew = $scope.hotel.hotelLanguages.findIndex(x => x.LanguageId == index);
            var objNew = $scope.hotel.hotelLanguages[indexNew]
            if (objNew != null) {
                CKEDITOR.instances.terms.setData(objNew.Terms)
                CKEDITOR.instances.infoAccountHotel.setData(objNew.InforAccount)
                CKEDITOR.instances.noteHotel.setData(objNew.Note)
                // Hiển thị thêm các giá trị mới vào các trường tương ứng
                document.getElementById('hotel_Name').value = objNew.Name || '';              
                document.getElementById('Code').value = objNew.Code || '';
                document.getElementById('Phone').value = objNew.Phone || '';
                document.getElementById('Hotline').value = objNew.Hotline || '';
                document.getElementById('Fax').value = objNew.Fax || '';
                document.getElementById('Email').value = objNew.Email || '';
                document.getElementById('Address').value = objNew.Address || '';
                document.getElementById('Facebook').value = objNew.Facebook || '';
                document.getElementById('Skyper').value = objNew.Skyper || '';
                document.getElementById('Google').value = objNew.Google || '';
                document.getElementById('Youtube').value = objNew.Youtube || '';
                document.getElementById('Website').value = objNew.Website || '';
                document.getElementById('img-logo').value = objNew.Logo || '';
                $scope.hotel.Logo = objNew.Logo;
            }
        }
        $scope.ResetEditor = function () {
            CKEDITOR.instances.terms.setData('')
            CKEDITOR.instances.infoAccountHotel.setData('')
            CKEDITOR.instances.noteHotel.setData('')
        }
        $scope.$watch('languageChoose', function (newValue, oldValue) {
            if (isNaN(newValue) || newValue == 0) {
                // Nếu là ngôn ngữ mặc định
                $(".hotel_inhidden").show();  // Hiển thị các input có class 'hotel_inhidden'
                $(".hotel_hidden").hide();    // Ẩn các input có class 'hotel_hidden'
            } else {
                // Nếu là ngôn ngữ khác
                $(".hotel_inhidden").hide();  // Ẩn các input có class 'hotel_inhidden'
                $(".hotel_hidden").show();    // Hiển thị các input có class 'hotel_hidden'
            }
            if (newValue < 0)
                return
            if (oldValue > 0)
                $scope.GetAdditionInfoMultiLanguage(oldValue)
            $scope.SetAdditionInfoMultiLanguage(newValue)
        });
        

        if (CKEDITOR.env.ie && CKEDITOR.env.version < 9)
            CKEDITOR.tools.enableHtml5Elements(document);
        CKEDITOR.config.height = 300;
        CKEDITOR.config.width = 'auto';
        $scope.initSample = (function () {
            var wysiwygareaAvailable = isWysiwygareaAvailable(),
                isBBCodeBuiltIn = !!CKEDITOR.plugins.get('bbcode');

            return function () {
                var editorElement = CKEDITOR.document.getById('infoAccountHotel');
                var editorElement2 = CKEDITOR.document.getById('noteHotel');
                var editorElement3 = CKEDITOR.document.getById('terms');
                if (isBBCodeBuiltIn) {
                    editorElement.setHtml('');
                    editorElement2.setHtml('');
                    editorElement3.setHtml('');
                }
                if (wysiwygareaAvailable) {
                    CKEDITOR.replace('infoAccountHotel');
                    CKEDITOR.replace('noteHotel');
                    CKEDITOR.replace('terms');
                } else {
                    editorElement.setAttribute('contenteditable', 'true');
                    CKEDITOR.inline('infoAccountHotel');
                    editorElement2.setAttribute('contenteditable', 'true');
                    CKEDITOR.inline('noteHotel');
                    editorElement3.setAttribute('contenteditable', 'true');
                    CKEDITOR.inline('terms');
                }
            };

            function isWysiwygareaAvailable() {
                if (CKEDITOR.revision == ('%RE' + 'V%')) {
                    return true;
                }
                return !!CKEDITOR.plugins.get('wysiwygarea');
            }
        })();
        $scope.initSample()
        $scope.GetData = function () {
            $("#loader").css("display", "block")
            $http({
                url: urlDetail,
                method: "GET"
            }).then(function success(response) {
                $("#loader").css("display", "none")
                $scope.hotel = response.data
                // Thiết lập mặc định giá trị languageChoose là 0 (Default)
                $timeout(function () {
                    $scope.languageChoose = 0;
                }, 500);

                var idLanguageChoose = $scope.language[0].LanguageId
                $timeout(function () {
                    $scope.SetAdditionInfoMultiLanguage(idLanguageChoose);
                }, 500);
                $scope.languageChoose = idLanguageChoose
            }, function error(response) {
                $("#loader").css("display", "none")
            });
        }
        $scope.GetLanguage = function () {
            $http({
                url: urlGetLanguage,
                method: "GET"
            }).then(function success(response) {
                $scope.language = response.data;
                $scope.GetData()
            }, function error(response) {

            });
        }
        $scope.GetLanguage()
        

    }]);