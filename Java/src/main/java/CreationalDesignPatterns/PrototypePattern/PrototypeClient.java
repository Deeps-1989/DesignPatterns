package CreationalDesignPatterns.PrototypePattern;

public class PrototypeClient {
    public static void main(String args[]) {
        ColorPrototype cp1 = new ColorPrototype();
        ColorStore cs = new ColorStore(cp1);
        cs.setColorPrototype(Color.Black);
        IColorPrototype cp = cs.getClonedColor();
        System.out.println(cp.getColor());
    }
}
