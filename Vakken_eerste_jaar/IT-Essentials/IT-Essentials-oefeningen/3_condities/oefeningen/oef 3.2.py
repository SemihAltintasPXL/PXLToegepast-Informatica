'''Geef via het toetsenbord het brutoloon van een werknemer in.
 Gevraagd wordt het jaarlijks vakantiegeld en de jaarlijkse bijdrage te berekenen en af te drukken.
 Het vakantiegeld is 5% van dit brutoloon. Is dit vakantiegeld minstens 350 euro dan is de jaarlijkse bijdrage gelijk aan 8% van 350 euro.
 Is dit vakantiegeld kleiner dan 350 euro dan is de jaarlijkse bijdrage 8% van het vakantiegeld. Druk af voor deze werknemer:

brutoloon
vakantiegeld
jaarlijkse bijdrage'''

brutoloon = int(input("Geef het brutoloon van een werknemer in "))
vakantiegeld = (brutoloon / 100) * 5
jaarlijkse_bijdrage = (350 / 100) * 8
print("Dit is de het vakantiegeld:", vakantiegeld)

if vakantiegeld >= 350:
    print(("De jaarlijkse bijdrage = "), jaarlijkse_bijdrage)

# jaarlijkse_bijdrage = (vakantiegeld / 100)
else:
    print("De jaarlijkse bijdrage= ", (vakantiegeld / 100) * 8)
