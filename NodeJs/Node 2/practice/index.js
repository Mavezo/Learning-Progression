const express = require("express");
const port = 3000;
const body = require("body-parser");
const bodyParser = require("body-parser");
const app = express();

const urlEncoded = bodyParser.urlencoded({extended: false});

app.use(express.static(__dirname+'/public'));

app.get("/home", (req, resp)=>{
    resp.write(req.path);
    resp.end();
});

app.post("/registration", urlEncoded, (req, resp)=>{
    let email = req.body.email;
    let password = req.body.password;
    resp.setHeader("Content-Type", "text/html;charset=utf-8");
    resp.write(`<h2>Hello, ${email}</h2>`);
    resp.end(`<div>You set password to ${password}</div>`);
});

app.listen(port, ()=>{
    console.log(`Server starts on ${port}`);
})