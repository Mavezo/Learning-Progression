const os = require('os');
const greetings = require("./greeting");
const User = require("./User");

const welcome = require("./welcome")

let userInfo = os.userInfo();
console.log(userInfo);
let userName = userInfo.username;
let homedir = userInfo.homedir;

greetings.greetfunc(userName);
console.log(greetings.currentTime.toLocaleTimeString());

console.log(`User Name is ${userName}`);
console.log(`Home directory is ${homedir}`);

let user1 = new User("Tatiana", 36);
user1.sayHello();
console.log(user1);

welcome.getEveningMessage();

console.log(global.date.toLocaleTimeString());
