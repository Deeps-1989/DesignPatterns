package CreationalDesignPatterns.PrototypePattern;

public class ColorStore {
    private IColorPrototype colorPrototype;

    public ColorStore(IColorPrototype colorPrototype) {
        this.colorPrototype = colorPrototype;
    }

    public void setColorPrototype(Color c) {
        colorPrototype.setColor(c);
    }

    public IColorPrototype getClonedColor() {
        return colorPrototype.getClonedColor();
    }

}
