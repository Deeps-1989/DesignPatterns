package StructuralDesignPattern.BridgePattern;

public class Client {
    public static void main(String args[]) {
        CarFactory cf = new CarFactory();
        Car c = new Car(cf);
        c.assemble();
    }
}
