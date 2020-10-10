using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311052_abc
{
    class ABC
    {
        Random rnd;
        int cs;
        const int d = 2;
        int l;
        int kaynak;
        public double[,] kaynakPozisyonları;
        public double[,] fazDegerleri;
        public double[] fxDegerleri;
        public double[] fitnessDegerleri;
        public double[] fazFxDegeri;
        public double[] fazFitnessDegeri;
        int[,] hakDizisi;
        public int degisiklikSayisi = 0;
        public double[] uygunlukDegerleri;
        public ABC(int cs)
        {
            this.cs = cs;
            l = (cs * d) / 2;
            kaynak = cs / 2;
            diziOlustur();
            KonumBelirle();
            FonksiyonHesapla();
            Fitness();
            HakTanimla();
            FazHesapla();
            for (int i = 0; i < l; i++)
            {
                Degistir();
            }
            UygunlukDegeriHesapla();
        }
        private void HakTanimla()
        {
            hakDizisi = new int[kaynak, 1];
            for (int i = 0; i < kaynak; i++)
            {
                hakDizisi[i, 0] = l;
            }
        }
        private void diziOlustur()
        {
            uygunlukDegerleri = new double[kaynak];
            kaynakPozisyonları = new double[kaynak, 2];
            fxDegerleri = new double[kaynak];
            fitnessDegerleri = new double[kaynak];
            fazDegerleri = new double[kaynak, 2];
            fazFxDegeri = new double[kaynak];
            fazFitnessDegeri = new double[kaynak];
        }
        private void KonumBelirle()
        {
            rnd = new Random();
            for (int i = 0; i < kaynak; i++)
            {
                double x = rnd.NextDouble() * rnd.Next(-10, 10);
                double y= rnd.NextDouble() * rnd.Next(-10, 10);
                if (x==0 || y==0)
                {
                    x = rnd.NextDouble() * rnd.Next(-10, 10);
                    y = rnd.NextDouble() * rnd.Next(-10, 10);
                    kaynakPozisyonları[i, 0] = x;
                    kaynakPozisyonları[i, 1] = y;
                    
                }
                else
                {
                    kaynakPozisyonları[i, 0] = x;
                    kaynakPozisyonları[i, 1] = y;
                }
                
            }
        }
        private double FonksiyonHesaplama(double x,double y)
        {
            double fxDegeri= -(Math.Abs((Math.Sin(x) * Math.Cos(y)) * Math.Exp(
                    Math.Abs(1 - ((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) / 3.14))
                    )));
            return fxDegeri;
        }
        private void FonksiyonHesapla()
        {
            for (int i = 0; i < kaynak; i++)
            {
                fxDegerleri[i] = FonksiyonHesaplama(kaynakPozisyonları[i, 0], kaynakPozisyonları[i, 1]);
            }
        }
        private double FitnessHesapla(double fxDegeri)
        {
            double fitnessDegeri = 0;
            if (fitnessDegeri >= 0)
            {
                fitnessDegeri = 1 / (1 + fxDegeri);
            }
            else
            {
                fitnessDegeri = 1 + Math.Abs(fxDegeri);
            }

            return fitnessDegeri;
        }
        private void Fitness()
        {
            for (int i = 0; i < kaynak; i++)
            {

                fitnessDegerleri[i] = FitnessHesapla(fxDegerleri[i]);
            }
        }
        private void FazHesabı(int i)
        {
                int k = Math.Abs(rnd.Next(0, kaynak) - i);
                double j = rnd.NextDouble() * rnd.Next(-1, 1);
                fazDegerleri[i, 0] = kaynakPozisyonları[i, 0] + (j * (kaynakPozisyonları[i, 0] - kaynakPozisyonları[k, 0]));
                fazDegerleri[i, 1] = kaynakPozisyonları[i, 1] + (j * (kaynakPozisyonları[i, 1] - kaynakPozisyonları[k, 1]));
                fazFxDegeri[i] = FonksiyonHesaplama(fazDegerleri[i, 0], fazDegerleri[i, 1]);
                fazFitnessDegeri[i] = FitnessHesapla(fazFxDegeri[i]);
 
            
        }
        
        private void FazHesapla()
        {
            for (int i = 0; i < kaynak; i++)
            {
                FazHesabı(i);
            }
        }
        
        private void Degistir()
        {
            for (int i = 0; i < kaynak; i++)
            {
                if (fazFitnessDegeri[i]>fitnessDegerleri[i])
                {
                    if (hakDizisi[i,0]!=0)
                    {
                        degisiklikSayisi++;
                        fitnessDegerleri[i] = fazFitnessDegeri[i];
                        kaynakPozisyonları[i, 1] = fazDegerleri[i, 1];
                        hakDizisi[i, 0] = 0;
                    } 
                }
                else
                {
                    FazHesabı(i);
                    hakDizisi[i, 0]--;
                }
            }
        }
        private void UygunlukDegeriHesapla()
        {
            double toplam = 0;
            for (int i = 0; i < kaynak; i++)
            {
                toplam += fitnessDegerleri[i];
            }
            for (int i = 0; i < kaynak; i++)
            {
                uygunlukDegerleri[i] = fitnessDegerleri[i] / toplam;
            }
        }
    }
}
