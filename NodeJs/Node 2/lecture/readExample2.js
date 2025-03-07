const fs = require("fs");

let str = fs.readFile("hello.txt", "utf8", function(err, data){
    if(err)
        throw err
    console.log(data);
});
console.log("data");
