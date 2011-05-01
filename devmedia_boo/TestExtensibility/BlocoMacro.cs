using System;
using Boo.Lang.Compiler;
using Boo.Lang.Compiler.Ast;

public class BlocoMacro : AbstractAstMacro
{
    public override Statement Expand(MacroStatement macro)
    {
        var method = typeof(Console).GetMethod("WriteLine",
            new[] { typeof(string), typeof(object) });

        var call1 = CodeBuilder.CreateMethodInvocation(method,
            CodeBuilder.CreateStringLiteral(">>> entrando no bloco {0}"), macro.Arguments[0]);

        var call2 = CodeBuilder.CreateMethodInvocation(method,
            CodeBuilder.CreateStringLiteral(">>> saindo do bloco  {0}"), macro.Arguments[0]);

        macro.Body.Insert(0, call1);
        macro.Body.Insert(macro.Body.Statements.Count, call2);

        return macro.Body;
    }
}
