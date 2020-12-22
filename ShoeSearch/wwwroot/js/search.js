
let searchValue;
let page = 1;
let alreadySearched = false;

function getItems(name, pageNr) {
    $.ajax({
        type: "GET",
        url: `api?itemName="${name}"&pageNr=${pageNr}`,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: (items) => {
            items.forEach((item) => {
                $('#itemTable').append(`<tr><td><a href='${item.ad_link}'>${item.ad_id}</a></td><td>${item.heading}</td><td>${item.price.amount} ${item.price.currency_code}</td></tr>`);
            });
        },
        failure: function (jqXHR, textStatus, errorThrown) {
            alert("HTTP Status: " + jqXHR.status + "; Error Text: " + jqXHR.responseText); // Display error message  
        }
    });
}  

const searchInp = document.getElementById('SearchInp');
const searchBtn = document.getElementById('SearchBtn');
const table = document.getElementById('itemTable');

searchBtn.addEventListener('click', search);

$(window).scroll(function () {
    if ($(window).scrollTop() + $(window).height() == $(document).height()) {
        loadMore()
    }
});

function search(e) {
    if (searchInp.value) {
        reset();
        searchValue = searchInp.value
        getItems(searchValue, page);
        alreadySearched = true;
    }
}

function reset() {
    page = 1;
    table.innerHTML = '';
}

function loadMore() {
    if (alreadySearched) {
        page++;
        getItems(searchValue, page);
    }
}