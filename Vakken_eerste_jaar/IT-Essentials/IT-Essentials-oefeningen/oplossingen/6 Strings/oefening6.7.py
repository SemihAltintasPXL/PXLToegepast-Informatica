from random import randint

def genereer_nummer():
    getal = randint(2, 24)
    if getal % 2 == 1:
        getal +=1
    return getal


def encrypteer(tekst, nummer):
    result = ""
    for letter in tekst:
        result += chr(ord(letter) + nummer)
    return result

def main():
    print(encrypteer("Dit is een belangrijke tekst", 4))
    tekst = input("Geef een tekst in: ")
    nummer = genereer_nummer()
    print(nummer)
    print(encrypteer(tekst, nummer))


if __name__ == '__main__':
    main()
