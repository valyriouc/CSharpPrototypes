
namespace Parser.Json;

internal class JsonNode {
    
    public JsonTypes NodeType { get; init; }

    public string NodeName { get; init; } = null!;

    public object NodeValue { get; init; }

    public JsonNode(
        JsonTypes nodeType, 
        string nodeName, 
        object nodeValue) {

            NodeType = nodeType;
            NodeName = nodeName;
            NodeValue = nodeValue;
    }
}