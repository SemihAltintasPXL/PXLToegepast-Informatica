# Afdruk van alle getallen tussen 0 en 10000 (grenzen inbegrepen)
# die deelbaar zijn door 6 en door 2

for i in range(0, 10001):
    if i % 6 == 0 and i % 28 == 0:
        print(i)

print()  # lege print om een spatie te krijge in de output om het duidelijk te maken waar de print stopt

# efficientere oplossing :
for i in range(0, 10001, 6):
    if i % 28 == 0:
        print(i)
print()

# efficientere oplossing
for i in range(0, 10001, 28):
    if i % 6 == 0:
        print(i)
print()

# efficienste oplossing zonder een if gebruik makend van het kleinst gemeenschappelijke veelvoud
for i in range(0, 10001, 84):  # !' kleinste gemeen veelvoud van 28 en 6 = 84
    print(i)
