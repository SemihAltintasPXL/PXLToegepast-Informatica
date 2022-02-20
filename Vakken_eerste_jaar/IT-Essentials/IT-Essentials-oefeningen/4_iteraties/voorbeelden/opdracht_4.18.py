# Belangrijk!!!! invoercontrole ingegeven getal moet tussen 0 en 10 liggen (grenzen exclusief)
# invoercontrole steeds while gebruiken NOOIT een if want je bent niet zeker dat de gebruiker de 2de keer nu wel een juist getal intikt

getal = int(input("geef een getal tussen 0 en 10 in"))
while getal <= 0 or getal >= 10:  # of not(getal > 0 and getal <10)
    getal = int(input("foutief getal, geef het opnieuw in"))
