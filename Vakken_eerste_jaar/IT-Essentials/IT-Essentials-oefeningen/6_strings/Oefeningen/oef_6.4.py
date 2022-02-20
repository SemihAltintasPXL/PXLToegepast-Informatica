'''Schrijf een programma om van 2 tekstvariabelen één tekstvariabele te maken.
De nieuwe variabele bekom je door de eerste 4 letters van 1ste tekstvariabele te nemen
(indien deze minder dan 4 letters bevat dient dit van achter aangevuld te worden met *) in hoofdletters
gevolgd door de laatste 4 letters van de 2de tekst variabele
(indien deze minder dan 4 letters bevat dient dit van voor aangevuld te worden met +) in kleine letters'''


def main():
    string1 = input("geef een tekst in ")
    string2 = input("geef nog een tekst in ")
    if len(string1) < 4:
        woord1 = string1.upper() + (4 - len(string1)) * "*"
    else:
        woord1 = string1[0:4].upper()

    if len(string2) < 4:
        woord2 = (4 - len(string2)) * "+" + string2.lower()
    else:
        woord2 = string2[-4:].lower()

    print(woord1 + woord2)

    # ZONDER IF EN WHILE GAAT OOK ZIE HIERONDER
    string1 = string1 + "****"
    woord1 = string1[0:4].upper()
    string2 = "++++" + string2
    woord2 = string2[-4:].lower()

    print(woord1 + woord2)


if __name__ == "__main__":
    main()
