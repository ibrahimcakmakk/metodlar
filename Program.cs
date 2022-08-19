using System;

class Program{

    static void Main(string[] args){

        //erişim_belirleyici geri_dönüştipi metod_adi(parametreListesi/argüman)
            //komutlar
            //return

            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);
            int sonuc = Topla(a,b);
            Metodlar örnek = new Metodlar();
            örnek.EkranaYazdır(Convert.ToString(sonuc));

            örnek.EkranaYazdır(Convert.ToString(a+b));
            int sonuc2 = örnek.ArttırVeToplam(a,b);
            
    }
    static int Topla(int deger1,int deger2){
        return (deger1 + deger2);
    }
}

class Metodlar{

    public void EkranaYazdır(String veri){
        Console.WriteLine(veri);
    }

    public int ArttırVeToplam(int deger1 , int deger2){
        deger1 +=1;
        deger2 +=1;
        return deger1 + deger2;
    }
}