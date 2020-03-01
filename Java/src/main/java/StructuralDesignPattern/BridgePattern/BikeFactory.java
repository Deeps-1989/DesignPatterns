package StructuralDesignPattern.BridgePattern;

public class BikeFactory implements IFactory {

    public void manufacture() {
        System.out.println("Manufacture Bike");
    }

    public void assemble() {
        System.out.println("Assemble Bike");
    }
}
