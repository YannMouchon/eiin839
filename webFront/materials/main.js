function retrieveAllContracts() {
    var api_key = document.getElementById('api_key').value;
    var urlToReq = "https://api.jcdecaux.com/vls/v3/contracts?apiKey=" + api_key;

    var caller = new XMLHttpRequest();
    caller.open("GET", urlToReq, true);
    caller.setRequestHeader("Accept", "application/json");
    caller.onload = contractsRetrieved;
    caller.send();
}

function contractsRetrieved() {
    var response = JSON.parse(this.responseText);
    console.log(response);
}