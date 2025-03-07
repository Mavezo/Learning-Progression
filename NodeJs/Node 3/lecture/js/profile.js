import css from "../css/style.css"
import timeline from "./timeline";

const user = {
    name: "Roman Tselik",
    messages: [
        ".NET 9 Preview released!",
        "New features in C# 13",
        "New version on CodeIgniter"
    ]
}

let timelineObj = new timeline(user);
timelineObj.setHeader();
timelineObj.setMessages();
timelineObj.setImage();