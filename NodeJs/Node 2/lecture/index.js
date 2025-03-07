const express = require("express");
const port = 3000;
const app = express();

let name = process.argv[2];
let age = process.argv[3];



app.get("/", (req, resp)=>{
    resp.end("Hello from express!");
    console.log(`Request path: ${req.path}`);
});

app.get("/user",(req, resp)=>{
    resp.end(`${name}, ${age} years old`)
    let user = {name: "Roman", age: "18"};
    resp.json(user);
});

app.get("/author", (req, resp)=>{
    console.log(`Request path: ${req.path}`);
    resp.write("Author!");
    resp.end();
});

app.get("/group", (req, resp)=>{
    console.log(`Request path: ${req.path}`);
    resp.setHeader("Content-Type", "text/html;charset=utf-8");
    resp.write(`<h2>5G</h2>`);
    resp.end(`<div>Hello from Angular!</div>`)
});



app.listen(port, ()=>{
    console.log(`Server starts on port ${port}`);
});
