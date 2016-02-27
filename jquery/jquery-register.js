/// <reference path="jquery.min.js" />

//var main = function () {
//    var username = $('#username');
//    var fname = $('#fname');
//    var lname = $('#lname');
//    var phone = $('#phone');
//    var ephone = $('#e-phone');
//    var password = $('#password');

//    username.keypress(function () {
//        //לעשות שימוש באג'קס
//    });
//    phone.keydown(function () {
//        if (!isNaN(phone.text)) {
//            if (phone.text.length < 9) {
//                ephone.text = "המספר קצר מדי";
//            }
//            else {
//                if (phone.text.length > 9) {
//                    ephone.text = "המספר ארוך מדי";
//                }
//                else {
//                    if (phone.text.length === 9) {
//                        ephone.text = "";
//                    }
//                }
//            }
//        }
//        else {
//            ephone.text = "הוזנו תווים לא חוקיים";
//        }
//    });
//}

$(document).ready(function () {
    var username = $('#username');
    var fname = $('#fname');
    var lname = $('#lname');
    var phone = $('#phone');
    var ephone = $('#e-phone');
    var password = $('#password');

    username.keypress(function () {
        //לעשות שימוש באג'קס
    });

    phone.keyup(function () {
        var phoneValue = phone.val();
        if (!isNaN(phoneValue)) {
            if (phoneValue.length < 8 && phoneValue.length != 0) {
                ephone.text("המספר קצר מדי");
            }
            else {
                if (phoneValue.length > 8) {
                    ephone.text("המספר ארוך מדי");
                }
                else {
                    if (phoneValue.length === 8) {
                        ephone.text("");
                    }
                    else {
                        if (phoneValue.length === 0) {
                            ephone.text("יש להזין מספר")
                        }
                    }
                }
            }
        }
        else {
            ephone.text("הוזנו תווים לא חוקיים");
        }
    });
});

