


    $(document).ready(function () {
        $("#categoryDatatable").DataTable({
            processing: false,
            serverSide: true,
            
            ajax: {
                url: "https://localhost:44303/api/Category/GetAllCategory",
                type: "POST",
                /*dataType: "json",*/
             
                contentType: "application/x-www-form-urlencoded", /*dönen result sonucunu hangi formatta gelip gelmediğini belirler*/
            },
            columnDefs: [{
                targets: [0],
                visible: false,
                searchable: false
            }],
            columns: [
                { data: "category_Id", name: "category_Id"},
                { data: "title", name: "title"},
                { data: "description", name: "description"},


                {
                    render: function (data, row) { return "<a href='#' class='btn btn-danger' onclick=DeleteCustomer('" + row.id + "'); >Delete</a>"; }
                },
            ]
        });
    });


