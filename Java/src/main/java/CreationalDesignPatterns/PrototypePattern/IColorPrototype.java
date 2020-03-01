package CreationalDesignPatterns.PrototypePattern;

public interface IColorPrototype extends Cloneable {
    void setColor(Color c);
    ColorPrototype getClonedColor();
    Color getColor();
}
