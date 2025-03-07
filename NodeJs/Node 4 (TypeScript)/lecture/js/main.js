var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var MyUser = (function () {
    function MyUser(age) {
        this.age = age;
    }
    MyUser.prototype.sayHello = function () {
        console.log("Id: ".concat(this.id, ", Name: ").concat(this.name, ", Age: ").concat(this.age));
    };
    return MyUser;
}());
var user = new MyUser(18);
user.name = "Roman";
user.id = 1;
var d1 = document.getElementById("d1");
if (d1)
    d1.innerText = "".concat(user.name, ", ").concat(user.id);
var x = 56;
var firstName = "Roman";
var ifAdmin = true;
var a;
a = "3243";
a = 3243;
var names = ["Roman", "Serhii", "Bart"];
var ages = [18, 20, 19];
var person = [names[0], ages[0]];
var persons = [];
names.forEach(function (element, index) {
    persons.push([element, ages[index]]);
});
var Seasons;
(function (Seasons) {
    Seasons[Seasons["Winter"] = 0] = "Winter";
    Seasons[Seasons["Spring"] = 1] = "Spring";
    Seasons[Seasons["Summer"] = 2] = "Summer";
    Seasons[Seasons["Autumn"] = 3] = "Autumn";
})(Seasons || (Seasons = {}));
;
var currentSeasons = Seasons.Spring;
console.log(currentSeasons);
console.log(Seasons[currentSeasons]);
console.log(Seasons[Seasons.Spring]);
var y = 67;
console.log(y);
y = "Hello, TypeScript";
console.log(y);
if (typeof y === "number")
    console.log("y is number");
else if (typeof y === "string")
    console.log("y is string");
else
    console.log("y is boolean");
var sum;
var strLenght = y.length;
strLenght = y.length;
function add(x, y) {
    return x + y;
}
var c = 25;
var d = "test";
console.log(add(1, 4));
console.log(add('Hello', "TypeScript"));
console.log(add(25, "TypeScript"));
function getFullName(firstName, surname) {
    if (surname)
        return "".concat(firstName, " ").concat(surname);
    else
        return firstName;
}
function getFullName2(firstName, surname) {
    if (surname === void 0) { surname = 'Shevchenko'; }
    return "".concat(firstName, " ").concat(surname);
}
console.log(getFullName("Roman"));
console.log(getFullName("Roman", "Tselik"));
console.log(getFullName2("Roman"));
console.log(getFullName2("Roman", "Tselik"));
var op;
op = add;
console.log(op(3, 4));
function mathOp(x, y, oper) {
    var res = oper(x, y);
    return res;
}
function sub(arg1, arg2) {
    return arg1 - arg2;
}
console.log(mathOp(6, 8, add));
console.log(mathOp(6, 8, sub));
console.log(mathOp(6, 8, function (arg1, arg2) { return arg1 * arg2; }));
function showArguments() {
    var args = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        args[_i] = arguments[_i];
    }
    for (var _a = 0, args_1 = args; _a < args_1.length; _a++) {
        var arg = args_1[_a];
        console.log(arg);
    }
}
showArguments(3, 5, "awd");
var User = (function () {
    function User(name, age) {
        this.name = name;
        this.age = age;
    }
    User.prototype.getInfo = function () {
        return "".concat(this.name, ", ").concat(this.age, " this years old");
    };
    return User;
}());
var user1 = new User("Roman", 18);
user1.getInfo();
var Employee = (function (_super) {
    __extends(Employee, _super);
    function Employee(name, age, position) {
        var _this = _super.call(this, name, age) || this;
        _this.name = name;
        _this.age = age;
        _this.position = position;
        return _this;
    }
    Employee.prototype.getInfo = function () {
        var res = "".concat(_super.prototype.getInfo.call(this), "\nPosition: ").concat(this.position);
        return res;
    };
    return Employee;
}(User));
var developer = new Employee("Roman", 18, "Junior");
console.log(developer.position);
console.log(developer.getInfo());
//# sourceMappingURL=main.js.map