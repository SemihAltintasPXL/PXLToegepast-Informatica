def main():
    tekst1 = "ab" #"abcdefgh"
    tekst2 = "GH" #"ABCDEFGH"

    while len(tekst1) < 4:
        tekst1 = tekst1 + "*"
    tekst1 = tekst1[0:4].upper()

    while len(tekst2) < 4:
        tekst2 = "+" + tekst2
    tekst2 = tekst2[len(tekst2) - 4:].lower()

    resultaat = tekst1 + tekst2
    print(resultaat)

    
    #ZONDER IF EN WHILE GAAT OOK ZIE HIERONDER
    tekst1 = tekst1 + "****"
    tekst2 = "++++" + tekst2

    resultaat = tekst1[:4].upper() + tekst2[len(tekst2) - 4:].lower()
    print(resultaat)

if __name__ == '__main__':
    main()