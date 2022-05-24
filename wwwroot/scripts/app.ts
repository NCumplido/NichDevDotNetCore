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
    console.log("Cat fact called");
}