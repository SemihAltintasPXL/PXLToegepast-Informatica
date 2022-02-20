# U geeft via het toetsenbord het aantal graden Fahrenheit in en de computer berekent het aantal graden Celsius, afgerond op 1 decimaal na de komma.
# Dit aantal wordt afgedrukt.

aantal_gradenF = float(input("Vul het aantal graden in Fahrenheit in "))

# 𝐹=(9/5)𝐶+32
# C= (F-32)*(5/9)

c = (((aantal_gradenF) - 32) / (9 / 5))
c = int(c * 10 + 0.5) / 10
print("Dit is het aantal graden in Celcius: ", c)

# Ik krijg het niet op 1 decimaal na de komma
