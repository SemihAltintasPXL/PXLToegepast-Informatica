def vervang_kleine_letter(tekst):
    nieuw = ""
    for letter in tekst:

        # onderstaande werkt maar kan eenvoudiger
        # if ord(letter) >= ord("a") and ord(letter) <= ord("z"):
        # if letter >= "a" and letter <= "z":
        # alternatieve methode
        if letter.islower():
            nieuw += letter
        else:
            nieuw += " "
    return nieuw


def main():
    string = input("geef een teskt in ")
    print(vervang_kleine_letter(string))


if __name__ == "__main__":
    main()
