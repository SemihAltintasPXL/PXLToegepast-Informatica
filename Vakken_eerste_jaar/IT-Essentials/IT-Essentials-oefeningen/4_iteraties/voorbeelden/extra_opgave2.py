# lees een rij getallen in. 99999 om te eindigen
# bereken het gemiddelde van deze getallen
# bereken het grootste getal
# bereken het percentage negatieve getallen

teller = 0  # om het aantel ingegeven getallen te tellen
teller_negatief = 0  # om het aantal negatieve getallen te tellen
som = 0
getal = int(input("geef een getal in "))
grootste = getal
while getal != 99999:
    teller += 1  # of teller = teller +1
    som += getal
    if getal > grootste:
        grootste = getal
    if getal <= 0:  # 0 is zowel positief als negatief --> strikt negatief: getal < 0
        teller_negatief += 1
    getal = int(input("geef een getal in "))
gemiddelde = som / teller  # gemiddelde berekenen altijd buiten de lus
print("het gemiddelde van deze getallen is", gemiddelde)
print("het grootste getal is", grootste)
percentage_negatief = teller_negatief / teller * 100  # percentage berekenen altijd buiten de lus
print("het percentage negatieve getallen" + str(percentage_negatief) + "%")
