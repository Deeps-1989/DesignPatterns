package StructuralDesignPattern.BridgePattern;

public abstract class Vehicle {
    public String Name;
    public IFactory factory;
}

class Car extends Vehicle {

    public Car(IFactory factory){
        this.factory = factory;
    }

    public void assemble() {
        factory.assemble();
    }
}

class Bike extends Vehicle {

    public Bike(IFactory factory) {
        this.factory = factory;
    }

    public void assemble() {
        factory.assemble();
    }
}