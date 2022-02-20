# maak de ascii tabel zoals in de powerpoint staat

def main():
    for i in range(32, 48):
        for j in range(6):
            ascii = i + j * 16
            print("{:>3} {:<3}".format(ascii, chr(ascii)), end="")
        print()


if __name__ == '__main__':
    main()
