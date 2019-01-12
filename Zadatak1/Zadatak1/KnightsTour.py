import sys
import random

class KonjicevaTura:
    def __init__(self):
        self.sahovska_ploca = [[0 for _ in range(8)] for _ in range(8)]  # lista koja se sastoji od vise listi

    def mogucnost_skoka(self, trenutna_pozicija):
        moguce_pozicije_skakanja = []
        pomaci_konja = [(1, 2), (1, -2), (-1, 2), (-1, -2), (2, 1), (2, -1), (-2, 1), (-2, -1)]
        for skok in pomaci_konja:
            l = lambda x, y: moguce_pozicije_skakanja.append((x, y)) if 0 <= x < 8 and 0 <= y < 8 else None
            l(trenutna_pozicija[0] + skok[0], trenutna_pozicija[1] + skok[1])

        return moguce_pozicije_skakanja

    def warnsdorf(self, sljedeci_vrh):
        susjedni_vrhovi = self.mogucnost_skoka(sljedeci_vrh)
        posjeceni_susjedi = []

        for v in susjedni_vrhovi:
            dubina_stabla = self.sahovska_ploca[v[0]][v[1]]
            if not dubina_stabla: posjeceni_susjedi.append(v)

        brojSkokova = []
        for v in posjeceni_susjedi:
            skok = [v, 0]
            skokovi = self.mogucnost_skoka(v)
            for m in skokovi:
                if not self.sahovska_ploca[m[0]][m[1]]: skok[1] += 1
            brojSkokova.append(skok)

        soritani_broj_skokova = sorted(brojSkokova, key=lambda s: s[1])
        redoslijed_skokova = [s[0] for s in soritani_broj_skokova]
        return redoslijed_skokova

    def tour(self, nivo_stabla, staza, sljedeci_vrh):
        self.sahovska_ploca[sljedeci_vrh[0]][sljedeci_vrh[1]] = nivo_stabla
        staza.append(sljedeci_vrh)
        print(sljedeci_vrh)

        if nivo_stabla == 64:
            sys.exit(1)
        else:
            redoslijed_skokova = self.warnsdorf(sljedeci_vrh)
            for susjed in redoslijed_skokova:
                self.tour(nivo_stabla + 1, staza, susjed)
            # Mislim da iduca linija nije potrebna
            # self.sahovska_ploca[sljedeci_vrh[0]][sljedeci_vrh[1]] = 0  # resetiranje


konjicevaTura = KonjicevaTura()
konjicevaTura.tour(1, [], (random.randint(0, 7), random.randint(0, 7)))
