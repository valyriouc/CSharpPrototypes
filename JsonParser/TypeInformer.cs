
namespace Parser.Common;

public class TypeInformer {

    protected bool IsList(Type type) => 
        type == typeof(List<>);
    

}