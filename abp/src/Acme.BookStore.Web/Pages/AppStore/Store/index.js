$(function () {

    $("#StoreFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#StoreCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#StoreFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/StoreFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('BookStore');

    var service = acme.bookStore.appStore.store;
    var createModal = new abp.ModalManager(abp.appPath + 'AppStore/Store/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'AppStore/Store/EditModal');

    var dataTable = $('#StoreTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,//disable default searchbox
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('BookStore.Store.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('BookStore.Store.Delete'),
                                confirmMessage: function (data) {
                                    return l('StoreDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('StoreTow'),
                data: "tow"
            },
            {
                title: l('StoreThree'),
                data: "three"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewStoreButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
