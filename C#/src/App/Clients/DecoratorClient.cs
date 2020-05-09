using System;
using App.Common;
using Patterns.DecoratorPattern;

namespace App.Clients
{
    public class DecoratorClient : IClient
    {
        public void Execute()
        {
          ITea tea = new Tea();
          // Make a simple tea
          Console.WriteLine(Environment.NewLine);
          Console.WriteLine(tea.GetDescription() + " is " + tea.GetCost());

          // Decorate the tea with extra milk
          tea = new WithExtraMilk(tea);

          Console.WriteLine(tea.GetDescription() + " is " + tea.GetCost());

          tea = new WithExtraSugar(tea);

          Console.WriteLine(tea.GetDescription() + " is " + tea.GetCost());
        }
    }
}