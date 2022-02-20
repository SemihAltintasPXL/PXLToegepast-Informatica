def main():
    tekst = input("Geef een tekst in ")
    for i in range(len(tekst)):
        if tekst[i] in "aeuio":
            print("klinker {} staat op index {}".format(tekst[i], i))


if __name__ == '__main__':
    main()