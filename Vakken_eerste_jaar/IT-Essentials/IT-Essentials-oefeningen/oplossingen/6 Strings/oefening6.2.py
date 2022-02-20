def main():
    tekst = "dit is een tekst" # aantal = 16
    print(tekst[::-1])

    #alternatief
    print(tekst[-1:-len(tekst) - 1: -1])#de eerste -1 hoeft niet percee


    #alternatief
    for i in range(len(tekst) - 1, -1, -1):
        print(tekst[i], end="")

if __name__ == '__main__':
    main()