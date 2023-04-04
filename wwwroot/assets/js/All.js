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
