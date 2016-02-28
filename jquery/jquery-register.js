/// <reference path="jquery.min.js" />


$(document).ready(function () {
    var username = $('#username');
    var fname = $('#fname');
    var lname = $('#lname');
    var phone = $('#phone');
    var ephone = $('#e-phone');
    var password = $('#password');
    var epass = $('#epass');

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
    password.keyup(function () {
        var val = password.val();
        if (val.length === 0) {
            epass.text("יש להזין סיסמא");
        }
        else {
            if (val.length < 6) {
                epass.text("על הסיסמא להיות באורך 6 תווים לפחות");
            }
            else {
                if (val.length >= 6) {
                    epass.text("");
                }
            }
        }
    });
});

function CheckForm() {
    var username = $('#username').val();
    var fname = $('#fname').val();
    var lname = $('#lname').val();
    var phone = $('#phone').val();
    var password = $('#password').val();
    if (username.length === 0) {
        alert('יש להזין שם משתמש');
        return false;
    }
    if (fname.length === 0) {
        alert('יש להזין שם פרטי');
        return false;
    }
    if (!NamesCheck(fname)) {
        alert('השם הפרטי אינו חוקי');
        return false;
    }
    if (lname.length === 0) {
        alert('יש להזין שם משפחה');
        return false;
    }
    if (!NamesCheck(lname)) {
        alert('השם המשפחה אינו חוקי');
        return false;
    }
    if (phone.length === 0) {
        alert('יש להזין מספר טלפון');
        return false;
    }
    if (!PhoneCheck(phone)) {
        alert('מספר הטלפון אינו חוקי');
        return false;
    }
    if (password.length === 0) {
        alert('יש להזין סיסמא');
        return false;
    }
    if (password.length < 6) {
        alert('על הסיסמא להיות באוך 6 תווים לפחות');
        return false;
    }
    return false;
}

function NamesCheck(name) {
    for (var i = 0; i < name.length; i++) {
        if (!isNaN(name[i])) {
            return false;
        }
    }
    return true;
}

function PhoneCheck(number) {
    if (name.length != 8) {
        return false;
    }
    for (var i = 0; i < number.length; i++) {
        if (isNaN(number[i])) {
            return false;
        }
    }
    return true;
}