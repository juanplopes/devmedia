import System;
import System.Linq.Enumerable;

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

Console.ReadKey();