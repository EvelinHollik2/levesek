const apiUrl = "http://localhost/api/index.php?levesek";
document.addEventListener("DOMContentLoaded", function () {
    async function getLevesek() {
        response = await fetch(apiUrl);
        data = await response.json();
        console.log(data);
        showlevesek(data);
    }
    function showlevesek(data) {
        let levesekHtml = "";
        for (let leves of data) {
            levesekHtml+=`<div class="card col-lg-3 col-md-4 col-sm-6">
            <div class="card-body">
            <h5 class="card-title">${leves.megnevezes}</h5>
            <p class="card-text">kalória: ${leves.kaloria}</p>
            <p class="card-text">fehérje: ${leves.feherje}</p>
            <p class="card-text">zsír: ${leves.zsir}</p>
            </div></div>`;
        }
        document.getElementById("levesek").innerHTML=levesekHtml;
    }
    getLevesek();
});