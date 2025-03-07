const Emmiter = require("events");
class User extends Emmiter{
    constructor(name, age){
        super();
        this.name = name;
        this.age = age;
    }
    sayHi(){
        this.emit("greet");
    }
}

let user = new User("Roman", 18);
user.on("greet", ()=>{
    console.log(`Hello! My name is ${user.name}. I'm ${user.age} year old`);
});

user.on("greet", ()=>{
    console.log("Hello again");
    user.age++;
});

user.sayHi();
user.sayHi();
user.sayHi();