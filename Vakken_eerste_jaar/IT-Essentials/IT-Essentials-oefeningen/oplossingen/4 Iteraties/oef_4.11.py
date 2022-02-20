personeelsnummer = int(input("Personeelsnummer: "))
aantal_mannen = 0
aantal_vrouwen = 0

while personeelsnummer > 0:
    geslacht = int(input("man = 1, vrouw = 0: "))
    while geslacht != 0 and geslacht != 1:
        geslacht = int(input("man = 1, vrouw = 0: "))
    leeftijd = int(input("leeftijd: "))
    brutoloon = int(input("brutoloon: "))
    if geslacht == 1:
        if leeftijd > 34 or brutoloon > 1800:
            aantal_mannen = aantal_mannen + 1
    elif leeftijd < 25:
        aantal_vrouwen = aantal_vrouwen + 1
    personeelsnummer = int(input("Personeelsnummer: "))

print("het aantal mannelijke personen...:", aantal_mannen)
print("het aantal vrouwelijke personen...:", aantal_vrouwen)
