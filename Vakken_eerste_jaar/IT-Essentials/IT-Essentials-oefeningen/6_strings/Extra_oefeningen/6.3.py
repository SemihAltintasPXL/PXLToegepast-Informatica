def keer_om_n(tekst, n):
    tekst = tekst[::-1]
    for letter in tekst:
        letter *= n
        print(letter, end="")


def main():
    tekst = str(input("geef een tekst in "))
    n = int(input("aantal herhalingen elke letter "))
    keer_om_n(tekst, n)


if __name__ == '__main__':
    main()
