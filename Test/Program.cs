var connectors = new List<Connector>{
    new Connector("Test1", 100),
    new Connector("Test2", 400),
    new Connector("Test3", 50),
    new Connector("Test4", 215),
    new Connector("Test5", 50),
    new Connector("Test6", 15),
    new Connector("Test7", 400),
    new Connector("Test8", 10)
};

var countTagsByLicense = 600;
var countStartedTags = 0;
var counterAdditional = 0;

foreach (var connector in connectors)
{
    counterAdditional = countStartedTags + connector.TagsCount;

    if (countStartedTags <= countTagsByLicense && counterAdditional <= countTagsByLicense && countTagsByLicense != 0)
    {
        countStartedTags += connector.TagsCount;
    }
    else
    {
        Console.WriteLine($"StopService {connector.Name}");
    }
}

Console.WriteLine("Конец");


public class Connector
{
    public string Name { get; set; }
    public int TagsCount { get; set; }

    public Connector(string name, int tagsCount)
    {
        Name = name;
        TagsCount = tagsCount;
    }
}