# Maak een programma dat de eenheid meter omzet naar de eenheid voet.
# van 1 meter tem 20 meter toename 0.5. 1meter = 3.2808399 voet
# Weergave 2 cijfers na de komma. Zorg voor een mooie lay-out.

def main():
    print("{:^15} {:^15}".format("meter", "voet"))
    for i in range(2, 41):  # (1,21,0.5) gaat niet omdat je in een range enkel gehele getalle gebruiken
        meter = i / 2
        print("{:^15.2f} {:^15.2f}".format(meter, 3.2808399 * meter))


if __name__ == '__main__':
    main()
