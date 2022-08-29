﻿function manageDropdown() {
    console.log("Input clicked");
    const selectListToUse = (document.getElementById("selectListToUse") as HTMLSelectElement);
    const optionToShow = (document.getElementById("optionToShow") as HTMLOptionElement);

    optionToShow.hidden = false;

    selectListToUse.add(optionToShow);
}

function sayHello() {
    console.log("Yo yo yo from FinanceHomeIndexFinanceHomeIndex");
}

function getCatFact() {
    var xhr = new XMLHttpRequest();

    xhr.open("POST", "/Posts/GetCatFact", true);
    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.send();

    xhr.onload = function (response) {

        const catFactParagraph = (document.getElementById("catFactParagraph") as HTMLParagraphElement);

        let catFactResponse = xhr.responseText;

        let json = JSON.parse(catFactResponse);
        console.log(`Fact: ${json.fact}`);

        let catFactString = json.fact;

    };

}

// https://stackoverflow.com/questions/42423045/call-mvc-controller-method-from-typescript-javascript-without-jquery#42423093