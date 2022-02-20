import random


def genereer_tekst(n):
    tekst = ""
    for letter in range(n):
        tekst += chr(random.randint(ord("A"), ord("Z")))

    print(tekst)


def main():
    n = int(input("aantal tekens tekst "))
    genereer_tekst(n)


if __name__ == '__main__':
    main()
