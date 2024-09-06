using AirplaneAndCarRacing;

var airplan = new Airplan("Airplan", "White");
var car = new Car("Car", "Red");

await Task.WhenAll(airplan.Race(), car.Race());