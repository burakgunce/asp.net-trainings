function GetList() {
    $.ajax({
        url: "/Person/GetAllPeople",
        type: "get",
        success: function (response) {
            $("#list").html(response);
            $("#error").html("");
            $("#create").html("");
            $("#update").html("");
        },
        error: function () {
            $("error").html("<h3>something went error </53>")
        }
    });
}

function GetCreatePage() {
    $.ajax({
        url: "/Person/Create",
        type: "get",
        success: function (response) {
            $("#create").html(response);
            $("#error").html("");
            $("#update").html("");
        }
    });
}

function CreatePerson() {
    let person = {
        firstName: $("#createFirstName").val(),
        lastName: $("#createLastName").val(),
        birthDate: $("#createBirthDate").val(),
        age: $("#createAge").val()
    }; //obje olusturma js de

    $.ajax({
        url: "/Person/Create",
        type: "post",
        data: person,
        success: function (response) {
            if (response == "ok") {
                $("#list").html("");
                $("#error").html("");
                $("#create").html("");
                $("#update").html("");
                GetList();
            }
            else {
                $("#error").html("<h3 class='bg-danger'>an error occured while the person adding  </h3>")
            }
        },
        error: () => {
            $("#error").html("<h3 class='bg-danger'>something went wrong </h3>")
        }
    });
}

function GetUpdatePage(sid) {
    $.ajax({
        url: "/Person/Update/" + sid,
        type: "get",
        success: function (response) {
            $("#update").html(response);
            $("error").html("");
        }

    });
}

function UpdatePerson(sid) {
    let person = {
        id: sid,
        firstName: $("#updateFirstName").val(),
        lastName: $("#updateLastName").val(),
        birthDate: $("#updateBirthDate").val(),
        age: $("#updateAge").val()
    };

    $.ajax({
        url: "/Person/Update",
        type: "post",
        data: person,
        success: function (response) {
            if (response == "ok") {
                $("#list").html("");
                $("#error").html("");
                $("#create").html("");
                $("#update").html("");
                GetList();
            }
            else {
                $("#error").html("<h3 class='bg-danger'>an error occured while the person adding  </h3>")
            }
        }
    });
}

function UpdatePerson2() {
    $.ajax({
        url: "/Person/Update",
        type: "post",
        data: $("#updateForm").serialize(),
        dataType: "json",
        success: function (response) {
            if (response == "ok") {
                $("#list").html("");
                $("#error").html("");
                $("#create").html("");
                $("#update").html("");
                GetList();
            }
            else {
                $("#error").html("<h3 class='bg-danger'>an error occured while the person adding  </h3>")
            }
        }
    });
}

function DeletePerson(sid) {
    $.ajax({
        url: "/Person/Delete" + sid,
        type: "get",
        success: function (response) {
            if (response == "ok") {
                $("#error").html("");
                $("#update").html("");
                $("#create").html("");
                GetList();
            }
        }
    });
}
