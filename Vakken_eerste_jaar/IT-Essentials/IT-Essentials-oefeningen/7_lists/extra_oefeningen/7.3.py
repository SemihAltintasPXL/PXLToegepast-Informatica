def main():
    GROOTTE = 7
    matrix = []
    for i in range(GROOTTE):
        matrix.append(GROOTTE * [0])
    for j in range(GROOTTE):
        print("Geef de waarden voor kolom", j + 1)
        for i in range(GROOTTE):
            matrix[j][i] = int(input("Geef een waarde voor rij " + str(i + 1)))

    for i in range(GROOTTE):
        for j in range(GROOTTE):
            print(matrix[i][j], end=" ")
        print()

    som = 0
    for i in range(GROOTTE):
        som += matrix[i][i]
    print("Spoor: ", som)


if __name__ == '__main__':
    main()
