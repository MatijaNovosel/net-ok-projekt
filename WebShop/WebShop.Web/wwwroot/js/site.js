[...document.getElementsByClassName("item-card")].forEach(x => {
    x.addEventListener("click", function() {
        window.location.href = `Items/${this.id}`;
    });
});

const deleteItem = (id) => {
    $.ajax({
        url: "Items/Delete",
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