export function notFound(resp){
    resp.statusCode = 404;
    resp.setHeader('Content-Type', 'text/plain');
    resp.write("Not found");
    resp.end(); 
}

