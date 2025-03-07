interface IUser {
    id: number;
    name: string;
}
class MyUser implements IUser {
    id: number;
    name: string;
    private age: number;
    constructor(age: number){
        this.age = age;
    }

    sayHello(): void {
        console.log(`Id: ${this.id}, Name: ${this.name}, Age: ${this.age}`);
                
    }
}