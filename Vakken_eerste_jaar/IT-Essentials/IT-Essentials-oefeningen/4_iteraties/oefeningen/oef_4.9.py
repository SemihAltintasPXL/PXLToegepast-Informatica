# Schrijf een programma dat tafels van vermenigvuldiging afdrukt voor de getallen 2 tot 5(incl.).


for i in range(2, 6):

    for j in range(1, 11):
        print(j, "x", i, "=", i * j)
    print()

# of

for i in range(1, 6):
    for j in range(1, 11):
        print(i * j, end="\t")
    print()
