function search() {
    var searchValue = document.getElementById("search_input").value;
    window.location.href = "/Home/Search?searchString=" + searchValue;
}