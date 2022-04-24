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
    const selectListToUse = document.getElementById("selectListToUse");
    const optionToShow = document.getElementById("optionToShow");
    optionToShow.hidden = false;
    selectListToUse.add(optionToShow);
}
//# sourceMappingURL=app.js.map