$.fn.serializeObject = function () { "use strict"; var a = {}, b = function (b, c) { var d = a[c.name]; "undefined" != typeof d && d !== null ? $.isArray(d) ? d.push(c.value) : a[c.name] = [d, c.value] : a[c.name] = c.value }; return $.each(this.serializeArray(), b), a };

[...document.getElementsByClassName("item-card")].forEach(x => {
    x.addEventListener("click", function () {
        window.location.href = `/Items/${this.id}`;
    });
});

const deleteItem = (id) => {
    $.ajax({
        url: "/Items/Delete",
        type: "POST",
        data: {
            id
        }
    }).done(() => {
        alert("Uspješno izbrisano!");
    }).fail(() => {
        alert("Došlo je do greške!");
    });
}

document.getElementById("createItemForm").addEventListener("submit", function (e) {
    e.preventDefault();
}, true);

document.getElementById("editItemForm").addEventListener("submit", function (e) {
    e.preventDefault();
}, true);

function createNewItem() {
    const payload = $('#createItemForm').serializeObject();
    $.ajax({
        url: "/Items/Create",
        type: "POST",
        data: payload
    }).done(() => {
        alert("Uspješno spremljeno!");
    }).fail(() => {
        alert("Došlo je do greške!");
    });
}

function editItem() {
    const payload = $('#editItemForm').serializeObject();
    $.ajax({
        url: "/Items/Edit",
        type: "POST",
        data: payload
    }).done(() => {
        alert("Uspješno spremljeno!");
    }).fail(() => {
        alert("Došlo je do greške!");
    });
}