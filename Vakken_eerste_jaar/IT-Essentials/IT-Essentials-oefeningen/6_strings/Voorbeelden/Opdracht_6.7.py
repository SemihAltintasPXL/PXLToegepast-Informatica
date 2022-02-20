def main():
    tekst = "Barefoot on the grass,# listening to our favorite song"
    index = tekst.find("#")
    nieuw = tekst[index + 1:].strip()
    print(nieuw)


if __name__ == '__main__':
    main()
