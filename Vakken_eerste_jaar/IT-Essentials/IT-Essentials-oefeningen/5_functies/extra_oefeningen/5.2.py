def bereken_aanwezigheidsduur(in_uur, in_min, uit_uur, uit_min):
    minuten_uit = (uit_uur * 60) + uit_min
    minuten_in = (in_uur * 60) + in_min
    duur = minuten_uit - minuten_in
    return duur


def bereken_gemiddelde_duur(gemiddelde_in_minuten):
    uur = int(gemiddelde_in_minuten // 60)
    minuut = int(gemiddelde_in_minuten % 60)
    return "{} uur en {} minuten".format(uur, minuut)


def main():
    bezoekers_totaal = 0
    aantal_bezoekers = 0
    som = 0
    in_uur = int(input("uur van binnenkomen "))
    while in_uur != 0:
        in_min = int(input("minuut van binnenkomen "))
        uit_uur = int(input("uur van verlaten van museum "))
        uit_min = int(input("minuut van verlaten van museum "))
        aanwezigheidsduur = bereken_aanwezigheidsduur(in_uur, in_min, uit_uur, uit_min)
        if aanwezigheidsduur > 60:
            aantal_bezoekers += 1
        som += aanwezigheidsduur
        bezoekers_totaal += 1

        in_uur = int(input("uur van binnenkomen "))

    print("Er waren", aantal_bezoekers, "bezoekers meer dan 1 uur binnen.")
    gemiddelde_in_minuten = som / bezoekers_totaal
    gemiddelde_duur = bereken_gemiddelde_duur(gemiddelde_in_minuten)
    print("De gemiddelde aanwezigheidsduur van de bezoekers was", gemiddelde_duur)


if __name__ == '__main__':
    main()
