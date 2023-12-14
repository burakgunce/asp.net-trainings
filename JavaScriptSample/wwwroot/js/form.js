function UzunlukHesapla() {
    var password = document.getElementById("passwordId");
    //var password = document.querySelector('#passwordId')
    // 3 var form = document.querySelector('form');
    // 3 var password = form.elements.namedItem('passwordId');
    document.getElementById('KarakterSayisi').textContent = password.value.length;
}

var form = document.querySelector('form');
var chkAktif = form.elements.chkAktive;
chkAktif.addEventListener("change", function () {
    //alert('Test');
    if (chkAktif.checked) {
        form.elements.btnSample.disabled = true;
    }
    else {
        form.elements.btnSample.disabled = false;
    }
});

var colors = document.getElementsByName('optRenk');
for (var i = 0; i < colors.length; i++) {
    colors[i].addEventListener("change", setColor)
}

function setColor() {
    document.getElementById('arkaPlan').style.backgroundColor = event.target.value;
}

var fileSelect = document.getElementById('fileId');
fileSelect.addEventListener("change", function () {
    if (fileSelect.files.length == 0) {
        alert('Dosya secılmedı');
    }
    else {
        var file = fileSelect.files[0];
        document.getElementById('DosyaAdi').innerHTML = file.name;
        document.getElementById('DosyaTipi').innerHTML = file.type;
    }
});

function ValidateForm() {
    var errNumber = 0;
    //kullanıcı adı bos gecılemez
    if (document.getElementById('txtKullaniciAd').value.length == 0) {
        document.getElementById('txtKullaniciUyari').innerHTML = "kullanıcı adını bos gecmeyınız";
        errNumber++;
    }
    else {
        document.getElementById('txtKullaniciUyari').innerHTML = ";
    }

    //sıfre 6 karakterden kucuk kontrolu
    var password = document.getElementById('passwordId');
    if (password.value.length < 6) {
        document.getElementById('txtPasswordUyari').innerHTML = "en az 6 karakter gırınız";
        errNumber++;
    }
    else {
        document.getElementById('txtPasswordUyari').innerHTML = "";
    }

    if (errNumber == 0) {
        return true;
    }
    else {
        return false;
    }
}