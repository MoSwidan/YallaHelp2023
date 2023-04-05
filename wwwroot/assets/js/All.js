function All() {
    //here
    
}
//function to set select value
function selectgover(id, idvalue) {
    waitForElm(`#${id}`).then((elm) => {
        elm.value = idvalue;
    });
}
//function to wait element to be rendered
function waitForElm(selector) {
    return new Promise(resolve => {
        if (document.querySelector(selector)) {
            return resolve(document.querySelector(selector));
        }

        const observer = new MutationObserver(mutations => {
            if (document.querySelector(selector)) {
                resolve(document.querySelector(selector));
                observer.disconnect();
            }
        });

        observer.observe(document.body, {
            childList: true,
            subtree: true
        });
    });
}
let result = null;
function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition, showError);
    } else {
        alert("Geolocation is not supported by this browser.");
    }
}
function showPosition(position) {
    if (position.coords.latitude != null && position.coords.longitude != null) {
        localStorage.setItem("lon", position.coords.longitude);
        localStorage.setItem("lat", position.coords.latitude);
    }
    else
    {
        result = ["none"];
        alert("null");
    }
}
function showError(error) {
    switch (error.code) {
        case error.PERMISSION_DENIED:
            result = ["User denied the request for Geolocation."]
            break;
        case error.POSITION_UNAVAILABLE:
            result = ["Location information is unavailable."]
            break;
        case error.TIMEOUT:
            result = ["The request to get user location timed out."]
            break;
        case error.UNKNOWN_ERROR:
            result = ["An unknown error occurred."]
            break;
    }
    alert(result[0]);
}
