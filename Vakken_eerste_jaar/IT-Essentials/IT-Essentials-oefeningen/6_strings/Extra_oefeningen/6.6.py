def vervang_klinker(tekst, teken):
    for letter in tekst:
        if letter in "aeiouAEIOU":
            tekst = tekst.replace(letter, teken)

    print(tekst)


def main():
    tekst = input("geef een tekst in ")
    teken = input("geef een teken in ")
    vervang_klinker(tekst, teken)


if __name__ == '__main__':
    main()
