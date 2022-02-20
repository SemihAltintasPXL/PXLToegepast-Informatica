# Schrijf functie is_oneven geeft False als getal even is, True als anders
# Maak hierbij gebruik van de functie is_even

def is_even(getal):
    return getal % 2 == 0


def is_oneven(getal):
    return not is_even(getal)


# gemakkelijker maar niet de opgave return getal % 2!= 0

def main():
    print(is_even(123456))
    print(is_even(121))


if __name__ == '__main__':
    main()
