function getBodySize() {
    return {
        Width: screen.availWidth,
        Height: screen.availHeight
    }
}

function isDevice() {
    return /android|webos|iphone|ipad|ipod|blackberry|iemobile|opera mini|mobile/i.test(navigator.userAgent);
}