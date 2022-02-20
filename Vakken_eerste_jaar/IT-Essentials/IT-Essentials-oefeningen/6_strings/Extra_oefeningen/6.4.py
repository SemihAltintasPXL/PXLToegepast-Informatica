def sorteer_tekst(tekst):
    nieuw = ""
    for i in range(ord("a"), ord("z") + 1):
        for j in tekst:
            if j == chr(i):
                nieuw += j

    return nieuw


def main():
    tekst = input("geef een tekst in ")
    print(sorteer_tekst(tekst))


if __name__ == '__main__':
    main()
