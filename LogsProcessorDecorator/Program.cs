using System.Reflection;

IDataProcessor processor = new RawDataProcessor();
IDataProcessor miDecorator = new UpperCaseDecorator(processor);
Type decoratorType = miDecorator.GetType();
var attribute = decoratorType.GetCustomAttribute<ProcessorCategoryAttribute>();

if (attribute != null)
    Console.WriteLine(attribute.Category);
