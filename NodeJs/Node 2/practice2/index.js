const { log } = require("console");
const express = require("express");
const app = express();
const fs = require("fs");
const bodyParser = require("body-parser");
const path = require("path"); 


app.use(express.static(path.join(__dirname + "/public")));

const urlEncoded = bodyParser.urlencoded({extended: false});

app.get("/", (req, resp)=>{
    resp.end("Hello!");
});

app.get("/write", (req, res) => {
    res.sendFile(path.join(__dirname, "write.html"));
});


app.get("/text", (req, resp)=>{
    fs.readFile("text.txt", "utf-8", (err, data)=>{
        if(err)
            throw err
        resp.end(data);
    })
})

app.post("/write", urlEncoded, (req, resp)=>{
    const filePath = path.join(__dirname, "public", `${req.body.name}.txt`); 
    const fileUrl = `/${req.body.name}`;


    fs.writeFile(filePath, req.body.text, "utf-8", (err)=>{
        if(err)
            throw err;
        resp.redirect(fileUrl + ".txt");
    });
})



app.listen(3000, ()=>{
    console.log("Server starts on port 3000");
})