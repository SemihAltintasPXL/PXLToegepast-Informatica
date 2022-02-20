def main():
    alfabet = ""
    for teken in range(ord("a"), ord("z") + 1):
        alfabet += chr(teken)
    print(alfabet)

    for i in range(len(alfabet)):
        if (i + 1) % 2 == 0:  # de even getallen zullen in hoofdletters komen
            alfabet = alfabet.replace(alfabet[i], alfabet[i].upper())
    print(alfabet)
    alfabet = alfabet.replace('H', 'X')
    print(alfabet)


if __name__ == '__main__':
    main()
