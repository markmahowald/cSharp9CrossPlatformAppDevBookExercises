using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace insturmenting
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Debug says \"I am Watching!\"");
            Trace.WriteLine("Trace says \"I am Watching!\"");
            
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says \"I am Watching!\"");
            Trace.WriteLine("Trace says \"I am Watching!\"");

            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            var ts = new TraceSwitch(
                displayName: "PacktSwitch"
                , description: "This switch is set via JSON Config"
            );
            configuration.GetSection("PacktSwitch").Bind(ts);
            Trace.WriteIf(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "TraceWarning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
        }
    }
}
