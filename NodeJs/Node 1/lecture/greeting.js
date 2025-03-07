let current_time = new Date();
let hour = current_time.getHours();

global.date = current_time;

let greeting = function (name) {
    if(hour < 11)
        console.log(`Good morning, ${name}`);
    else if(hour < 18)
        console.log(`Good day, ${name}`);
    else if(hour < 22){
        console.log(`Good evening, ${name}`)
    }
    else{
        console.log(`Good night, ${name}`);
    }
}
module.exports.greetfunc = greeting;
module.exports.currentTime = current_time;
