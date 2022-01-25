namespace WebApp_Usuf.Models
{
    public class Lib
    {
        public bool isShow = false;

        #region Чугун литейный
        public double ChugLit_Si { get; set; }
        public double ChugLit_Mn { get; set; }
        public double ChugLit_Sto { get; set; }
        public double? ChugLit_Min { get; set; } = null;
        public double? ChugLit_Max { get; set; } = null;
        public double ChugLit_VsegT { get; set; }
        public double ChugLit_SiT { get => ChugLit_VsegT * ChugLit_Si / 100; }
        public double ChugLit_MnT { get => ChugLit_VsegT * ChugLit_Mn / 100; }
        public double ChugLit_Fakt()
        {
            return ChugLit_VsegT / (VsegoT / 100);
        }
        public double ChugLit_KonSto()
        {
            return ChugLit_VsegT * ChugLit_Sto;
        }
        #endregion
        #region Чугун передельный
        public double ChugPer_Si { get; set; }
        public double ChugPer_Mn { get; set; }
        public double ChugPer_Sto { get; set; }
        public double? ChugPer_Min { get; set; } = null;
        public double? ChugPer_Max { get; set; } = null;
        public double ChugPer_VsegT { get; set; }
        public double ChugPer_SiT { get => ChugPer_VsegT * ChugPer_Si / 100; }
        public double ChugPer_MnT { get => ChugPer_VsegT * ChugPer_Mn / 100; }
        public double ChugPer_Fakt()
        {
            return ChugPer_VsegT / (VsegoT / 100);
        }
        public double ChugPer_KonSto()
        {
            return ChugPer_VsegT * ChugPer_Sto;
        }
        #endregion
        #region Чугун зеркальный
        public double ChugZer_Si { get; set; }
        public double ChugZer_Mn { get; set; }
        public double ChugZer_Sto { get; set; }
        public double? ChugZer_Min { get; set; } = null;
        public double? ChugZer_Max { get; set; } = null;
        public double ChugZer_VsegT { get; set; }
        public double ChugZer_SiT { get => ChugZer_VsegT * ChugZer_Si / 100; }
        public double ChugZer_MnT { get => ChugZer_VsegT * ChugZer_Mn / 100; }
        public double ChugZer_Fakt()
        {
            return ChugZer_VsegT / (VsegoT / 100);
        }
        public double ChugZer_KonSto()
        {
            return ChugZer_VsegT * ChugZer_Sto;
        }
        #endregion
        #region Лом чугунный
        public double LomChug_Si { get; set; }
        public double LomChug_Mn { get; set; }
        public double LomChug_Sto { get; set; }
        public double? LomChug_Min { get; set; } = null;
        public double? LomChug_Max { get; set; } = null;
        public double LomChug_VsegT { get; set; }
        public double LomChug_SiT { get => ChugLit_VsegT * LomChug_Si / 100; }
        public double LomChug_MnT { get => ChugLit_VsegT * LomChug_Mn / 100; }
        public double LomChug_Fakt()
        {
            return LomChug_VsegT / (VsegoT / 100);
        }
        public double LomChug_KonSto()
        {
            return LomChug_VsegT * LomChug_Sto;
        }
        #endregion
        #region Лом стальной
        public double LomSta_Si { get; set; }
        public double LomSta_Mn { get; set; }
        public double LomSta_Sto { get; set; }
        public double? LomSta_Min { get; set; } = null;
        public double? LomSta_Max { get; set; } = null;
        public double LomSta_VsegT { get; set; }
        public double LomSta_SiT { get => LomSta_VsegT * LomSta_Si / 100; }
        public double LomSta_MnT { get => LomSta_VsegT * LomSta_Mn / 100; }
        public double LomSta_Fakt()
        {
            return LomSta_VsegT / (VsegoT / 100);
        }
        public double LomSta_KonSto()
        {
            return LomSta_VsegT * LomSta_Sto;
        }
        #endregion
        #region Возврат
        public double Vozr_Si { get; set; }
        public double Vozr_Mn { get; set; }
        public double Vozr_Sto { get; set; }
        public double? Vozr_Min { get; set; } = null;
        public double? Vozr_Max { get; set; } = null;
        public double Vozr_VsegT { get; set; }
        public double Vozr_SiT { get => Vozr_VsegT * Vozr_Si / 100; }
        public double Vozr_MnT { get => Vozr_VsegT * Vozr_Mn / 100; }
        public double Vozr_Fakt()
        {
            return Vozr_VsegT / (VsegoT / 100);
        }
        public double Vozr_KonSto()
        {
            return Vozr_VsegT * Vozr_Sto;
        }
        #endregion
        #region Ферросилиций 45%
        public double Ferr_Si { get; set; }
        public double Ferr_Mn { get; set; }
        public double Ferr_Sto { get; set; }
        public double? Ferr_Min { get; set; } = null;
        public double? Ferr_Max { get; set; } = null;
        public double Ferr_VsegT { get; set; }
        public double Ferr_SiT { get => Ferr_VsegT * Ferr_Si / 100; }
        public double Ferr_MnT { get => Ferr_VsegT * Ferr_Mn / 100; }
        public double Ferr_Fakt()
        {
            return Ferr_VsegT / (VsegoT / 100);
        }
        public double Ferr_KonSto()
        {
            return Ferr_VsegT * Ferr_Sto;
        }
        #endregion

        public double VsegoT { get => ChugLit_VsegT + ChugPer_VsegT + ChugZer_VsegT + LomChug_VsegT + LomSta_VsegT + Vozr_VsegT + Ferr_VsegT; }

        #region Ограничения по элементам в конечном сплаве
        public double? SiT_Min { get; set; } = null;
        public double? SiT_Max { get; set; } = null;
        public double Si_Fakt()
        {
            return (ChugLit_SiT + ChugPer_SiT + ChugZer_SiT + LomChug_SiT + LomSta_SiT + Vozr_SiT + Ferr_SiT) / (VsegoT / 100);
        }
        public double? MnT_Min { get; set; } = null;
        public double? MnT_Max { get; set; } = null;
        public double Mn_Fakt()
        {
            return (ChugLit_MnT + ChugPer_MnT + ChugZer_MnT + LomChug_MnT + LomSta_MnT + Vozr_MnT + Ferr_MnT) / (VsegoT / 100);
        }
        #endregion

        public double SumSto()
        {
            return ChugLit_KonSto() + ChugPer_KonSto() + ChugZer_KonSto() + LomChug_KonSto() + LomSta_KonSto() + Vozr_KonSto() + Ferr_KonSto();
        }
    }
}
