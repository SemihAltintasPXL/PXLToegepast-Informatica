geslacht = int(input("geef het geslacht in (1=man,2=vrouw) "))
teller = 0
aantal_mannen = 0
aantal_vrouwen = 0
while geslacht >= 1 and geslacht <= 2:
    afstand = int(input("Geef de afstand in km na 12 minuten lopen in "))
    conditie_getal = ((afstand * 1000) - 504.9) / 44.73
    teller += 1
    if geslacht == 1 and conditie_getal < 36:
        aantal_mannen += 1
    elif geslacht == 2 and conditie_getal < 29:
        aantal_vrouwen += 1
    geslacht = int(input("geef het geslagt in (1=man,2=vrouw)"))

percentage = ((aantal_vrouwen + aantal_mannen) / teller) * 100
print("Het percentage van de werknemers in slechte conditie is", percentage, "%")
