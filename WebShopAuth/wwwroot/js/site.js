$.fn.serializeObject = function () { "use strict"; var a = {}, b = function (b, c) { var d = a[c.name]; "undefined" != typeof d && d !== null ? $.isArray(d) ? d.push(c.value) : a[c.name] = [d, c.value] : a[c.name] = c.value }; return $.each(this.serializeArray(), b), a };

function renderGrid(data) {
    let outputContent = "";

    if (data.length != 0) {
        data.forEach(x => {
            outputContent += `
            <div id="${x.id}" class="item-card shadow-sm border-shaded rounded-lg d-flex flex-column align-items-center shrink cursor-pointer select-none">
                <h5 class='align-self-start'>${x.name}</h5>
                <span class='align-self-start'>${x.description}</span>
                <span class='align-self-start'>${x.price - x.price * x.discount / 100} HRK</span>
                <div class="d-flex mt-3">
                    ${x.tags.map(y => `<div class='px-3 py-1 pill-bg rounded-pill mr-3'>${y.description}</div>`)}
                </div>
            </div>
        `;
        });
    } else {
        outputContent += "<h6>No items found!</h6>";
    }

    $("#items-grid").html(outputContent);
}

function searchItems() {
    const payload = $('#searchItemForm').serialize();

    $.ajax({
        url: "/api/items/search",
        type: "GET",
        data: payload
    }).done(resp => {
        renderGrid(resp);
    });
}

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

document.addEventListener("DOMContentLoaded", function () {
    [...document.getElementsByClassName("item-card")].forEach(x => {
        x.addEventListener("click", function () {
            window.location.href = `/Items/${this.id}`;
        });
    });
});