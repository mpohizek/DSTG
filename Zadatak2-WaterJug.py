def prelijevanje_vode(vrc1, vrc2, kol):
    kapacitet_vrc1, kapacitet_vrc2 = 3, 5

    print("{0}\t{1}".format(vrc1, vrc2))
    if vrc2 is kol:
        return
    elif vrc2 is kapacitet_vrc2:
        prelijevanje_vode(0, vrc1, kol)
    elif vrc1 != 0 and vrc2 is 0:
        prelijevanje_vode(0, vrc1, kol)
    elif vrc1 is kol:
        prelijevanje_vode(vrc1, 0, kol)
    elif vrc1 < kapacitet_vrc1:
        prelijevanje_vode(kapacitet_vrc1, vrc2, kol)
    elif vrc1 < (kapacitet_vrc2 - vrc2):
        prelijevanje_vode(0, (vrc1 + vrc2), kol)
    else:
        prelijevanje_vode(vrc1 - (kapacitet_vrc2 - vrc2), (kapacitet_vrc2 - vrc2) + vrc2, kol)


kol = 0
while kol not in range(1, 6):
    kol = int(input("Koliko vode zelite izmjeriti? Odaberite 1, 2, 3, 4 ili 5 "))
print("\nVRC1\tVRC2")
prelijevanje_vode(0, 0, kol)
