// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function onFileSelected(event) {
    var selectedFile = event.target.files[0];
    var reader = new FileReader();

    var imgtag = document.getElementById("image");
    imgtag.title = selectedFile.name;

    reader.onload = function (event) {
    imgtag.src = event.target.result;
    };

    reader.readAsDataURL(selectedFile);
}
