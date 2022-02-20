# zorg ervoor dat in een tekst letters worden omgezet naar hoofdletters
# zonder gebruik te maken van de methone upper
def main():
    tekst = input("geef een tekst in ")
    nieuw = ""
    afstand = ord("a") - ord("A")  # 32
    for letter in tekst:
        if letter.islower():
            nieuw += chr(ord(letter) - afstand)
        else:
            nieuw += letter
    print(nieuw)


if __name__ == '__main__':
    main()
