import http from "http";
import os from "os";
import { notFound } from "./notFound.mjs";

import { handleMainRoute } from "./handleMainRoute.mjs";
import { handleTestRoute } from "./handleTestRoute.mjs";

const user = os.userInfo();

const interfaces = os.networkInterfaces();

const server = http.createServer((req, resp) => {
    console.log(req.url);

    switch (req.url) {

        case "/test":
            handleTestRoute(resp, user, interfaces);
            break;

        case "/main":
            handleMainRoute(resp, user, interfaces);
            break;

        default:
            notFound(resp);
            return;
    }
    resp.end();
});

server.listen(3000, () => {
    console.log(`Server listening on port 3000`);
});     