using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boo.Lang.Compiler;
using Boo.Lang.Compiler.Pipelines;
using Boo.Lang.Compiler.IO;

namespace ExampleFormBuilder
{
    public class DefinitionCompiler
    {
        static BooCompiler boo = GetCompiler();

        private static BooCompiler GetCompiler()
        {
            var boo = new BooCompiler();
            boo.Parameters.Pipeline = new CompileToMemory();
            boo.Parameters.References.Add(typeof(IFormDefinition).Assembly);
            return boo;
        }

        public IFormDefinition Compile(string script)
        {
            boo.Parameters.Input.Clear();
            boo.Parameters.Input.Add(new StringInput("test", script));
            var compiler = boo.Run();
            if (compiler.Errors.Count > 0)
                throw compiler.Errors[0];

            var assembly = compiler.GeneratedAssembly;
            var type = assembly.GetType("FormDefinition");
            return (IFormDefinition)Activator.CreateInstance(type);
        }
    }
}
