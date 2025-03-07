const fs = require("fs");
const message = "Hello, Angular";
const filename = "message.txt";
fs.writeFile(filename, message, function(err){
    if(err)
        throw err;
    fs.readFile(filename, "utf-8", function(er2, data){
        if(er2)
            throw er2;
        console.log(data);
    })
});
