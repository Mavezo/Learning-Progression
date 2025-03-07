let x: number = 56;
let firstName: string = "Roman";
let ifAdmin: boolean = true;
let a;
a = "3243";
a = 3243;
let names: Array<string> = ["Roman", "Serhii", "Bart"];
let ages: number[] = [18, 20, 19];
let person: [string, number] = [names[0], ages[0]];
let persons: Array<[string, number]> = [];
names.forEach((element, index) => {
    persons.push([element, ages[index]]);
});

enum Seasons { Winter, Spring, Summer, Autumn };

let currentSeasons: Seasons = Seasons.Spring;

console.log(currentSeasons);
console.log(Seasons[currentSeasons]);
console.log(Seasons[Seasons.Spring]);

type stringOrNumber = any | string | number | boolean;

let y: stringOrNumber = 67;
console.log(y);
y = "Hello, TypeScript";
console.log(y);

if (typeof y === "number")
    console.log("y is number");
else if (typeof y === "string")
    console.log("y is string");
else
    console.log("y is boolean");

let sum: typeof y;

let strLenght: number = (<string>y).length;
strLenght = (y as string).length;

function add(x: number, y: number): number;
function add(x: string, y: string): string;
function add(x: any, y: any): any {
    return x + y;
}

let c: any = 25;
let d: any = "test";

console.log(add(1, 4));
console.log(add('Hello', "TypeScript"));
console.log(add(25 as any, "TypeScript"));

function getFullName(firstName: string, surname?: string): string {
    if (surname)
        return `${firstName} ${surname}`;
    else
        return firstName;
}

function getFullName2(firstName: string, surname: string = 'Shevchenko'): string {
    return `${firstName} ${surname}`;
}

console.log(getFullName("Roman"));
console.log(getFullName("Roman", "Tselik"));
console.log(getFullName2("Roman"));
console.log(getFullName2("Roman", "Tselik"));


// Function Type
let op: (a: number, b: number) => number;
op = add;
console.log(op(3, 4));


function mathOp(x: number, y: number, oper: (a, b: number) => number): number {
    let res: number = oper(x, y);
    return res;
}

function sub(arg1, arg2: number): number {
    return arg1 - arg2
}


console.log(mathOp(6, 8, add));
console.log(mathOp(6, 8, sub));
console.log(mathOp(6, 8, (arg1, arg2) => arg1 * arg2));


function showArguments(...args: any[]) {
    for (let arg of args) {
        console.log(arg);
    }
}

showArguments(3, 5, "awd");


class User {
    constructor(protected name: string, protected age: number) { }
    getInfo(): string {
        return `${this.name}, ${this.age} this years old`
    }
}

let user1 = new User("Roman", 18);
user1.getInfo();

class Employee extends User {
    constructor(protected name: string, protected age: number, public position: string) {
        super(name, age);
    }

    getInfo(): string {
        let res = `${super.getInfo()}\nPosition: ${this.position}`;
        return res;
    }

    public set Age(newVal: number) {
        this.age = newVal;
    }

    public get Age(): number {
        return this.age * 2;
    }
}

let developer = new Employee("Roman", 18, "Junior");
console.log(developer.position);
console.log(developer.getInfo());
developer.Age = 15;
console.log(developer.Age);

class Manager implements IUser {
    constructor(public id: number, public name: string, public age: number) {
    }
    getInfo(): string {
        return `${this.id}) Manager: ${this.name}, ${this.age}`
    }
}

function buildManager(id: number, name: string): IUser {
    return {
        id,
        name,
    }
}