from random import randint, random

def bereken():
    for reeksen in range(1, 6):
        print("reeks", reeksen)
        for i in range(1, 6):
            getal1 = randint(0, 20)
            getal2 = randint(0, getal1)
            som = getal1 - getal2
            print(i, ")", getal1, "-", getal2, "=", som)





def main():
    bereken()



if __name__ == '__main__':
    main()