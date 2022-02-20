a = int(input("Geef een geheel getal in: "))
b = int(input("Geef een tweede geheel getal in: "))
code = int(input("Geef een code van bewerking in: "))

if code == 1:
    print("Optelling van " + str(a) + " en " + str(b) + ": " + str(a+b))
elif code == 2:
    print("Aftrekking van " + str(a) + " en " + str(b) + ": " + str(a-b))
elif code == 3:
    print("Vermenigvuldiging van " + str(a) + " en " + str(b) + ": " + str(a * b))
elif code == 4:
    print("Kwadraat van " + str(a) + ": " + str(a * a))
elif code == 5:
    print("Kwadraat van " + str(b) + ": " + str(b * b))
else:
    print("Foutieve code!")