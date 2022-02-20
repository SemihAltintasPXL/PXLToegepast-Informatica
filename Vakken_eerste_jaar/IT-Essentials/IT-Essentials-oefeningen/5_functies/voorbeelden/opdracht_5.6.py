def get_tienden(getal):
    return int(getal * 10) % 10


# 123.56 => x 10 1235.6 => afkappen 1235 => %10 5
def main():
    print(get_tienden(123.456))


if __name__ == '__main__':
    main()
