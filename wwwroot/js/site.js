// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

"use strict"
window.onload = function () {

    var uid = document.getElementById('UID');
    var TaskID = document.getElementById('TaskID');


    uid.addEventListener('change', () => {

        var errors = [];

        if (uid.value == null) {
            errors.push("UID cannot be null");
        }

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

        if (TaskID.value == null) {
            errors.push("Task ID cannot be null")
        }

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

    var DropDownMenu = document.getElementById('DropDownMenu');
    var DropDownItems = document.querySelectorAll('.dropdown-item');

    DropDownItems.forEach(function (item) {
        item.addEventListener('click', function (e) {
            var DropDownMenu = e.target.closest('.dropdown').querySelector('.dropdown-toggle');
            DropDownMenu.textContent = e.target.textContent;
        });
    });

    (() => {
        'use strict'

        // Fetch all the forms we want to apply custom Bootstrap validation styles to
        const forms = document.querySelectorAll('.needs-validation')

        // Loop over them and prevent submission
        Array.from(forms).forEach(form => {
            form.addEventListener('submit', event => {
                if (!form.checkValidity()) {
                    event.preventDefault()
                    event.stopPropagation()
                }

                form.classList.add('was-validated')
            }, false)
        })
    })

    if (uid.value == 0 || TaskID == null || TaskID == 0) {
        var inputField = document.querySelectorAll('.correct');
        inputField.classList.add("error");
    }
    
}
