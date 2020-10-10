using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311052_abc
{
    class GozcuAri
    {
        Random rnd;
        int cs;
        const int d = 2;
        int l;
        int kaynak;
        private double[,] kaynakDegerleri;
        public double[,] gozcuKaynak;
        public double[,] fazDegerleri;
        public double[] fxDegerleri;
        public double[] fitnessDegerleri;
        public double[] fazFxDegeri;
        public double[] fazFitnessDegeri;
        int[,] hakDizisi;
        public int degisiklikSayisi = 0;
        public double[] uygunlukDegerleri;
        public GozcuAri(int cs,double [,] kaynakDegerleri,double [] uygunlukDegerleri)
        {
            this.uygunlukDegerleri = uygunlukDegerleri;
            this.kaynakDegerleri = kaynakDegerleri;
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
            gozcuKaynak = new double[kaynak, 2];
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
                double y = rnd.NextDouble() * rnd.Next(-10, 10);
                if (x == 0 || y == 0)
                {
                    x = rnd.NextDouble() * rnd.Next(-10, 10);
                    y = rnd.NextDouble() * rnd.Next(-10, 10);
                    gozcuKaynak[i, 0] = x;
                    gozcuKaynak[i, 1] = y;

                }
                else
                {
                    gozcuKaynak[i, 0] = x;
                    gozcuKaynak[i, 1] = y;
                }

            }
        }
        private double FonksiyonHesaplama(double x, double y)
        {
            double fxDegeri = -(Math.Abs((Math.Sin(x) * Math.Cos(y)) * Math.Exp(
                    Math.Abs(1 - ((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) / 3.14))
                    )));
            return fxDegeri;
        }
        private void FonksiyonHesapla()
        {
            for (int i = 0; i < kaynak; i++)
            {
                fxDegerleri[i] = FonksiyonHesaplama(gozcuKaynak[i, 0], gozcuKaynak[i, 1]);
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
            double temp = 10;
                int uygunRandom = 0;
                double randomSayi = rnd.NextDouble();
                for (int m = 0; m < kaynak; m++)
                {
                    double fark = Math.Abs(uygunlukDegerleri[m] - randomSayi);
                    if (fark < temp)
                    {
                        temp = fark;
                        uygunRandom = m;
                    }
                }
                double j = rnd.NextDouble() * rnd.Next(-1, 1);
                fazDegerleri[i, 0] = gozcuKaynak[i, 0] + (j * (gozcuKaynak[i, 0] - kaynakDegerleri[uygunRandom, 0]));
                fazDegerleri[i, 1] = gozcuKaynak[i, 1] + (j * (gozcuKaynak[i, 1] - kaynakDegerleri[uygunRandom, 1]));
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
                if (fazFitnessDegeri[i] > fitnessDegerleri[i])
                {
                    if (hakDizisi[i, 0] != 0)
                    {
                        degisiklikSayisi++;
                        fitnessDegerleri[i] = fazFitnessDegeri[i];
                        gozcuKaynak[i, 1] = fazDegerleri[i, 1];
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
    
    }
}
