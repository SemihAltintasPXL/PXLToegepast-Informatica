def main():
    tekst = str(input("Geef een tekst in "))
    if len(tekst) % 3 == 0:
        print(tekst.upper())
    else:
        print(tekst.lower())


if __name__ == '__main__':
    main()
