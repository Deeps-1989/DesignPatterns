using System;
using App.Common;
using Microsoft.Extensions.CommandLineUtils;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CommandLineApplication();
            app.Name = "Implementing Design Patterns using C#";
            app.HelpOption("-?|-h|--help");
            
            var clientPatternName = app.Option(
                "-s | --source", "Client Pattern to run, usually it is the client class name",
                CommandOptionType.SingleValue);

            app.OnExecute(async () =>
            {
                if (clientPatternName.HasValue())
                {
                    try
                    {
                        var clientExecutor = new ClientExecutor();
                        clientExecutor.ExecutePattern(clientPatternName.Value());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Failed to execute script {e.Message}");
                    }

                    return 0;
                }

                app.ShowHelp();
                return 1;
            });
            app.Execute(args);
        }
    }
}