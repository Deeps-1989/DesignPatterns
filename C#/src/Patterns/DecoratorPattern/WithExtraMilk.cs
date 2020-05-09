using System;
namespace Patterns.DecoratorPattern
{
  public class WithExtraMilk : TeaDecorator {

    public WithExtraMilk(ITea t) : base(t) {
    }

    public override double GetCost() {
      return base.GetCost() + 0.75;
    }

    public override string GetDescription() {
      return base.GetDescription() + " with extra milk";
    }
  }
}