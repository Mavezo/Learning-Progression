function printAsync(data, callback) {
    rndInt = Math.random()*10;
    let err = rndInt > 5 ? new Error(`${rndInt} greater then 5`) : null
    setTimeout(()=>callback(err, data), 0);
}

console.log("Start execution");
printAsync("Method calling!", function(err, data) {
    if(err)
        throw err;
    console.log(data);
})
console.log("End Execution");

