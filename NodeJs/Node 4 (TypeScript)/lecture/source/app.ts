let user = new MyUser(18);
user.name = "Roman";
user.id = 1;
// user.sayHello();
let d1 = document.getElementById("d1");
if(d1)
d1.innerText = `${user.name}, ${user.id}`;
