# schrijf een programma dat een getal inleest en dan het getal en het kwadraat afdrukt
# herhaal did to het ingelezen getal gelijk is aan 0

getal = int(input("geef een getal in"))
while getal != 0:
    print(getal, "heeft als kwadraat", getal * getal)
    getal = int(input("geef een getal in"))
