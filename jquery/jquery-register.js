/// <reference path="jquery.min.js" />

$(document).ready(function () {
    var username = $('#username');
    var fname = $('#fname');
    var lname = $('#lname');
    var phone = $('#phone');
    var ephone = $('#e-phone');
    var password = $('#password');
    var epass = $('#e-pass');

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
        var value = password.val();
        if (value.length === 0) {
            epass.text("יש להזין סיסמא");
        }
        else {
            if (value.length < 6) {
                epass.text("על הסיסמא להיות באורך 6 תווים לפחות");
            }
            else {
                if (value.length >= 6) {
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

    if(username.length===0){
        alert('יש להזין שם משתמש');
        return false;
    }
    if(fname.length===0){
        alert('יש להזין שם פרטי');
        return false;
    }
    else{
        if (!namesCheck(fname)) {
            alert('השם הפרטי אינו חוקי')
            return false;
        }
    }
    if (lname.length === 0) {
        alert('יש להזין שם משפחה');
        return false;
    }
    else {
        if (!namesCheck(lname)) {
            alert('שם המשפחה אינו חוקי');
            return false;
        }
    }
    if (phone.length === 0) {
        alert('יש להזין מספר טלפון');
        return false;
    }
    else {
        if(!phoneCheck(phone)){
            alert('מספר הטלפון אינו חוקי');
            return false;
        }
    }
    if (password.length === 0) {
        alert('יש להזין סיסמא');
        return false;
    }
    else {
        if (password.length < 6) {
            alert('על הסיסמא להכיל לפחות 6 תווים');
            return false;
        }
    }
    return true;
}

function phoneCheck(number){
    if(!isNaN(number)){
        if(number.length===8)
            return true;
        else
            return false;
    }
    else{
        return false;
    }
}

function namesCheck(name) {
    var len = name.length;
    var tOrf=true;
    for (var i = 0; i < len; i++) {
        if (!isNaN(name[i])) {
            tOrf = false;
        }
    }
    return tOrf;
}