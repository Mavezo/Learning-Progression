class Car {
    constructor(protected licenceID: string, public plateID: string, public model: string, public brand: string) {

    }

    public getInfo(): string {
        return `Car:\nPlate: ${this.plateID}\nModel: ${this.model}\nBrand: ${this.brand}`;
    }
}


class PassengerCar extends Car {
    constructor(licenceID, plateID, model, brand: string) {
        super(licenceID, plateID, model, brand);
    }
    public getInfo(): string {
        return `Passenger Car:\nPlate: ${this.plateID}\nModel: ${this.model}\nBrand: ${this.brand}`;
    }
}

class Truck extends Car {
    constructor(licenceID, plateID, model, brand: string) {
        super(licenceID, plateID, model, brand);
    }
    public getInfo(): string {
        return `Truck:\nPlate: ${this.plateID}\nModel: ${this.model}\nBrand: ${this.brand}`;
    }
}

class RefrigeratedTruck extends Car {
    constructor(licenceID, plateID, model, brand: string) {
        super(licenceID, plateID, model, brand);
    }
    public getInfo(): string {
        return `Refrigerated Truck:\nPlate: ${this.plateID}\nModel: ${this.model}\nBrand: ${this.brand}`;
    }
}

//Passenger
let first: Car = new PassengerCar("LX5-9821", "ABC-1234", "Falcon X5", "Nova Motors");
let second: Car = new PassengerCar("OR7-4519", "XYZ-5678", "Orion Nova", "Skyline Auto");
console.log(first.getInfo());
console.log(second.getInfo());

//Truck
first = new Truck("T900-7762", "TRK-9876", "Titan 900", "HeavyLoad Inc.");
second = new Truck("M12T-3321", "TRK-5432", "Mammoth 12T", "RoadMaster");
console.log(first.getInfo());
console.log(second.getInfo());

//Refrigerator
first = new RefrigeratedTruck("AH7-2143", "REF-3746", "Arctic Hauler", "Polar Express");
second = new RefrigeratedTruck("FC3K-6622", "REF-1928", "FrostCarrier 3000", "ColdTransit");
console.log(first.getInfo());
console.log(second.getInfo());
