def main():
    getal = input("Geef een positief geheel getal in: ")
    woorden = ["nul", "een", "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen"]
    cijfers = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]
    for i in range(len(cijfers)):
        for j in range(len(getal)):
            if getal[j] == cijfers[i]:
                print(woorden[i], end=" ")


if __name__ == "__main__":
    main()
