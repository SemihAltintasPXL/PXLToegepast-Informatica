def main():
    # tekst = "dit was eEn tEkSt"  #aantal = 17 (oneven)
    tekst = "dit was eEne tEkSt"  #aantal = 18 (even)
    # tekst = "zonder zo'n beep in' #geen t in de string

    index_of_t = tekst.upper().find("T")
    if index_of_t == -1:
        print("De gegeven tekst bevat geen t of T.")
    else:
        nieuwe_tekst = tekst[0:index_of_t + 1]
        if len(tekst) % 2 == 0:
            nieuwe_tekst = nieuwe_tekst + tekst[index_of_t + 1:].lower()
        else:
            nieuwe_tekst = nieuwe_tekst + tekst[index_of_t + 1:].upper()
        print(nieuwe_tekst)




if __name__ == '__main__':
    main()