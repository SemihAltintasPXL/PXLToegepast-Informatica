def bereken(getal1, getal2):
    if getal1 > getal2:
        resultaat = getal1 * 2
    else:
        resultaat = getal2 * 3
    return resultaat

a = 5
b = 7
c = bereken(a, b)
print(c + 4)
x = 20
y = 15
z = bereken(x, y)
print(z)
