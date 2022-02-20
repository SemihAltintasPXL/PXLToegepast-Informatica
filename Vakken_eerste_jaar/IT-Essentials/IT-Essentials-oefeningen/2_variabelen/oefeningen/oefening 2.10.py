# Kun je een manier bedenken om de inhoud van twee numerieke variabelen om te wisselen zonder daarbij gebruik te maken van een derde hulp-variabele?

a = int(input("geef een getal: "))
b = int(input("geef een getal: "))

print("a =", a, "b =", b)

a = a + b
b = a - b
a = a - b

print("a =", a, "b =", b)
