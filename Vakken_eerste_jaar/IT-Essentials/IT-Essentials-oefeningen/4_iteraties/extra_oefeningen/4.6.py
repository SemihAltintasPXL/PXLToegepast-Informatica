lengte = int(input("geef de lengte in "))
hoogte = int(input("geef de hoogte in "))

for i in range(hoogte):
    print(" * " * lengte)

# extra

lengte = int(input("geef de lengte in "))
hoogte = int(input("geef de hoogte in "))

for i in range(hoogte):
    for j in range(lengte):
        if (i > 0 and i < hoogte - 1) and (j > 0 and j < lengte - 1):
            print("   ", end="")
        else:
            print(" * ", end="")
    print()
