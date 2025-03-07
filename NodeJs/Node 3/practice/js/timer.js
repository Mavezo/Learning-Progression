const Emmiter = require("events")
let emmiter = new Emmiter();
let eventName = "timer";

emmiter.on(eventName, function (seconds) {
    if (seconds > 0) {
        console.log(seconds);
        seconds--;
        setTimeout(()=>{
            emmiter.emit("timer", seconds);
        }, 1000);
    }
    else{
        console.log("Timer Ended!");
        
    }
})


module.exports = emmiter;