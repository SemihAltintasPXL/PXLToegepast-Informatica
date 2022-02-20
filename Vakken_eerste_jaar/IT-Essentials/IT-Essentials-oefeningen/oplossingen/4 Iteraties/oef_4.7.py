teller = 0
hoogste = -100
som = 0

for i in range(1, 11, 1):
    temperatuur = int(input("Hoeveel graden is het om 12 uur. "))
    som += temperatuur
    teller += 1
    if temperatuur > hoogste:
        hoogste = temperatuur

gemiddelde = som / teller
print("Het gemiddelde temperatuur", gemiddelde)
print("Hoogste temperatuur is", hoogste)
