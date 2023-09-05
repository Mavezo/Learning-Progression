function showBlocks(params) {
    for (i = 0; i < params; i++){
        document.write(`<div>Block${i}</div>`);
    }
}

function showBlocks(params, color) {
    for (i = 0; i < params; i++){
        document.write(`<div style='color:${color};'>Block${i}</div>`);
    }
}

