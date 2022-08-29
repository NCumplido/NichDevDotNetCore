function manageDropdown() {
    console.log("Input clicked");
    const selectListToUse = document.getElementById("selectListToUse");
    const optionToShow = document.getElementById("optionToShow");
    optionToShow.hidden = false;
    selectListToUse.add(optionToShow);
}
function sayHello() {
    console.log("Yo yo yo from typescript");
}
function getCatFact() {
    var xhr = new XMLHttpRequest();
    xhr.open("POST", "/Posts/GetCatFact", true);
    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.send();
    xhr.onload = function (response) {
        const catFactParagraph = document.getElementById("catFactParagraph");
        let catFactResponse = xhr.responseText;
        let json = JSON.parse(catFactResponse);
        console.log(`Fact: ${json.fact}`);
        let catFactString = json.fact;
        catFactParagraph.innerText = catFactString;
    };
}
// https://stackoverflow.com/questions/42423045/call-mvc-controller-method-from-typescript-javascript-without-jquery#42423093
//# sourceMappingURL=app.js.map