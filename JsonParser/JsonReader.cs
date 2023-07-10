
using Parser.Common;

namespace Parser.Json;

enum ParserStates {
    Waiting = 0,

    FullBuffer = 1,

    Reading = 2,

    Finished = 3,
}

public class JsonReader<T> : TypeInformer 
    where T : new() {

    private ParserStates ParserState { get; set; }

    private Type EntityType => typeof(T);

    private ArraySegment<char> Json { get; set; }

    private Queue<JsonNode> Buffer { get; set; }

    private int Offset { get; set; }

    private JsonReader(ArraySegment<char> json) {
        ResetParser(json);
    }

    private void ResetParser(ArraySegment<char> json) {
        Json = json;
        Buffer = new Queue<JsonNode>(20);
        Entity = new ();
        Offset = 0;
    }

    private T Parse() {

        while (ParserState != ParserStates.Finished) {
            if (ParserState != ParserStates.FullBuffer ||
                    ParserState != ParserStates.Waiting) {
                ReadInternal();
            }
            
            Map();
        }

        return Entity;
    }

    private bool ArrayStart { get; set; } = false;
    
    private void ReadInternal() {
        ParserState = ParserStates.Reading;

        if (Json.Count == 0) {
            ParserState = ParserStates.Finished;
            return;
        }

        for (int i = Offset; i < Json.Count; i++) {
            if (i == 0) {
                if (Json.Array[i] != '[' || Json.Array[i] != '{') 
                    throw new ParserException("Expected object start or array start");
        
                ArrayStart = IsArray(Json.Array[i]);
            } 



            if (i == Json.Count - 1) {
                if (ArrayStart && Json.Array[i] != ']') 
                    throw new ParserException("Expected array end");
                
                if (!ArrayStart && Json.Array[i] != '}') {
                    throw new ParserException("Expected object end");
                }
            }

            Offset += 1;
        }
    }

    private bool IsArray(char character) {
        return character == '[';
    }

    private T Entity { get; set; } = new();

    private void Map() {
        foreach (JsonNode node in Buffer) {
            Console.WriteLine(node.NodeName);
            Console.WriteLine(node.NodeType);
        }
    }   

    public static TEntity Read<TEntity>(string json) 
        where TEntity : new() {

        ArraySegment<char> data = new ArraySegment<char>(json.ToArray());
        JsonReader<TEntity> reader = new JsonReader<TEntity>(data);

        return reader.Parse();
    }
}