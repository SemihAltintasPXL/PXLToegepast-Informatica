# Voer je lengte (in m) en gewicht (in kg) in via het toetsenbord.
# Bereken je BMI en druk af. Je BMI wordt als volgt berekend:  𝑔𝑒𝑤𝑖𝑐ℎ𝑡/(𝑙𝑒𝑛𝑔𝑡𝑒×𝑙𝑒𝑛𝑔𝑡𝑒) .

lengte = float(input("Vul je lengte in meter in "))
gewicht = float(input("Vul je gewicht in kg in "))

bmi = (gewicht / (lengte * lengte))
bmi = int(bmi * 10) / 10
(print("Je BMI is ", bmi))
