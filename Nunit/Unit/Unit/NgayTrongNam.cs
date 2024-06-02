using System;

namespace Unit
{
    public class NgayTrongNam
    {
        private int ngay, thang, nam;
        public NgayTrongNam(int ngay, int thang, int nam)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }
        public bool KiemTraNamNhuan(int nam)
        {
            return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
        }

        public int TimSoNgayTrongThang(int thang, int nam)
        {
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return KiemTraNamNhuan(nam) ? 29 : 28;
                default:
                    throw new ArgumentOutOfRangeException("Thang khong hop le");
            }
        }

        public int TimNgayThuBaoNhieuTrongNam()
        {
            int s = ngay;
            for (int i = 1; i < thang; i++)
            {
                s += TimSoNgayTrongThang(i, nam);
            }
            return s;
        }
    }
}