''' De eenheidsprijs van een bepaald artikel is €11,5.
 Het btwPercentage bedraagt 21%. Vraag de klant hoeveel artikels hij wil bestellen.
Op de totale prijs inclusief BTW wordt een reductie van 10% gegeven indien het bedrag hoger is dan 1.000 euro.
 Toon het bedrag dat de klant moet betalen.'''

EENHEIDSPRIJS = 11.5
btw = (11.5 / 100) * 21
prijs_inclusief_btw = EENHEIDSPRIJS + btw

aantal_artikels = int(input(print("Hoeveel artikels wilt u bestellen?")))
totale_prijs = prijs_inclusief_btw * aantal_artikels

if totale_prijs > 1000:
    print("Het bedrag dat je moet betalen is:", int(((totale_prijs / 100) * 90) * 100) / 100, "euro")
else:
    print("Het bedrag dat je moet betalen is:", int(totale_prijs * 100) / 100, "euro")

