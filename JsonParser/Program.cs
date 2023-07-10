
namespace Parser.Json;

internal class TestObject {
    public string Name { get; set; }

    public int Value { get; set; }
}

internal static class Program {

    public static void Main() {

        JsonReader<TestObject>.Read<TestObject>("{\"name\": \"Hello\", \"value\": 200}");
        
        
    }
}