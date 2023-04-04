using System.ComponentModel.Design;

namespace Weaponprop.Modules;

internal class Weapon
{
    private double _bulletcapacity;
    private double _bulletcount;
    private double _dischargetime;
    private string _shootingmode;
    public double bulletcapacity
    {
        get
        {
            if (_bulletcapacity != 0)
            {
                return _bulletcapacity;
            }
            return -1;
        }
        set
        {
            if (value > 0)
            {
                _bulletcapacity = value;
                return;
            }
            Console.WriteLine("daragin max gulle sayi menfi ola bilmez");
        }
    }
    public double bulletcount
    {
        get
        {
            if (_bulletcount != 0)
            {
                return _bulletcount;
            }
            return -1;
        }
        set
        {
            if (value <= bulletcapacity && value > 0)
            {
                _bulletcount = value;
                return;
            }
            Console.WriteLine("Daragdaki gulle sayi daragdin max gulle sayindan boyuk ve menfi ola bilmez");
        }
    }
    public double dischargetime
    {
        get
        {
            if (_dischargetime != 0)
            {
                return _dischargetime;
            }
            return -1;
        }
        set
        {
            if (value > 0)
            {
                _dischargetime = value;
                return;
            }
        }
    }
    public string shootingmode
    {
        get
        {
            if (!string.IsNullOrEmpty(_shootingmode))
            {
                return _shootingmode;
            }
            return "";
        }
        set
        {
            if (value == "single" || value == "auto")
            {
                _shootingmode = value;
            }
        }
    }
    public Weapon(double bulletcapacity, double bulletcount, double dischargetime, string shootingmode)
    {
        shootingmode = shootingmode.Trim().ToLower();
        this.bulletcapacity = bulletcapacity;
        this.bulletcount = bulletcount;
        this.dischargetime = dischargetime;
        this.shootingmode = shootingmode;
    }
    public void Information()
    {
        Console.WriteLine("\nSilahin adi: M4A1");
        Console.WriteLine($"Daragin max tutdugu gulle sayi: {_bulletcapacity}");
        Console.WriteLine($"Daragda olan gulle sayi: {_bulletcount}");
        Console.WriteLine($"Daragin max halinda bosalma vaxti: {_dischargetime} saniye");
        Console.WriteLine($"Atis modu: {_shootingmode}\n");
    }
    public void ChangeFireMode()
    {
        if (_shootingmode == "single")
        {
            _shootingmode = "auto";
            Console.WriteLine("\nauto mode aktiv edildi\n");
        }
        else if (_shootingmode == "auto")
        {
            _shootingmode = "single";
            Console.WriteLine("\nsingle mode aktiv edildi\n");
        }
    }
    public void Shoot()
    {
        if (_shootingmode == "single")
        {
            if (_bulletcount > 0)
            {
                _bulletcount--;
                Console.WriteLine($"\n1 gulle atdiniz.Sizin {_bulletcount} sayda gulleniz qaldi\n");
            }
            else
            {
                Console.WriteLine("\nDaraginizda gulle yoxdur.Reload atin\n");
            }
        }
        else
        {
            Console.WriteLine("\nOtomatik moddasiniz.\n");
        }
    }
    public void Fire()
    {
        if (_shootingmode == "auto")
        {
            if (_bulletcount > 0)
            {
                Console.WriteLine($"\nSilahinizdaki gulleler {(_bulletcount / bulletcapacity) * _dischargetime} saniyeye qutardi\n");
                _bulletcount = 0;
            }
            else
            {
                Console.WriteLine("\nDarağinizda gulle yoxdur.Reload atin\n");
            }
        }
        else
        {
            Console.WriteLine("\nTekli moddasiz.\n");
        }
    }
    public void GetRemainBulletCount()
    {
        Console.WriteLine($"\nDaragi tam doldurmaq uçun {bulletcapacity - _bulletcount} eded gulle lazimdir\n");
    }
    public void Reload()
    {
        _bulletcount = bulletcapacity;
        Console.WriteLine($"\nSilahinizin daraği yenilendi\n");
    }
    public void ChangeInfo()
    {
        Console.WriteLine("\nT - Tutumu deyissin");
        Console.WriteLine("S - Gulle sayini deyissin");
        Console.WriteLine("D - Sifirlama saniyesi deyissin\n");
        Console.Write("Secin:");
        string change = Console.ReadLine().ToUpper();

        if (change == "T")
        {
            Console.Write("Deyismek istediyin deyeri daxil ele: ");
            double bulletcapacity = Double.Parse(Console.ReadLine());
            if (bulletcapacity > 0)
            {
                _bulletcapacity = bulletcapacity;
            }
            else
            {
                Console.WriteLine("\nyanlis deyer daxil etmisiniz\n");
            }
        }

        else if (change == "S")
        {
            Console.Write("Deyismek istediyin deyeri daxil ele: ");
            double bulletCount = Double.Parse(Console.ReadLine());
            if (bulletcount >= 0)
            {
                _bulletcount = bulletcount;
            }
            else
            {
                Console.WriteLine("\nYanlis deyer daxil etmisiniz\n");
            }
        }

        else if (change == "D")
        {
            Console.Write("Deyismek istediyin deyeri daxil ele: ");
            double dischargetime = Double.Parse(Console.ReadLine());
            if (dischargetime > 0)
            {
                _dischargetime = dischargetime;
            }
            else
            {
                Console.WriteLine("\nYanlis deyer daxil etmisiniz\n");
            }
        }
        else
        {
            Console.WriteLine("Yanlis format");
        }
    }

}
