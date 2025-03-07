const Emmiter = require("events");
let emmiter = new Emmiter();
let eventName = "greet";
emmiter.on(eventName,()=>{
    console.log("Hello from JS event");
});
emmiter.on(eventName, ()=>{
    console.log("Hello again!");
})
emmiter.emit(eventName);

