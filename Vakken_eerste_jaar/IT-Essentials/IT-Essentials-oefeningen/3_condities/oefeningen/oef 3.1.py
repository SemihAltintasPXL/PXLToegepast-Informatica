''' Er worden twee getallen ingelezen via het toetsenbord.
 Als de getallen gelijk zijn, wordt afgedrukt: De twee getallen zijn gelijk.
 In het andere geval wordt afgedrukt: De twee getallen zijn ongelijk.'''

a = float(input("Voer een getal in "))
b = float(input("Voer nog een getal in "))

if a == b:
    print("De twee getallen zijn gelijk")
else:
    print("De twee getallen zijn ongelijk")
