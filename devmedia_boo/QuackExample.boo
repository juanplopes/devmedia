class QuackExample(IQuackFu):
    def QuackGet(name as string, args as (object)):
        print "Tentando obter valor de ${name}"
    
    def QuackSet(name as string, args as (object), value):
        print "Tentando atribuir ${value} a ${name}"

    def QuackInvoke(name as string, args as (object)):
        print "${name} foi chamado"        

