def vercijfer(tekst):
    nieuw = ""
    for i in range(0, len(tekst), 5):
        deel = tekst[i: i + 5]
        nieuw += deel[::-1]
    return nieuw


def main():
    tekst = input("geef een tekst in ")
    print(vercijfer(tekst))


if __name__ == '__main__':
    main()
