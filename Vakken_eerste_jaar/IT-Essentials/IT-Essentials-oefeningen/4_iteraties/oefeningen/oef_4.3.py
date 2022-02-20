# Lees een rij gehele getallen in en druk de som af.
# Deze rij eindigt met 0.
# Druk ook af hoeveel negatieve getallen er werden ingegeven.

aantal_neg = 0  # of teller negatief
som = 0
getal = int(input("Geef een getal in: "))
while getal != 0:
    som += getal
    if getal < 0:
        aantal_neg += 1
    getal = int(input("Geef een getal in: "))
print("De som van deze getallen is", som)
print("Aantal negatieve getallen:", aantal_neg)
