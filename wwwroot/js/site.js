// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

"use strict"
window.onload = function () {

    var uid = document.getElementById('UID');
    //var errorMainList = document.getElementById('errorMainList');
    var TaskID = document.getElementById('TaskID');


    uid.addEventListener('change', () => {

        var errors = [];


        if (!/^\d+$/.test(uid.value)) {
            errors.push("UID only allows numbers");
        }

        if (uid.value.length != 8) {
            //uid.value = uid.value.slice(0, 8);
            errors.push("UID should be exact of 8 digits");
        }

        if (/\s/i.test(uid.value)) {
            errors.push("UID can't contain white spaces");
        }
        updateErrors(errors, 'error_UID');

    })

    TaskID.addEventListener('change', () => {
        var errors = [];

        if (/\s/i.test(TaskID.value)) {
            errors.push("Task ID can't contain white spaces");
        }
        updateErrors(errors, 'error_TaskID');
    });

    function updateErrors(errors, errorContainerId) {
        //errorMainList.innerHTML = "";
        var errorContainer = document.getElementById(errorContainerId);
        errorContainer.innerHTML = "";

        if (errors.length > 0) {
            errors.forEach(function (errMsg) {
                var errorSubList = document.createElement('li');
                errorSubList.className = "text-danger";
                errorSubList.style.fontWeight = "bold";
                errorSubList.appendChild(document.createTextNode(errMsg));
                errorContainer.appendChild(errorSubList);
            })
        }
    }
}
