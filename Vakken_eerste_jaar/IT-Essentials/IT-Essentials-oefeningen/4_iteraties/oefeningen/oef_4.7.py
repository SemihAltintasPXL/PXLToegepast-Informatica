'''Lees via het toetsenbord de temperatuur gemeten om 12u ’s middags in van 10 dagen. Gevraagd een afdruk van:

de hoogste temperatuur voor deze 10 dagen
de gemiddelde temperatuur voor deze 10 dagen'''
som = 0
hoogste = -100  # gekozen voor een zeer lage temperatuur om zeker te zijn dat je geen lager getal dan dit invoert,
# omdat je ook negatieve temperaturen kan ingeven mag je het niet initialiseren op 0
# anders kan het zijn dat je grootste waarde 0 is nadat je enkel negetieve getallen hebt ingegeven, terwijl je 0 zelf niet hebt ingevoert.

for i in range(10):
    temperatuur = int(input("geef de temperatuur om 12u 's middags (voor 10 dagen) "))
    som += temperatuur
    if temperatuur > hoogste:
        hoogste = temperatuur

gemiddelde = som / 10
print("De gemiddelde temperatuur van deze 10 dagen is ", gemiddelde, "°C")
print("De hoogste temperatuur voor deze 10 dagen is ", hoogste, "°C")
