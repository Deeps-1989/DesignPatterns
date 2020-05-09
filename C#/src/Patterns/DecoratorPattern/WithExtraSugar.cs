namespace Patterns.DecoratorPattern
{
  public class WithExtraSugar : TeaDecorator {

    public WithExtraSugar(ITea t) : base(t) {
    }

    public override double GetCost() {
      return base.GetCost() + 0.5;
    }

    public override string GetDescription() {
      return base.GetDescription() + " with extra sugar";
    }
  }
}