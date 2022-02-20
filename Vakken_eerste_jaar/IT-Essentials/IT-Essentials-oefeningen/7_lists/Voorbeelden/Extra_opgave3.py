# zie extra opgave1 H4
# output bij ingave 559
#                       2 stukken van 2euro
#                       1 stuk van 1 euro
#                       1 stuk van 50 cent
#                       ....

def main():
    centen = int(input("geef het aantal eurocenten in "))
    munten = [200, 100, 50, 20, 10, 5, 2, 1]
    omschrijving = ["2euro", "1euro", "50 cent", "20 cent", "10 cent", "5 cent", "2 cent", "1 cent"]
    for i in range(len(munten)):

        if centen >= munten[i]:  # alleen de geldstukken afdrukken die nodig zijn
            aantal = centen // munten[i]
            if aantal < 1:
                tekst = "stukken"
            else:
                tekst = "stuk"
            centen %= munten[i]
            print(aantal, tekst, munten[i], "van", omschrijving[i])


if __name__ == '__main__':
    main()
