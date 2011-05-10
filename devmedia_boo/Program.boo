import System;
import System.Linq.Enumerable;

def teste_atributo([exibir]a, [exibir]b):
    print "abc"

#exemplo1
print "Hello World"

#exemplo2
if 2+2==4:
    print "Um bloco"
else:
    print "Outro bloco"

#exemplo3
def dois_mais_dois:
    return 2+2

quatro = dois_mais_dois()
#print quatro.Substring(2)

#exemplo4
pares = i for i in range(1000) if i % 2 == 0
print join(pares.Take(5))

#exemplo5
bloco "teste":
    print "estou dentro do bloco!"

#exemplo6
teste_atributo(123, null)

#exemplo7
str = "Hello World!"
duck_obj as duck = str
#duck_obj.some_method() #falhará, pois String não contém some_method

#exemplo8
obj = QuackExample()
obj.metodo_exemplo()
obj.propriedade_exemplo = 2
print obj.propriedade_exemplo

Console.ReadKey();
