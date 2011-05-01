import System
import Boo.Lang.Compiler
import Boo.Lang.Compiler.Ast

class ExibirAttribute(AbstractAstAttribute):
    override def Apply(node as Node):
        parameterName = (node as ParameterDeclaration).Name
        parameter = ReferenceExpression(parameterName)
        exibir = [| print "${$parameterName} = ${$parameter}" |]
        (node.ParentNode as Method).Body.Insert(0, exibir)           