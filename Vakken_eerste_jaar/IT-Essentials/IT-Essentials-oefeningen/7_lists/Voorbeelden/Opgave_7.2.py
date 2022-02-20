def main():
    lijst = [125, 56, -15, 96, -963, 1458, 89, 12]
    grootste = lijst[0]
    kleinste = lijst[0]
    som = 0
    for getal in lijst:
        if getal > grootste:
            grootste = getal
        elif getal < kleinste:
            kleinste = getal
        som += getal
    print("het kleinste getal is", kleinste)
    print("het grootste getal is", grootste)
    print("de som van de getallen is", som)

    # alternatieve methode mbv ingebouwde functies
    print("het kleinste getal is", min(lijst))
    print("het grootste getal is", max(lijst))
    print("de som van de getallen is", sum(lijst))


if __name__ == '__main__':
    main()
