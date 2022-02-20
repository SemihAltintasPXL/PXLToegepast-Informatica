def wijziglist(mijn_list, index):
    if index >= 0 and index < len(mijn_list):
        mijn_list[index] = "FRUIT"
    print()

def main():
    fruitlist = ["appel", "banaan", "kers", "doerian"]
    te_wijzigen = 2
    wijziglist(fruitlist, te_wijzigen)
    print(fruitlist)

if __name__ == '__main__':
    main()
