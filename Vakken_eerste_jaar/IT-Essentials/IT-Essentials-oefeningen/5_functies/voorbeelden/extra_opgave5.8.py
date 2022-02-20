import math


def bepaal_belasting(bedr):
    if bedr > 55000:
        belasting = (bedr - 55000) * 0.6 + 25000 * 0.384 + 30000 * 0.5
    elif bedr > 25000:
        belasting = 25000 * 0.384 + (bedr - 25000) * 0.5
    else:
        belasting = bedr * 0.384
    # extra afronden naar boven 12345.3 ==> 12346

    return math.ceil(belasting)


def main():
    bedrag = int(input("geef een belastbaar bedrag in"))
    belasting = bepaal_belasting(bedrag)
    print("te betalen belasting:", belasting)


if __name__ == '__main__':
    main()
