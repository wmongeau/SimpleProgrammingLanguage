using Antlr4.Runtime;

var fileName = "Content/test.ss";

var fileContents = File.ReadAllText(fileName);

AntlrInputStream inputStream = new AntlrInputStream(fileContents);
var simpleLexer = new SimpleLexer(inputStream);
CommonTokenStream commonTokenStream = new CommonTokenStream(simpleLexer);
SimpleParser simpleParser = new SimpleParser(commonTokenStream);
var context = simpleParser.program();
SimpleVisitor simpleVisitor = new SimpleVisitor();
simpleVisitor.Visit(context);


