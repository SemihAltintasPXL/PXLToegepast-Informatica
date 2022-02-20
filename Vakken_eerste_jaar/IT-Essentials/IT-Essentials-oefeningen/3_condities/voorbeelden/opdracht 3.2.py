'''Schrijf code die test of  1/2  groter dan, gelijk aan, of kleiner is dan  0.5 . Doe dat ook voor  1/3  en  0.33 .
 Doe het dan ook voor  (1/3)∗3  en  1 .
Vergelijkingen tussen data types die niet vergeleken kunnen worden, leiden meestal tot runtime errors.'''

print(1 / 10 == 0.10)
print(1 / 10 > 0.10)

print(1 / 3 == 0.33)
print(1 / 3 > 0.33)

print((1 / 3) * 3 == 1)
print((1 / 3) * 3 > 1)

print(1 / 10 + 1 / 18 + 1 / 10 == 0.3)  # geeft false omwille van afrondingsfouten
print(1 / 10 + 1 / 18 + 1 / 10 > 0.3)  # geeft true omwille van afrondingsfouten

print(1 / 10)
print(1 / 10 + 1 / 18 + 1 / 10)
