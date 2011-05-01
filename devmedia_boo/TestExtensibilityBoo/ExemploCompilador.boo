namespace TestExtensibilityBoo

import System
import Boo.Lang.Compiler
import Boo.Lang.Compiler.Pipelines
import Boo.Lang.Compiler.IO

class ExemploCompilador:
	def exemplo():
        boo = BooCompiler()
        boo.Parameters.Input.Add(FileInput("script.boo"))
        boo.Parameters.Pipeline = CompileToMemory()
        
        assembly = boo.Run().GeneratedAssembly
        
