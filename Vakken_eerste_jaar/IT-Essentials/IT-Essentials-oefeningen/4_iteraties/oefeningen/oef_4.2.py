'''Geef een geheel getal in via het toetsenbord vb 7. Maak een vermenigvuldigingstabel als volgt:

1 x 7 = 7       a x b = (a*b)
2 x 7 = 14
3 x 7 = 21
...
19 x 7 = 133
20 x 7 = 140'''

b = int(input("Geef een geheel getal in : "))
for a in range(1, 21):
    print(a, "x", b, "=", a * b)
