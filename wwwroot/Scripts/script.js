window.onload = function () {
    var ActualStartDate = document.getElementById("ActualStartDate");
    var ActualEndDate = document.getElementById("ActualEndDate");

    ActualStartDate.onchange = function () { GetCompletionMonth() };
    ActualEndDate.onchange = function () { GetCompletionMonth() };

    function GetCompletionMonth() {
        var monthNames = ["Jan", "Feb", "Mar", "Apr", "May", "Jun",
            "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];

        var CompletionMonth = document.getElementById("CompletionMonth");

        if (ActualEndDate.value)
        {
            var date = new Date(ActualEndDate.value);
            var month = monthNames[date.getMonth()];
            CompletionMonth.value = month;
            console.log("ActualEndMonth : " + month);
        }
    }

    function GetActualStartMonth()
    {
        var monthNames = ["Jan", "Feb", "Mar", "Apr", "May", "Jun",
            "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];


        if (ActualStartDate.value)
        {
            var date = new Date(ActualStartDate.value);
            var ActualStartMonth = monthNames[date.getMonth()];
            console.log("ActualStartMonth : " + ActualStartMonth);
        }
    }

}