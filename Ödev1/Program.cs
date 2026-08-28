using System.ComponentModel.Design;

namespace Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string şifre = "ab18";
            double bakiye = 25000;
            int hak = 0;
            string tcno = "11111111111";
            string tel = "11111111111";
            int deneme = 0;

            Console.WriteLine("Kartlı işlem için 1 \nKartsız işlem için 2\n");
            int seçim1 = Convert.ToInt32(Console.ReadLine());

            switch (seçim1)
            {
                case 1:
                    while (hak < 3)
                    {
                        Console.WriteLine("şifrenizi girin");
                        string password = Console.ReadLine();

                        if (password == şifre)
                        {
                        ANAMENU:
                            Console.WriteLine("\n------------Ana Menü---------");
                            Console.WriteLine("Para çekmek için 1\nPara yatırmak için 2\nPara transferleri 3\nEğitim Ödemeleri 4\nÖdemeler 5\nBilgi Güncelleme 6\nProgramdan çıkış için 0\n");
                            int işlem = Convert.ToInt32(Console.ReadLine());
                            switch (işlem)
                            {
                                case 0:
                                    Environment.Exit(0);
                                    break;
                                case 1:
                                    Console.WriteLine("Çekmek istediğiniz miktar?");
                                    int mik = Convert.ToInt32(Console.ReadLine());
                                    if (mik <= bakiye)
                                    {
                                        bakiye -= mik;
                                        Console.WriteLine("İşlem Başarılı");
                                        Console.WriteLine("Yeni bakiyeniz:" + bakiye);
                                    karar:
                                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                        int karar = Convert.ToInt32(Console.ReadLine());

                                        if (karar == 1)
                                        {
                                            goto ANAMENU;
                                        }
                                        else if (karar == 0)
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("geçersiz sayı girdiniz");
                                            goto karar;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye");
                                    karar:
                                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                        int karar = Convert.ToInt32(Console.ReadLine());

                                        if (karar == 1)
                                        {
                                            goto ANAMENU;
                                        }
                                        else if (karar == 0)
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("geçersiz sayı girdiniz");
                                            goto karar;
                                        }
                                    }

                                    break;

                                case 2:
                                    Console.WriteLine("\nKredi kartınız için 1\nKendi hesabınız için 2\nAna meüye dönmek için 9\nProgramdan çıkmak için 0");
                                    int seçim2 = Convert.ToInt32(Console.ReadLine());

                                    if (seçim2 == 0)
                                    {
                                        Environment.Exit(0);
                                    }
                                    else if (seçim2 == 9)
                                    {
                                        goto ANAMENU;
                                    }
                                    else if (seçim2 == 1)
                                    {
                                        Console.WriteLine("12 haneli kart numaranızı girin");
                                        string KartNo = Console.ReadLine();
                                        if (KartNo.Length == 12 && long.TryParse(KartNo, out long kartNo))
                                        {
                                            Console.WriteLine("\nyatırılacak miktar?");
                                            int miktar = Convert.ToInt32(Console.ReadLine());
                                            if (bakiye >= miktar && miktar > 0)
                                            {
                                                bakiye -= miktar;
                                                Console.WriteLine("Yeni Bakiye:" + bakiye);
                                            karar:
                                                Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                                int karar = Convert.ToInt32(Console.ReadLine());

                                                if (karar == 1)
                                                {
                                                    goto ANAMENU;
                                                }
                                                else if (karar == 0)
                                                {
                                                    Environment.Exit(0);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("geçersiz sayı girdiniz");
                                                    goto karar;
                                                }
                                            }
                                            else if (miktar <= 0)
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto ANAMENU;
                                            }
                                            else
                                            {
                                                Console.WriteLine("yeterisz bakiye");
                                            karar:
                                                Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                                int karar = Convert.ToInt32(Console.ReadLine());

                                                if (karar == 1)
                                                {
                                                    goto ANAMENU;
                                                }
                                                else if (karar == 0)
                                                {
                                                    Environment.Exit(0);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("geçersiz sayı girdiniz");
                                                    goto karar;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(" kart numaranız hatalı");
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                    }
                                    else if (seçim2 == 2)
                                    {
                                        Console.WriteLine("\nYatırılacak miktar:");
                                        int hesap = Convert.ToInt32(Console.ReadLine());
                                        bakiye += hesap;
                                        Console.WriteLine("Yeni Bakiye:" + bakiye);

                                    karar:
                                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                        int karar = Convert.ToInt32(Console.ReadLine());

                                        if (karar == 1)
                                        {
                                            goto ANAMENU;
                                        }
                                        else if (karar == 0)
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("geçersiz sayı girdiniz");
                                            goto karar;
                                        }
                                    }
                                    break;
                                case 3:

                                    Console.WriteLine("\nBaşka hesaba EFT 1\nBaşkta hesaba havale 2");
                                    int seçim3 = Convert.ToInt32(Console.ReadLine());
                                    if (seçim3 == 1)
                                    {
                                        Console.WriteLine("IBAN:");
                                        string iban = Console.ReadLine().ToUpper();

                                        if (iban.StartsWith("TR") && iban.Length == 14)
                                        {
                                            string Iban = iban.Substring(2);
                                            if (long.TryParse(Iban, out long IBAN))
                                            {
                                                Console.WriteLine("\nTransfer edilecek miktar:");

                                                if (int.TryParse(Console.ReadLine(), out int miktar))
                                                {
                                                    if (miktar > 0 && miktar <= bakiye)
                                                    {
                                                        bakiye -= miktar;

                                                        Console.WriteLine("Transfer başarılı.");
                                                        Console.WriteLine("Gönderilen miktar: " + miktar);
                                                        Console.WriteLine("Kalan bakiyeniz: " + bakiye);
                                                    karar:
                                                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                                        int karar = Convert.ToInt32(Console.ReadLine());

                                                        if (karar == 1)
                                                        {
                                                            goto ANAMENU;
                                                        }
                                                        else if (karar == 0)
                                                        {
                                                            Environment.Exit(0);
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("geçersiz sayı girdiniz");
                                                            goto karar;
                                                        }
                                                    }
                                                    else if (miktar <= 0)
                                                    {
                                                        Console.WriteLine("geçersiz sayı girdiniz");
                                                        goto ANAMENU;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Yetersiz bakiye ");
                                                    karar:
                                                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                                        int karar = Convert.ToInt32(Console.ReadLine());

                                                        if (karar == 1)
                                                        {
                                                            goto ANAMENU;
                                                        }
                                                        else if (karar == 0)
                                                        {
                                                            Environment.Exit(0);
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("geçersiz sayı girdiniz");
                                                            goto karar;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else if (seçim3 == 2)
                                        {
                                            Console.WriteLine("\nHesap Numarası?");
                                            string hesapNo = Console.ReadLine();
                                            if (hesapNo.Length == 11 && int.TryParse(hesapNo, out int hesapno))
                                            {
                                                Console.WriteLine("transfer edilecek miktar?");
                                                int miktar = Convert.ToInt32(Console.ReadLine());
                                                if (bakiye >= miktar && miktar>0)
                                                {
                                                    bakiye -= miktar;
                                                    Console.WriteLine("Yeni Bakiye:" + bakiye);
                                                karar:
                                                    Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                                    int karar = Convert.ToInt32(Console.ReadLine());

                                                    if (karar == 1)
                                                    {
                                                        goto ANAMENU;
                                                    }
                                                    else if (karar == 0)
                                                    {
                                                        Environment.Exit(0);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("geçersiz sayı girdiniz");
                                                        goto karar;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("yeterisz bakiye / geçerli bir sayı giriniz");
                                                karar:
                                                    Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                                    int karar = Convert.ToInt32(Console.ReadLine());

                                                    if (karar == 1)
                                                    {
                                                        goto ANAMENU;
                                                    }
                                                    else if (karar == 0)
                                                    {
                                                        Environment.Exit(0);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("geçersiz sayı girdiniz");
                                                        goto karar;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Geçersiz");
                                            goto ANAMENU;
                                        }
                                    }

                                    break;

                                case 4:
                                    Console.WriteLine("\nEğitim ödemeleri arızalı");
                                    goto ANAMENU;
                                    break;

                                case 5:
                                    Console.WriteLine("\nElektrik Faturası 1\nTelefon Faturası 2\nInternet Faturası 3\nSu Faturası 4\nOGS Ödemeleri 5");
                                    int seçim4 = Convert.ToInt32(Console.ReadLine());

                                    if (seçim4 == 1)
                                    {
                                        if (bakiye >= 1500)
                                        {
                                            bakiye -= 1500;
                                            Console.WriteLine("Fatura ödendi.Yeni Bakiye:" + bakiye);
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye!");
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                    }
                                    else if (seçim4 == 2)
                                    {
                                        if (bakiye >= 1500)
                                        {
                                            bakiye -= 1500;
                                            Console.WriteLine("Fatura ödendi.Yeni Bakiye:" + bakiye);
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye!");
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                    }
                                    else if (seçim4 == 3)
                                    {
                                        if (bakiye >= 1500)
                                        {
                                            bakiye -= 1500;
                                            Console.WriteLine("Fatura ödendi.Yeni Bakiye:" + bakiye);
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye!");
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                    }
                                    else if (seçim4 == 4)
                                    {
                                        if (bakiye >= 1500)
                                        {
                                            bakiye -= 1500;
                                            Console.WriteLine("Fatura ödendi.Yeni Bakiye:" + bakiye);
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye!");
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                    }
                                    else if (seçim4 == 5)
                                    {
                                        if (bakiye >= 1500)
                                        {
                                            bakiye -= 1500;
                                            Console.WriteLine("Fatura ödendi.Yeni Bakiye:" + bakiye);
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye!");
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Fatura Seçimi!");
                                    karar:
                                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                        int karar = Convert.ToInt32(Console.ReadLine());

                                        if (karar == 1)
                                        {
                                            goto ANAMENU;
                                        }
                                        else if (karar == 0)
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("geçersiz sayı girdiniz");
                                            goto karar;
                                        }
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("\nEski şifreniz?");
                                    string eskişifre = Console.ReadLine();
                                    if (eskişifre == şifre)
                                    {
                                    yeniSifre:
                                        Console.WriteLine("Yeni Şifreniz:");
                                        string yeniSifre = Console.ReadLine();

                                        Console.WriteLine("Tekrar Yeni Şifreniz:");
                                        string yeniSifre2 = Console.ReadLine();
                                        if (yeniSifre == yeniSifre2)
                                        {
                                            şifre = yeniSifre;
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("\ngeçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nyeni şifreleriniz uyuşmuyor!");
                                            goto yeniSifre;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("yanlış şifre girdiniz!");
                                    karar:
                                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                        int karar = Convert.ToInt32(Console.ReadLine());

                                        if (karar == 1)
                                        {
                                            goto ANAMENU;
                                        }
                                        else if (karar == 0)
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("geçersiz sayı girdiniz");
                                            goto karar;
                                        }
                                    }

                                    break;
                                default:
                                    Console.WriteLine("geçersiz seçim");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Yanlış şifre girdiniz.");
                        }
                        hak++;
                    }

                    Console.WriteLine("\nDeneme Hakkınzı Kalmadı");
                    break;

                case 2:
                ANAMENü:
                    Console.WriteLine("\n----------Ana Menü---------");
                    Console.WriteLine("Cepbank Para çekme 1\nPara yatırmak için 2\nKredi Kartı ödeme 3\nEğitim ödemeleri 4\nProgramdan çıkmak için 0");
                    int seçim = Convert.ToInt32(Console.ReadLine());
                    if (seçim == 0)
                    {
                        Environment.Exit(0);
                    }
                    else if (seçim == 1)
                    {
                        while (deneme < 3)
                        {
                            Console.WriteLine("Tc kimlik numaranızı giriniz.");
                            string tc = Console.ReadLine();
                            if (tcno.Length == 11 && long.TryParse(tcno, out long tcNumarasi) && tcno == tc)
                            {
                                Console.WriteLine("telefon numaranızı giriniz.");
                                string telno = Console.ReadLine();
                                if (telno.Length == 11 && telno.StartsWith("05") && long.TryParse(telno, out long numara) && telno == tel)
                                {
                                    bakiye += 1000;
                                    Console.WriteLine("yeni bakiye:" + bakiye);
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("girdiğiniz tc numarasıi kayıtlı olanla uyuşmuyor.\n");
                            }
                            deneme++;
                        }
                        Console.WriteLine("deneme hakkınız kalmadı.");
                    karar:
                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.\n");
                        int karar = Convert.ToInt32(Console.ReadLine());

                        if (karar == 1)
                        {
                            goto ANAMENü;
                        }
                        else if (karar == 0)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("geçersiz sayı girdiniz");
                            goto karar;
                        }
                        break;
                    }
                    else if (seçim == 2)
                    {
                        Console.WriteLine("\nNakit ödeme için 1 \nHesaptan ödeme için 2\nAna menü için 9\nProgramdan çıkmak için 0");
                        int flins = Convert.ToInt32(Console.ReadLine());
                        if (flins == 0)
                        {
                            Environment.Exit(0);
                        }
                        else if (flins == 9)
                        {
                            goto ANAMENü;
                        }
                        else if (flins == 1)
                        {
                            Console.WriteLine("Kredi kartı numaranızı giriniz:");
                            string kartNo = Console.ReadLine();

                            if (kartNo.Length >= 12 && long.TryParse(kartNo, out long kartNumarasi))
                            {
                                Console.WriteLine("TC kimlik numaranızı giriniz:");
                                string tc = Console.ReadLine();

                                if (tc.Length == 11 && long.TryParse(tc, out long tcNumarasi))
                                {
                                    Console.WriteLine("Ödeme nakit olarak gerçekleştirildi.");
                                }
                                else
                                {
                                    Console.WriteLine("TC kimlik numarası 11 haneli olmalıdır.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kart numarası 12 haneli olmalıdır.");
                            }
                        }
                        else if (flins == 2)
                        {
                            Console.WriteLine("12 haneli kart numaranızı girin");
                            string KartNo = Console.ReadLine();
                            if (KartNo.Length == 12 && long.TryParse(KartNo, out long kartNo))
                            {
                                Console.WriteLine("\nyatırılacak miktar?");
                                int miktar = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Hesap numarası?");
                                string hesapno = Console.ReadLine();
                                if (long.TryParse(hesapno, out long hesapNumarasi))
                                {

                                    if (bakiye >= miktar && miktar > 0)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Yeni Bakiye:" + bakiye);
                                    karar:
                                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.\n");
                                        int karar = Convert.ToInt32(Console.ReadLine());

                                        if (karar == 1)
                                        {
                                            goto ANAMENü;
                                        }
                                        else if (karar == 0)
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("geçersiz sayı girdiniz");
                                            goto karar;
                                        }
                                    }
                                    else if (miktar <= 0)
                                    {
                                        Console.WriteLine("geçersiz sayı girdiniz");
                                        goto ANAMENü;
                                    }
                                    else
                                    {
                                        Console.WriteLine("yeterisz bakiye");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine(" kart numaranız hatalı");
                            karar:
                                Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.\n");
                                int karar = Convert.ToInt32(Console.ReadLine());

                                if (karar == 1)
                                {
                                    goto ANAMENü;
                                }
                                else if (karar == 0)
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("geçersiz sayı girdiniz");
                                    goto karar;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("tuşladığınız sayı hatalı");
                        karar:
                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.\n");
                            int karar = Convert.ToInt32(Console.ReadLine());

                            if (karar == 1)
                            {
                                goto ANAMENü;
                            }
                            else if (karar == 0)
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("geçersiz sayı girdiniz");
                                goto karar;
                            }
                        }
                    }
                    else if (seçim == 3)
                    {
                        Console.WriteLine("\nBaşka hesaba EFT 1\nBaşkta hesaba havale 2");
                        int seçim5 = Convert.ToInt32(Console.ReadLine());
                        if (seçim5 == 1)
                        {
                            Console.WriteLine("IBAN:");
                            string iban = Console.ReadLine().ToUpper();

                            if (iban.StartsWith("TR") && iban.Length == 14)
                            {
                                string Iban = iban.Substring(2);
                                if (long.TryParse(Iban, out long IBAN))
                                {
                                    Console.WriteLine("\nTransfer edilecek miktar:");

                                    if (int.TryParse(Console.ReadLine(), out int miktar))
                                    {
                                        if (miktar > 0 && miktar <= bakiye)
                                        {
                                            bakiye -= miktar;

                                            Console.WriteLine("Transfer başarılı.");
                                            Console.WriteLine("Gönderilen miktar: " + miktar);
                                            Console.WriteLine("Kalan bakiyeniz: " + bakiye);
                                        }
                                        else if (miktar <= 0)
                                        {
                                            Console.WriteLine("geçersiz sayı girdiniz\n");
                                            goto ANAMENü;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye ");
                                        karar:
                                            Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                            int karar = Convert.ToInt32(Console.ReadLine());

                                            if (karar == 1)
                                            {
                                                goto ANAMENü;
                                            }
                                            else if (karar == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Console.WriteLine("geçersiz sayı girdiniz");
                                                goto karar;
                                            }
                                        }
                                    }
                                }
                            }
                            else if (seçim5 == 2)
                            {
                                Console.WriteLine("\nHesap Numarası?");
                                string hesapNo = Console.ReadLine();
                                if (hesapNo.Length == 11 && int.TryParse(hesapNo, out int hesapno))
                                {
                                    Console.WriteLine("transfer edilecek miktar?");
                                    int miktar = Convert.ToInt32(Console.ReadLine());
                                    if (bakiye >= miktar && miktar>0)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Yeni Bakiye:" + bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("yeterisz bakiye");
                                    karar:
                                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                        int karar = Convert.ToInt32(Console.ReadLine());

                                        if (karar == 1)
                                        {
                                            goto ANAMENü;
                                        }
                                        else if (karar == 0)
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.WriteLine("geçersiz sayı girdiniz");
                                            goto karar;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("hesap numarası yanlış girildi");
                                karar:
                                    Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                                    int karar = Convert.ToInt32(Console.ReadLine());

                                    if (karar == 1)
                                    {
                                        goto ANAMENü;
                                    }
                                    else if (karar == 0)
                                    {
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("geçersiz sayı girdiniz");
                                        goto karar;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz");
                                goto ANAMENü;
                            }
                        }
                    }
                    else if (seçim == 4)
                    {
                        Console.WriteLine("eğitim ödemeleri sayfası arızalıdır. daha sonra tekrar deneyin\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.");
                    karar:
                        int karar = Convert.ToInt32(Console.ReadLine());

                        if (karar == 1)
                        {
                            goto ANAMENü;
                        }
                        else if (karar == 0)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("geçersiz sayı girdiniz");
                            goto karar;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz tuşlama");
                    karar:
                        Console.WriteLine("\nAna menüye dönmek için 1, programdan çıkmak için 0 basınız.\n");
                        int karar = Convert.ToInt32(Console.ReadLine());

                        if (karar == 1)
                        {
                            goto ANAMENü;
                        }
                        else if (karar == 0)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("geçersiz sayı girdiniz");
                            goto karar;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("geçersiz");
                    break;
            }
        }
    }
}