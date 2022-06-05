////namespace NichDevDotNetCore.wwwroot.scripts
////{
////    public class app
////    {
////    }
////}
//function sayHello() {
//    const compiler = (document.getElementById("compiler") as HTMLInputElement)
//        .value;
//    const framework = (document.getElementById("framework") as HTMLInputElement)
//        .value;
//    return `Hello from ${compiler} and ${framework}!`;
//}

function manageDropdown() {
//    const compiler = (document.getElementById("compiler") as HTMLInputElement)
//        .value;
    console.log("Input clicked");
    const selectListToUse = (document.getElementById("selectListToUse") as HTMLSelectElement);
    const optionToShow = (document.getElementById("optionToShow") as HTMLOptionElement);

    optionToShow.hidden = false;

    selectListToUse.add(optionToShow);
}

function sayHello() {
    console.log("Yo yo yo from typescript");
}

function getCatFact() {
    var xhr = new XMLHttpRequest();
    console.log("Cat fact called");

    xhr.open("POST", "/Posts/GetCatFact", true);
    xhr.setRequestHeader("Content-Type", "application/json");
   // console.log("1 ", xhr);

    //OR

    //Option 2: Nothing to submit to the server
    xhr.send();

    console.log("xhr: ", xhr);

    xhr.onload = function (response) {
        //console.log("Response: ", response);

        //console.log("currentTarget ", response.currentTarget);
        //if (response.target == 200) {

        //    data = JSON.parse(response.target.response);

        //}

    };

}

// https://stackoverflow.com/questions/42423045/call-mvc-controller-method-from-typescript-javascript-without-jquery#42423093