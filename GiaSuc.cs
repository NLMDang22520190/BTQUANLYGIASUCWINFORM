using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTQUANLYGIASUCWINFORM
{
    public abstract class GiaSuc
    {
        public int SoLuong { get; set; }
        public int SoConSinhRa { get; set; }
        public int SoLitSua { get; set; }
        public string TiengKeu { get; set; }

        public GiaSuc(int soLuong)
        {
            SoLuong = soLuong;
        }

        public abstract void PhatTiengKeu();
        public abstract int SinhCon();
        public abstract int ChoSua();
    }

    public class Bo : GiaSuc
    {
        public Bo(int soLuong) : base(soLuong)
        {
            TiengKeu = "Bò: Ò ò ò";
        }

        public override void PhatTiengKeu()
        {
            Debug.WriteLine(TiengKeu);
        }

        public override int SinhCon()
        {
            SoConSinhRa = new Random().Next(1, SoLuong + 1);
            return SoConSinhRa;
        }

        public override int ChoSua()
        {
            SoLitSua = new Random().Next(0, 21) * SoLuong;
            return SoLitSua;
        }
    }

    public class Cuu : GiaSuc
    {
        public Cuu(int soLuong) : base(soLuong)
        {
            TiengKeu = "Cừu: Bê ê ê";
        }

        public override void PhatTiengKeu()
        {
            Debug.WriteLine(TiengKeu);
        }

        public override int SinhCon()
        {
            SoConSinhRa = new Random().Next(1, SoLuong + 1);
            return SoConSinhRa;
        }

        public override int ChoSua()
        {
            SoLitSua = new Random().Next(0, 6) * SoLuong;
            return SoLitSua;
        }
    }

    public class De : GiaSuc
    {
        public De(int soLuong) : base(soLuong)
        {
            TiengKeu = "Dê: Be e e";
        }

        public override void PhatTiengKeu()
        {
            Debug.WriteLine(TiengKeu);
        }

        public override int SinhCon()
        {
            SoConSinhRa = new Random().Next(1, SoLuong + 1);
            return SoConSinhRa;
        }

        public override int ChoSua()
        {
            SoLitSua = new Random().Next(0, 11) * SoLuong;
            return SoLitSua;
        }
    }

}
