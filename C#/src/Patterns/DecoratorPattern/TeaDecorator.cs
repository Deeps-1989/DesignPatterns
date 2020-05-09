using System;
namespace Patterns.DecoratorPattern
{
  public abstract class TeaDecorator : ITea {

    private readonly ITea tea;
    public TeaDecorator(ITea tea) {
      this.tea = tea;
    } 

    public virtual double GetCost() {
      var cost = tea.GetCost();
      return cost;
    }

    public virtual string GetDescription() {
      return tea.GetDescription();
    }
  }
}