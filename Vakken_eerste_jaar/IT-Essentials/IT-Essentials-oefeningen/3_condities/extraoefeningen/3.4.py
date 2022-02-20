'''Een voetbalploeg uit eerste klasse wenst de prijs van zijn spelers in te schatten via volgend programma.

Invoer:

naam speler
prijs vorig seizoen
leeftijd
gemiddeld beoordelingscijfer van de sportjournalisten (cijfer tussen 0 en 10)
type speler ("Aanvaller", "Middenvelder", "Verdediger", "Doelman")
aantal doelpunten (bij de doelman is dit het aantal doelpunten dat hij niet heeft kunnen verijdelen, bij de anderen is dit het aantal doelpunten dat ze gescoord hebben).
Op basis van deze gegevens wordt de nieuwe prijs berekend.

Berekening nieuwe prijs:

Als basisprijs wordt de prijs van vorig seizoen genomen.
Als de speler jonger is dan 25 jaar, wordt deze basisprijs met 10% verhoogd. Als de speler ouder is dan 30 jaar, wordt deze basisprijs met 5% verlaagd. Bij spelers van 25 jaar t.e.m. 30 jaar oud wordt de basisprijs behouden.
Voor aanvallers geldt: voor de eerste 5 doelen, wordt de prijs met 10 000 euro per doel verhoogd, vanaf het zesde doel, wordt de prijs met 20 000 euro per doel verhoogd.
Voor middenvelders, verdedigers en doelmannen geldt: de prijs wordt verhoogd met 10 000 euro * beoordelingscijfer (bv. iemand met beoordeling 8, bekomt een prijsverhoging van 80 000 euro).
Voor doelmannen geldt bovendien: vanaf de 20ste goal die ze binnenlaten, daalt de prijs met 9 000 euro.
Druk af:

naam speler
prijs vorig seizoen
nieuwe prijs'''

naam_speler = input("Geef de naam van de speler in: ")
prijs_vorig_seizoen = int(input("Geef de prijs van het vorig seizoen in: "))
leeftijd = int(input("Geef de leeftijd in: "))
beoordeling = int(input("Gemiddelde beoordeling van de sportjournalisten (0-10): "))
type_speler = input("Geef de type in (Aanvaller, Middenvelder, Verdediger of Doelman) ")
aantal_doelpunten = int(input("Geef het aantal doelpunten in: "))

prijs = prijs_vorig_seizoen

if leeftijd < 25:
    prijs *= 1.1

elif leeftijd > 30:
    prijs *= 0.95

if type_speler == "Aanvaller":
    if aantal_doelpunten <= 5:
        prijs += aantal_doelpunten * 10000
    else:
        prijs += 10000 * 5 + (aantal_doelpunten - 5) * 20000

else:  # elif type_speler == "Middenvelder" or type_speler == "Verdediger" or type_speler == "Doelman":
    prijs += 10000 * beoordeling

if type_speler == "Doelman" and aantal_doelpunten >= 20:
    prijs -= 9000

print("Naam:", naam_speler)
print("prijs vorig seizoen:", prijs_vorig_seizoen)
print("prijs nieuw seizoen:", prijs)
