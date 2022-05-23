function getBodySize() {
    return {
        Width: document.body.offsetWidth,
        Height: document.body.offsetHeight
    }
}

function isDevice() {
    return /android|webos|iphone|ipad|ipod|blackberry|iemobile|opera mini|mobile/i.test(navigator.userAgent);
}