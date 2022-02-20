import random


def cumulatieve_som(list):
    for i in range(1, len(list)):
        list[i] = list[i - 1] + list[i]


def main():
    # 100 getallen genereren >0 en >10   => >=1 en <=9
    lijst_getallen = []
    for i in range(100):
        getal = random.randint(1, 9)
        lijst_getallen.append(getal)
    print(lijst_getallen)
    cumulatieve_som(lijst_getallen)
    print(lijst_getallen)

    # Werkt did ook boor strings? Genereer 10 kleine letters en plaats deze in een lijst

    lijst_letters = []
    for i in range(10):
        letter = chr(random.randint(ord("a"), ord("z")))
        lijst_letters.append(letter)
    print(lijst_letters)
    cumulatieve_som(lijst_letters)
    print(lijst_letters)


if __name__ == '__main__':
    main()