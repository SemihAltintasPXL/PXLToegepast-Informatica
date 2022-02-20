resultaat1 = int(input("Geef het resultaat van het eerste examen: "))
resultaat2 = int(input("Geef het resultaat van het tweede examen: "))
resultaat3 = int(input("Geef het resultaat van het derde examen: "))

percentage = (resultaat1 + resultaat2 + resultaat3) / 6 * 10

if percentage < 60:
    graad = "onvoldoende"
elif percentage < 70:
    graad = "voldoende"
elif percentage < 80:
    graad = "onderscheiding"
elif percentage < 90:
    graad = "grote onderscheiding"
else:
    graad = "grootste onderscheiding"

print("Percentage:", percentage, "\nGraad:", graad)