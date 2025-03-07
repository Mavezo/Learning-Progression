const fs = require("fs");

let str = fs.readFileSync("hello.txt", "utf8");

console.log(str);
