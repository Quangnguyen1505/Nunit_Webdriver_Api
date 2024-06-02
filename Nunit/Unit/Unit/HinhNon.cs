using System;

namespace Unit
{
    public class HinhNon
    {
        private double banKinhDay, chieuCao;
        public HinhNon(double banKinhDay, double chieuCao)
        {
            this.banKinhDay = banKinhDay;
            this.chieuCao = chieuCao;
        }

        public double TinhTheTich()
        {
            double theTich = (1.0 / 3.0) * Math.PI * banKinhDay * banKinhDay * chieuCao;
            return theTich;
        }
    }
}