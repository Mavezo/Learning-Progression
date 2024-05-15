function changeElemValue(e, elemId) {
    e.preventDefault();
    var element = document.getElementById(elemId);
    element.value = e.target.innerText;
}