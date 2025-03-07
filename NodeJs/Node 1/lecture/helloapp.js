const http = require('http');
const server = http.createServer(function(req, resp) {
    resp.end("Hello from my first NodeJS web server");
    
});
server.listen(3000, ()=>{
    console.log("Server listening on port 3000");

});

