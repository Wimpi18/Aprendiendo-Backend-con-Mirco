IDataProcessor processor = new RawDataProcessor();
processor = new UpperCaseDecorator(new CensorshipDecorator(processor, ["overheating", "other"]));

string rawData = "alerta: sensor de temperatura overheating";
Console.WriteLine($"Result: {processor.Process(rawData)}");
