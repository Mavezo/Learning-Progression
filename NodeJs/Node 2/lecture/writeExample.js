const fs = require("fs");
const message = "Hello, Angular";
const filename = "message.txt";
fs.writeFileSync(filename, message);
str = fs.readFileSync(filename, "utf-8");
console.log(str);
