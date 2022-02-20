# zie oef 5.2
# geef een datum in van de vorm dd/mm/jjjj
# bereken welke dag van het jaar dit is. Hou rekening met schrikkeljaar of niet
# bvb 22/10/2020 ==> dagnur 296
def is_schrikkeljaar(jaar):
    return jaar % 4 == 0 and jaar % 100 != 0 or jaar % 400 == 0


def main():
    datum = input("geef een dag in dd/mm/jjjj: ")
    datum_geg = datum.split("/")
    maanden = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]
    dagnummer = int(datum_geg[0])
    for i in range(int(datum_geg[1]) - 1):
        dagnummer += maanden[i]

    if int(datum_geg[1]) > 2 and is_schrikkeljaar(int(datum_geg[2])):
        dagnummer += 1
    print("dit is dagnummer", dagnummer)


if __name__ == '__main__':
    main()
