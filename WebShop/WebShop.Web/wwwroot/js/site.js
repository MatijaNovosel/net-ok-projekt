[...document.getElementsByClassName("item-card")].forEach(x => {
    x.addEventListener("click", function() {
        window.location.href = `Items/${this.id}`;
    });
});