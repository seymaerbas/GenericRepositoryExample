




$(document).ready(function () {
    $("#customerDatatable").DataTable({
        processing: true,
        serverSide: true,
        filter: true,
        ajax: {
            url: "https://localhost:44303/api/content/getallcontents",
            type: "POST",
           /* dataType: "json",*/

            contentType: " application/x-www-form-urlencoded", /*dönen result sonucunu hangi formatta gelip gelmediğini belirler*/
        },
        columnDefs: [{
            targets: [0],
            visible: false,
            searchable: false
        }],
        columns: [
            { data: "content_Id", name: "content_Id", autoWidth: true },
            { data: "title", name: "title", autoWidth: true },
            { data: "description", name: "description", autoWidth: true },
            { data: "detail", name: "detail", autoWidth: true },
            


            {
                render: function (data, row) { return "<a href='#' class='btn btn-danger' onclick=DeleteCustomer('" + row.id + "'); >Delete</a>"; }
            },
        ]
    });
});

//// Delete customer
//var handleDeleteRows = () => {
//    // Select all delete buttons
//    const deleteButtons = document.querySelectorAll('[data-kt-docs-table-filter="delete_row"]');

//    deleteButtons.forEach(d => {
//        // Delete button on click

//        d.addEventListener('click', function (e) {
//            e.preventDefault();
//            // Select parent row
//            const parent = e.target.closest('tr');
//            // Get customer name
//            const title = parent.querySelectorAll('td')[3].innerText;
//            var id = parent.querySelectorAll('td')[1].innerText;
//            // SweetAlert2 pop up --- official docs reference: https://sweetalert2.github.io/
//            Swal.fire({
//                text: title + " Kaydını silmek istediğinizden emin misiniz ?",
//                icon: "warning",
//                showCancelButton: true,
//                buttonsStyling: false,
//                confirmButtonText: "Yes, delete!",
//                cancelButtonText: "No, cancel",
//                customClass: {
//                    confirmButton: "btn fw-bold btn-danger",
//                    cancelButton: "btn fw-bold btn-active-light-primary"
//                }
//            }).then(function (result) {
//                if (result.value) {
//                    $.ajax({
//                        type: "POST",
//                        url: "https://localhost:44363/api/content/delete/" + id,
//                        contentType: "application/json; charset=utf-8",
//                        success: function (data) {
//                            Swal.fire({
//                                text: "Silme işlemi başarıyla gerçekleşti.",
//                                icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
//                                customClass: { confirmButton: "btn btn-primary" }
//                            }).then((function (t) { t.isConfirmed && $("#contentDatatable").DataTable().ajax.reload() }))

//                        },
//                        error: function (data) {
//                            Swal.fire({
//                                text: "HATA! Sistem yöneticisi ile iletişime geçiniz!'" + data + "'",
//                                icon: "error", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
//                                customClass: { confirmButton: "btn btn-primary" }
//                            }).then((function (t) { t.isConfirmed && (initDatatable()) }))
//                        }

//                    });
//                    //// Simulate delete request -- for demo purpose only
//                    //Swal.fire({
//                    //    text: "Siliniyor " + customerName,
//                    //    icon: "info",
//                    //    buttonsStyling: false,
//                    //    showConfirmButton: false,
//                    //    timer: 2000
//                    //}).then(function () {

//                    //    //Silme işlemi yapılacak 


//                    //});
//                } else if (result.dismiss === 'cancel') {
//                    Swal.fire({
//                        text: title + " was not deleted.",
//                        icon: "error",
//                        buttonsStyling: false,
//                        confirmButtonText: "Ok, got it!",
//                        customClass: {
//                            confirmButton: "btn fw-bold btn-primary",
//                        }
//                    });
//                }
//            });
//        })
//    });
//}