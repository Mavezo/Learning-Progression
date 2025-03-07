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
var Car = /** @class */ (function () {
    function Car(licenceID, plateID, model, brand) {
        this.licenceID = licenceID;
        this.plateID = plateID;
        this.model = model;
        this.brand = brand;
    }
    Car.prototype.getInfo = function () {
        return "Car:\nPlate: ".concat(this.plateID, "\nModel: ").concat(this.model, "\nBrand: ").concat(this.brand);
    };
    return Car;
}());
var PassengerCar = /** @class */ (function (_super) {
    __extends(PassengerCar, _super);
    function PassengerCar(licenceID, plateID, model, brand) {
        return _super.call(this, licenceID, plateID, model, brand) || this;
    }
    PassengerCar.prototype.getInfo = function () {
        return "Passenger Car:\nPlate: ".concat(this.plateID, "\nModel: ").concat(this.model, "\nBrand: ").concat(this.brand);
    };
    return PassengerCar;
}(Car));
var Truck = /** @class */ (function (_super) {
    __extends(Truck, _super);
    function Truck(licenceID, plateID, model, brand) {
        return _super.call(this, licenceID, plateID, model, brand) || this;
    }
    Truck.prototype.getInfo = function () {
        return "Truck:\nPlate: ".concat(this.plateID, "\nModel: ").concat(this.model, "\nBrand: ").concat(this.brand);
    };
    return Truck;
}(Car));
var RefrigeratedTruck = /** @class */ (function (_super) {
    __extends(RefrigeratedTruck, _super);
    function RefrigeratedTruck(licenceID, plateID, model, brand) {
        return _super.call(this, licenceID, plateID, model, brand) || this;
    }
    RefrigeratedTruck.prototype.getInfo = function () {
        return "Refrigerated Truck:\nPlate: ".concat(this.plateID, "\nModel: ").concat(this.model, "\nBrand: ").concat(this.brand);
    };
    return RefrigeratedTruck;
}(Car));
//Passenger
var first = new PassengerCar("LX5-9821", "ABC-1234", "Falcon X5", "Nova Motors");
var second = new PassengerCar("OR7-4519", "XYZ-5678", "Orion Nova", "Skyline Auto");
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
//# sourceMappingURL=main.js.map