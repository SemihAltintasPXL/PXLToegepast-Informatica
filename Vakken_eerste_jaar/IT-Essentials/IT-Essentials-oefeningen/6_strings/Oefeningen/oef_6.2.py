'''Oefening 6.2

Schrijf een programma om een ingevoerde tekst om te keren. Vb “dit is een tekst” wordt dan “tsket nee si tid”.'''


def main():
    tekst = input("geef een tekst in ")
    print(tekst[::-1])
    

if __name__ == '__main__':
    main()