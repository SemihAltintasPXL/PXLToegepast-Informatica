'''Via het toetsenbord worden 2 gehele getallen a en b en een bewerkingscode code ingegeven. De bewerkingscode biedt de volgende mogelijkheden:

code 1: optelling (a+b)
code 2: aftrekking (a-b)
code 3: vermenigvuldiging (a×b)
code 4: kwadraat van a
code 5: kwadraat van b
Men wenst voor de ingevoerde getallen a en b, de via de code opgegeven bewerking uit te voeren, en het resultaat samen met de ingevoerde getallen af te drukken.
Indien een code ingevoerd wordt die niet beantwoordt aan één van bovenvermelde bewerkingscodes, moet volgende boodschap “Foutieve code” afgedrukt worden.'''

a = int(input("Geef een geheel getal in: "))
b = int(input("Geef nog een geheel getal in: "))
code = int(input("Geef een code van bewerking in: "))

if code == 1:
    print("Optelling van ", a, " en ", b, ": ", a + b)
elif code == 2:
    print("Aftrekking van ", a, " en ", b, ": ", a - b)
elif code == 3:
    print("Vermenigvuldiging van ", a, " en ", b, ": ", (a * b))
elif code == 4:
    print("Kwadraat van ", a, ": ", (a * a))
elif code == 5:
    print("Kwadraat van ", b, ": ", (b * b))
else:
    print("Foutieve code!")
