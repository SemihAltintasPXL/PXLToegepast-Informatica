'''De resultaten van een student behaald op 3 verschillende examens, moeten via het toetsenbord ingegeven worden.
Deze resultaten staan op 20 en alleen gehele punten worden gegeven.
Bepaal het behaald percentage van deze student en geef hiervan een afdruk weer samen met zijn behaalde graad.

< 60% onvoldoende
< 70% voldoende
< 80% onderscheiding
< 90% grote onderscheiding
≥ 90% grootste onderscheiding'''

resultaat1 = int(input("Geef het eerste resultaat in op 20 "))
resultaat2 = int(input("Geef het tweede resultaat in op 20 "))
resultaat3 = int(input("Geef het derde resultaat in op 20 "))

totaal = ((resultaat1 + resultaat2 + resultaat3) / 60) * 100

if totaal < 60:
    print(totaal, "onvoldoende")
elif totaal < 70:
    print(totaal, "onvoldoende")
elif totaal < 80:
    print(totaal, "onderscheiding")
elif totaal < 90:
    print(totaal, "grote onderscheiding")
else:
    print(totaal, "grootste onderscheiding")
