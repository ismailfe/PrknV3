import BinanceApi
import KuCoinApi
import datetime

sonbirincifark = 9999.99
sonikincifark = 9999.99

coinName = "TRX"
durum_1 = coinName + "BTC"
durum_2 = coinName + "-BTC"

durum_2_btc = "BTC-USDT"

durum_1_borsa = "Binance"
durum_2_borsa = "KuCoin"

print("Bot Çalışmaya Başladı : " + durum_1)

karyuzdeorani = 1
zararyuzdeorani = 0.4
yenidenalimlimiti = 0.12

toplamkar = 0

while True:
    try:
        if (float(KuCoinApi.Balance("BTC")) > 0.00053 and float(BinanceApi.Balance("BTC")) > 0.00053):
            tarih = datetime.datetime.now()

            durum_1_buyprice = float(BinanceApi.LastBuyCoinPrice(durum_1))
            durum_1_buyamount = float(BinanceApi.LastBuyCoinAmount(durum_1))
            durum_1_sellprice = float(BinanceApi.LastSellCoinPrice(durum_1))
            durum_1_sellamount = float(BinanceApi.LastSellCoinAmount(durum_1))

            durum_2_buyprice = float(KuCoinApi.LastBuyCoinPrice(durum_2))
            durum_2_buyamount = float(KuCoinApi.LastBuyCoinAmount(durum_2))
            durum_2_sellprice = float(KuCoinApi.LastSellCoinPrice(durum_2))
            durum_2_sellamount = float(KuCoinApi.LastSellCoinAmount(durum_2))

            durum_1_eksi_durum_2 = durum_1_buyprice - durum_2_sellprice  ## Eğer fark > 0 ise Binance Satma Fırsatı
            durum_2_eksi_durum_1 = durum_2_buyprice - durum_1_sellprice  ## Eğer fark > 0 ise Kucoin Satma Fırsatı

            durum_1_dealimmiktari = min(durum_2_buyamount, durum_1_sellamount, 1000)
            durum_1_toplamalimmiktari = durum_1_dealimmiktari - 15 / 10000 * durum_1_dealimmiktari

            sonikincifark = durum_2_eksi_durum_1

            masraf = 9500 * durum_1_buyprice * durum_1_toplamalimmiktari * 6.85
            endusukkar = 9500 * durum_2_eksi_durum_1 * 6.85 * durum_1_toplamalimmiktari
            karyuzdesi = (endusukkar / masraf) * 100

            if (karyuzdesi > karyuzdeorani):
                KuCoinApi.IslemleriIptalEt()
                BinanceApi.IslemleriIptalEt()
                BinanceApi.BuyCoin(durum_1, durum_1_sellprice, durum_1_dealimmiktari)
                KuCoinApi.SellCoin(durum_2, durum_2_buyprice, durum_1_dealimmiktari)
                print(durum_1 + " - > Kucoin Sat | Binance Al | Toplam Miktar : " + str(
                    format(durum_1_dealimmiktari, ".2f")) + " | Minimum kar : " + str(
                    format(endusukkar, ".2f")) + " TL  | Masraf : " + str(
                    format(masraf, ".2f")) + " TL | Kar Yüzdesi : " + str(format(karyuzdesi, ".2f")) + " | " + str(
                    tarih))
                toplamkar = toplamkar + endusukkar
                print("Toplam Kar : " + str(toplamkar) + " | Kaçtan Alındı : " + str(
                    durum_1_sellprice) + " | Kaçtan Satıldı : " + str(durum_2_buyprice) + " | 1. Durum")
                print("Kar Yüzdesi : " + str(karyuzdesi) + " | Kar Yüzde Oranı : " + str(karyuzdeorani))

            else:
                pass

            durum_2_dealimmiktari = min(durum_1_buyamount, durum_2_sellamount, 1000)

            durum_2_toplamalimmiktari = durum_2_dealimmiktari - 15 / 10000 * durum_2_dealimmiktari

            sonbirincifark = durum_1_eksi_durum_2

            masraf = 9500 * durum_2_buyprice * durum_2_toplamalimmiktari * 6.85
            endusukkar = 9500 * durum_1_eksi_durum_2 * 6.85 * durum_2_toplamalimmiktari
            karyuzdesi = (endusukkar / masraf) * 100

            if (karyuzdesi > karyuzdeorani):
                KuCoinApi.IslemleriIptalEt()
                BinanceApi.IslemleriIptalEt()
                KuCoinApi.BuyCoin(durum_2, durum_2_sellprice, durum_2_dealimmiktari)
                BinanceApi.SellCoin(durum_1, durum_1_buyprice, durum_2_dealimmiktari)

                print(durum_1 + " - > Binance Sat | Kucoin Al | Toplam Miktar : " + str(
                    format(durum_2_dealimmiktari, ".2f")) + " | Minimum kar : " + str(
                    format(endusukkar, ".2f")) + " TL | Masraf : " + str(
                    format(masraf, ".2f")) + " TL | Kar Yüzdesi : " + str(format(karyuzdesi, ".2f")) + " | " + str(
                    tarih))
                toplamkar = toplamkar + endusukkar
                print("Toplam Kar : " + str(toplamkar) + " | Kaçtan Alındı : " + str(
                    durum_2_sellprice) + " | Kaçtan Satıldı : " + str(durum_1_buyprice) + " | 2. Durum")
                print("Kar Yüzdesi : " + str(karyuzdesi) + " | Kar Yüzde Oranı : " + str(karyuzdeorani))

            else:
                pass

        if (float(KuCoinApi.Balance("BTC")) < yenidenalimlimiti):
            tarih = datetime.datetime.now()

            durum_1_buyprice = float(BinanceApi.LastBuyCoinPrice(durum_1))
            durum_1_buyamount = float(BinanceApi.LastBuyCoinAmount(durum_1))
            durum_1_sellprice = float(BinanceApi.LastSellCoinPrice(durum_1))
            durum_1_sellamount = float(BinanceApi.LastSellCoinAmount(durum_1))

            durum_2_buyprice = float(KuCoinApi.LastBuyCoinPrice(durum_2))
            durum_2_buyamount = float(KuCoinApi.LastBuyCoinAmount(durum_2))
            durum_2_sellprice = float(KuCoinApi.LastSellCoinPrice(durum_2))
            durum_2_sellamount = float(KuCoinApi.LastSellCoinAmount(durum_2))

            durum_1_eksi_durum_2 = durum_1_buyprice - durum_2_sellprice  ## Eğer fark > 0 ise Binance Satma Fırsatı
            durum_2_eksi_durum_1 = durum_2_buyprice - durum_1_sellprice  ## Eğer fark > 0 ise Kucoin Satma Fırsatı

            durum_2_dealimmiktari = min(durum_2_sellamount, durum_1_buyamount, 1000)

            durum_2_toplamalimmiktari = durum_2_dealimmiktari - 15 / 10000 * durum_2_dealimmiktari

            sonbirincifark = durum_1_eksi_durum_2

            masraf = 9500 * durum_2_buyprice * durum_2_toplamalimmiktari * 6.85
            endusukkar = 9500 * durum_1_eksi_durum_2 * 6.85 * durum_2_toplamalimmiktari
            karyuzdesi = (endusukkar / masraf) * 100

            if (karyuzdesi < zararyuzdeorani and karyuzdesi > 0):
                KuCoinApi.IslemleriIptalEt()
                BinanceApi.IslemleriIptalEt()

                KuCoinApi.BuyCoin(durum_2, durum_2_sellprice, durum_2_dealimmiktari)
                BinanceApi.SellCoin(durum_1, durum_1_buyprice, durum_2_dealimmiktari)

                print(durum_1 + " - > Binance Sat | Kucoin Al | Toplam Miktar : " + str(
                    format(durum_2_dealimmiktari, ".2f")) + " | Minimum kar : " + str(
                    format(endusukkar, ".2f")) + " TL | Masraf : " + str(
                    format(masraf, ".2f")) + " TL | Kar Yüzdesi : " + str(format(karyuzdesi, ".2f")) + " | " + str(
                    tarih))
                toplamkar = toplamkar + endusukkar
                print("Toplam Kar : " + str(toplamkar) + " | Kaçtan Alındı : " + str(
                    durum_2_sellprice) + " | Kaçtan Satıldı : " + str(durum_1_buyprice) + " | 3. Durum")
                print("Kar Yüzdesi : " + str(karyuzdesi) + " | Kar Yüzde Oranı : " + str(karyuzdeorani))

            else:
                pass

        if (float(BinanceApi.Balance("BTC")) < yenidenalimlimiti):
            tarih = datetime.datetime.now()

            durum_1_buyprice = float(BinanceApi.LastBuyCoinPrice(durum_1))
            durum_1_buyamount = float(BinanceApi.LastBuyCoinAmount(durum_1))
            durum_1_sellprice = float(BinanceApi.LastSellCoinPrice(durum_1))
            durum_1_sellamount = float(BinanceApi.LastSellCoinAmount(durum_1))

            durum_2_buyprice = float(KuCoinApi.LastBuyCoinPrice(durum_2))
            durum_2_buyamount = float(KuCoinApi.LastBuyCoinAmount(durum_2))
            durum_2_sellprice = float(KuCoinApi.LastSellCoinPrice(durum_2))
            durum_2_sellamount = float(KuCoinApi.LastSellCoinAmount(durum_2))

            durum_1_eksi_durum_2 = durum_1_buyprice - durum_2_sellprice  ## Eğer fark > 0 ise Binance Satma Fırsatı
            durum_2_eksi_durum_1 = durum_2_buyprice - durum_1_sellprice  ## Eğer fark > 0 ise Kucoin Satma Fırsatı

            durum_1_dealimmiktari = min(durum_2_buyamount, durum_1_sellamount, 1000)

            durum_1_toplamalimmiktari = durum_1_dealimmiktari - 15 / 10000 * durum_1_dealimmiktari

            sonikincifark = durum_2_eksi_durum_1

            masraf = 9500 * durum_1_buyprice * durum_1_toplamalimmiktari * 6.85
            endusukkar = 9500 * durum_2_eksi_durum_1 * 6.85 * durum_1_toplamalimmiktari
            karyuzdesi = (endusukkar / masraf) * 100

            if (karyuzdesi < zararyuzdeorani and karyuzdesi > - zararyuzdeorani):
                KuCoinApi.IslemleriIptalEt()
                BinanceApi.IslemleriIptalEt()

                BinanceApi.BuyCoin(durum_1, durum_1_sellprice, durum_1_dealimmiktari)
                KuCoinApi.SellCoin(durum_2, durum_2_buyprice, durum_1_dealimmiktari)

                print(durum_1 + " - > Kucoin Sat | Binance Al | Toplam Miktar : " + str(
                    format(durum_1_dealimmiktari, ".2f")) + " | Minimum kar : " + str(
                    format(endusukkar, ".2f")) + " TL  | Masraf : " + str(
                    format(masraf, ".2f")) + " TL | Kar Yüzdesi : " + str(format(karyuzdesi, ".2f")) + " | " + str(
                    tarih))
                toplamkar = toplamkar + endusukkar
                print("Toplam Kar : " + str(toplamkar) + " | Kaçtan Alındı : " + str(
                    durum_1_sellprice) + " | Kaçtan Satıldı : " + str(durum_2_buyprice) + " | 4. Durum")
                print("Kar Yüzdesi : " + str(karyuzdesi) + " | Kar Yüzde Oranı : " + str(karyuzdeorani))


            else:
                pass

    except:
        pass
