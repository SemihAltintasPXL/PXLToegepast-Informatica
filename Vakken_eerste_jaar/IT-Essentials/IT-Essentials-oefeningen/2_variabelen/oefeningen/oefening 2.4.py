# U geeft via het toetsenbord het aantal graden Celsius in.
# De computer berekent het aantal graden Fahrenheit.
# Dit aantal wordt op het scherm afgedrukt. De formule hiertoe luidt:  𝐹=(9/5)𝐶+32 .

aantal_graden = int(input("Vul het aantal graden in Celsius in "))

print("Dit is het aantal graden Fahrenheit:", ((9/5)* aantal_graden)+32)