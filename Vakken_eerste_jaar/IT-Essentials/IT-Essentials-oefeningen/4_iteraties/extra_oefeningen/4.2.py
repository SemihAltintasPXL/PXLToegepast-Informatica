naam = input("Geef de naam in ")
while naam != "xx" and naam != "XX":
    score = int(input("Geef het behaald percentage in "))
    while score < 0 or score > 100:
        if score < 0:
            score = print("Fout! het getal moet minstens 0 zijn.")
        else:
            score = print("Fout! het getal mag maximum 100 zijn")
    if score < 60:
        print("onvoldoende")
    elif score < 70:
        print("voldoende")
    elif score < 80:
        print("onderscheiding")
    elif score < 85:
        print("grote onderscheiding")
    else:
        print("grootste onderscheiding")
    naam = input("Geef de naam ")
