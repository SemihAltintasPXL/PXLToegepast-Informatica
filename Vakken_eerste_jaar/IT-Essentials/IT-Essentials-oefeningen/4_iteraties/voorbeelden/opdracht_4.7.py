# druk alle getallen van -10 tem +10 af;
# De strict positieve getallen moeten voorafgegaan worden door een +
# opm: positief getal >=0 , strict positief >0; negatief getal <=0, strict negatief < 0

for i in range(-10, 11):
    if i > 0:
        print("+" + str(i))
    else:
        print(i)

# efficientere oplossing zonder een test te moeten uitvoeren :

for i in range(-10, 1):
    print(i)
for i in range(1, 11):
    print(print("+" + str(i)))
