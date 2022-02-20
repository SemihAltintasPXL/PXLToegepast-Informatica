def main():
    aantal = int(input("Hoeveel karakters wil u ingeven? "))
    som = 0
    for i in range(aantal):
        char = input("geef een karakter: ")
        if char >= '0' and char <= '9':
            som += int(char)
        elif char >= 'A' and char <= 'Z':
            print(char + " is een hoofdletter")
        elif char >= 'a' and char <= 'z':
            print(char + " is een kleine letter")
        else:
            print(char + " is onbekend")
    print("Totaal cijfers " + str(som))

if __name__ == '__main__':
    main()