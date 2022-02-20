# Schrijf code die de oppervlakte van een cirkel berekent, gebruik makend van variabelen straal en pi = 3.14159.
# Voor het geval je het vergeten bent, de formule is  𝑠𝑡𝑟𝑎𝑎𝑙×𝑠𝑡𝑟𝑎𝑎𝑙×𝜋 .
# Toon de uitkomst als volgt: “De oppervlakte van een cirkel met straal ... is ...”.

PI = 3.1459

straal = float(input("Geef de straal van de circel op "))

opp_cirkel = ((straal * straal * PI))

print("De oppervlakte van een cirkel met straal", straal, "is", opp_cirkel)
