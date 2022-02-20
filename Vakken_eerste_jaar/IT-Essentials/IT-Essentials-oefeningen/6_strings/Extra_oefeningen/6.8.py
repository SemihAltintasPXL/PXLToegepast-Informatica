def vervorm(tekst):
    nieuw = tekst[0::3] + tekst[1::3] + tekst[2::3]
    print(nieuw)


def main():
    tekst = input("geef een tekst in ")
    vervorm(tekst)


if __name__ == '__main__':
    main()
