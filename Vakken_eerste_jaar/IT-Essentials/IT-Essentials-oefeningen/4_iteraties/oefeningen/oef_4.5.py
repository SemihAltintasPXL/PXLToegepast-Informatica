'''Schrijf een programma dat een getal tussen 1 en 100 opvraagt.
Zorg ervoor dat elke foutieve invoer geweigerd wordt.
Telkens een verkeerde invoer gebeurt dient er op het scherm een foutboodschap te verschijnen.
Ofwel “Fout! Het getal moet groter zijn dan 1” ofwel, “Fout! Het getal moet kleiner zijn dan 100”.
Het programma stopt als er een juiste invoer gedaan is.
Het getal wordt dan weergegeven op het scherm.'''

getal = int(input("Geef een getal in tussen 1 en 100 "))
while getal >= 100 or getal <= 1:
    if getal >= 100:
        print("Fout! Het getal moet kleiner zijn dan 100")
    else:
        print("Fout! Het getal moet groter zijn dan 1")
    getal = int(input("Geef een getal in tussen 1 en 100 "))
print(getal)
