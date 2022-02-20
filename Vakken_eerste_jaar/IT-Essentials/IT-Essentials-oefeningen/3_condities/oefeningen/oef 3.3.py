'''Bereken de aankomsttijd van een vlucht.
De vertrektijd (uren en minuten in 2 verschillende variabelen) en de duur in minuten worden ingevoerd.
 Vb. vertrekuur = 22, vertrekminuut = 18, duur = 170, het aankomstuur wordt 1, de aankomstminuut wordt 8.'''

vertrekuur = int(input("Voer het vertrekuur in: "))
vertrekminuut = int(input("Voer het vertrekminuut in: "))
duur = int(input("Voer de duur in minuten in: "))

aankomstuur = (vertrekuur + (duur // 60)) % 24

aankomstminuut = (vertrekminuut + (duur % 60)) % 60

print(aankomstuur, aankomstminuut)
