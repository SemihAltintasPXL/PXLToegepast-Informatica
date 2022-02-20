# zie oefeningen

lengte = int(input("Geef de lengte van de driehoek in (gelijkbenig): "))

for i in range(lengte, 0, -1):
    for j in range(i):
        print("@", end=" ")
    print()
