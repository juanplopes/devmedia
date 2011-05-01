macro bloco(nome as string):
    return [|
        print "entrando no bloco ${$nome}"
        $(bloco.Body)
        print "saindo do bloco ${$nome}"
    |]

