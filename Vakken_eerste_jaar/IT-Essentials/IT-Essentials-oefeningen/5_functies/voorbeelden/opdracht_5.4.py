# Schrijf functie is_even geeft True als getal even is, False als anders
def is_even(getal):
    return getal % 2 == 0


def main():
    print(is_even(123456))
    print(is_even(121))


if __name__ == '__main__':
    main()
