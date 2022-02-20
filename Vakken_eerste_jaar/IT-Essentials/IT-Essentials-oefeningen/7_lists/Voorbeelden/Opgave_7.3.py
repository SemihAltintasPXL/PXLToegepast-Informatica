def main():
    lijst = []
    getal = int(input("geef een getal in "))
    while getal != 0:
        if getal in lijst:
            index = lijst.index(getal)  # !!!!!opgepast werkt alleen als je zeker weet dat het getal in de lijst zit
            print("het getal {} bevindt zich op index {}".format(getal, index))
            lijst.remove(getal)
        else:
            lijst.append(getal)  # !!!!!opgepast werkt alleen als je zeker weet dat het getal niet in de lijst zit
        getal = int(input("geef een getal in "))
    print(lijst)


if __name__ == '__main__':
    main()
