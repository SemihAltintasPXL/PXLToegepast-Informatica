EENHEIDSPRIJS = 11.5

aantal = int(input("Hoeveel artikels wil u bestellen? "))

totale_prijs = EENHEIDSPRIJS * aantal * 1.21

if totale_prijs > 1000:
    totale_prijs *= 0.9

print("U moet", int(totale_prijs * 100 + 0.5) / 100, "euro betalen.")