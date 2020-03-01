package CreationalDesignPatterns.PrototypePattern;

public class ColorPrototype implements IColorPrototype {
    private Color c;

    public Color getColor() {
        return c;
    }

    public void setColor(Color c) {
        this.c = c;
    }

    public ColorPrototype getClonedColor() {
        return (ColorPrototype)this.clone();
    }

    public Object clone() {
        try{
            return super.clone();
        } catch(CloneNotSupportedException e) {
            System.out.println(e);
            return null;
        }
    }
}
