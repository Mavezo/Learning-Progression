function User(name, age) {
    this.name = name;
    this.age = age;
    this.sayHello = () => {
        console.log(`Hello, my name is ${this.name}, I'm ${this.age} years old`);
    }
}
module.exports = User;