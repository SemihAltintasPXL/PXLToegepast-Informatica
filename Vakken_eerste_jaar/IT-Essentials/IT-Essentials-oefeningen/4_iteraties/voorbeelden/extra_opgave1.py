# zie oef 2.9
centen = int(input("geef het aantal eurocenten in"))
for munt in (200, 100, 50, 20, 10, 5, 2, 1):
    # alleen de geldstukken afdrukken die nodig zijn
    if centen >= munt:
        aantal = centen // munt
        centen %= munt
    print(aantal, "x", munt, "cent")
