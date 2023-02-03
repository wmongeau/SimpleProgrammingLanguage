public class SimpleVisitor : SimpleBaseVisitor<object?>
{

    public Dictionary<string, object?> Variables { get; } = new();

    public override object? VisitAssignment(SimpleParser.AssignmentContext context)
    {
        var varName = context.IDENTIFIER().GetText();
        Console.WriteLine(varName);
        var value = Visit(context.expression());
        Console.WriteLine(value);

        Variables[varName] = value;

        return null;
    }
}
