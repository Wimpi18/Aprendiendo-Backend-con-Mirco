IDataProcessor processor = new RawDataProcessor();

string rawData = "error: sensor 04 overheating";
Console.WriteLine($"Result: {processor.Process(rawData)}");
