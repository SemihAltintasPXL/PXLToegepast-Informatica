# zie oef 4.4
def main():
    planeten1 = ["Mercurius 0.377", "Venus 0.90", "Maan 0.165", "Mars 0.378", "Jupiter 2.537",
                 "Uranus 0.904", "Neptunus 1.137", "Pluto 0.063", "Zon 27.935"]

    for gewicht in range(50, 125, 5):
        print("{:10}  :  {:.2f}".format("Aarde", gewicht))
        for planeet in planeten1:
            planeet_geg = planeet.split()
            print("{:10}  :  {:.2f}".format(planeet_geg[0], gewicht * float(planeet_geg[1])))
        print()

    planeten2 = [" Mercurius    0.377 ", " 0.90    Venus  ", "Maan    0.165 ", " Mars 0.378", "2.537 Jupiter  ",
                 "   0.904 Uranus", "Neptunus      1.137", " 0.063   Pluto ", "    Zon 27.935   "]
    for gewicht in range(50, 125, 5):
        print("{:10}  :  {:.2f}".format("Aarde", gewicht))
        for planeet in planeten2:
            # voorloopspaties en achterloopspaties verwijderen
            planeet = planeet.strip()
            # tussenspaties vervangen door 1 spatie
            tel = planeet.count(" ")
            planeet = planeet.replace(tel * " ", " ")
            planeet_geg = planeet.split()
            # wat i de naam, wat is het percentage
            if planeet_geg[
                0].isalpha():  # nagaan eerste teken een letter planeet_geg[0][0].isalpha
                naam = planeet_geg[0]
                perc = float(planeet_geg[1])
            else:
                naam = planeet_geg[1]
                perc = float(planeet_geg[0])
            print("{:10}  :  {:.2f}".format(naam, gewicht * perc))
        print()


if __name__ == '__main__':
    main()
