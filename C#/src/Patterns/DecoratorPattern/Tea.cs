namespace Patterns.DecoratorPattern
{
  public class Tea : ITea {

    public double GetCost() {
      return 3;
    }

    public string GetDescription() {
      return "Simple Tea";
    }
  }
}