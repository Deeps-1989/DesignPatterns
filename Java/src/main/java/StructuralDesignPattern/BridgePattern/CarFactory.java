package StructuralDesignPattern.BridgePattern;

public class CarFactory implements IFactory {

    public void manufacture() {
        System.out.println("Manufacture Car");
    }

    public void assemble() {
        System.out.println("Assemble Car");
    }
}
