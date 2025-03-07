const timer = require("./timer")

function onClick() {
    timer.emit("timer", 10);
}

module.exports = { onClick };