export function newArray(s) {
    var intArray = s.split(',').map(function (item) { return parseInt(item); });
    var nodes = document.querySelectorAll("#nodes .node");
    for (var i = 0; i < 10; i++) {
        if (i >= intArray.length || isNaN(intArray[i])) nodes[i].textContent = "";
        else nodes[i].textContent = intArray[i];
    }
}

export function addValue(s) {
    var nodes = document.querySelectorAll("#nodes .node");
    for (var i = 0; i < 10; i++) {
        if (nodes[i].textContent == "") return nodes[i].textContent = s;
    }
}

export function removeIndex(s) {
    var removeIndex = parseInt(s);
    var nodes = document.querySelectorAll("#nodes .node");
    var intArrayString = "";

    for (var i = 0; i < 10; i++) {
        if (nodes[i].textContent == "" || isNaN(nodes[i].textContent)) break;
        if (i != removeIndex) intArrayString += nodes[i].textContent + ",";
    }

    clear();

    var intArray = intArrayString.split(',').map(function (item) { return parseInt(item); });
    for (var i = 0; i < 10; i++) {
        if (i >= intArray.length || isNaN(intArray[i])) nodes[i].textContent = "";
        else nodes[i].textContent = intArray[i];
    }
}

export function clear() {
    var nodes = document.querySelectorAll("#nodes .node");
    for (var i = 0; i < 10; i++) {
        nodes[i].textContent = "";
    }
}