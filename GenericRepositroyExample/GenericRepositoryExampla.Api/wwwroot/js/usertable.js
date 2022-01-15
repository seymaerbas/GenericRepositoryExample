




$(document).ready(function () {
    $("#userDatatable").DataTable({
        processing: false,
        serverSide: true,
        filter: true,
        ajax: {
            url: "https://localhost:44303/api/user/getallusers",
            type: "POST",
            /*dataType: "json",*/

            contentType: " application/x-www-form-urlencoded", /*dönen result sonucunu hangi formatta gelip gelmediğini belirler*/
        },
        columnDefs: [{
            targets: [0],
            visible: false,
            searchable: false
        }],
        columns: [
            { data: "id", name: "Id", autoWidth: true },
            { data: "nameSurname", name: "nameSurname", autoWidth: true },
            { data: "password", name: "password", autoWidth: true },
            { data: "email", name: "email", autoWidth: true },
            { data: "isActive", name: "isActive", autoWidth: true },


            {
                render: function (data, row) { return "<a href='#' class='btn btn-danger' onclick=DeleteCustomer('" + row.id + "'); >Delete</a>"; }
            },
        ]
    });
});
