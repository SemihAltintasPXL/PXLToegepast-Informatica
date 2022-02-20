import random


def druk_kleinste_index(list, element):
    tel = list.count(element)
    print("{} komt {} keer voor".format(element, tel))
    index = -1
    for i in range(tel):
        index = list.index(element, index + 1)  # zo begin je op index 0 en door de loop word het telkens met 1 opgeteld
        print("op index", index)


def main():
    # 100 getallen in lijst getal >=0 en <10
    lijst = []
    for i in range(100):
        getal = random.randint(0, 9)
        lijst.append(getal)
    # gebruiker geeft getal in. invoercontrole!
    getal = int(input("geef een getal in "))
    while not (getal >= 0 and getal < 10):
        getal = int(input("Foutief getal ingegeven. Opnieuw ingeven "))
    druk_kleinste_index(lijst, getal)


if __name__ == '__main__':
    main()
