using System;
using Base.ViewModel;
using Base.Command;

namespace KNP_Urban.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        #region Globální proměnné ViewModelu
        private int _pobrazek;
        private int _uobrazek;
        private int _sazka;
        private int _banka;
        private Model.PKNP PKNP;
        private string _hodnoceni;
        private Model.Vyhodnot Hodnot;
        #endregion

        #region Deklarace bindovatelných vlastností
        public int PObrazek { get { return _pobrazek; } set { _pobrazek = value; ChangeProperty("PObrazek"); } }
        public int UObrazek { get { return _uobrazek; } set { _uobrazek = value; ChangeProperty("UObrazek"); } }
        public int Sazka { get { return _sazka; } set { _sazka = value; ChangeProperty("Sazka"); } }
        public int Banka { get { return _banka; } set { _banka = value; ChangeProperty("Banka"); } }
        public string Hodnoceni { get { return _hodnoceni; } set { _hodnoceni = value; ChangeProperty("Hodnoceni"); } }
        #endregion

        #region Deklarace Command
        public Command<string> _hrej { get; set; }
        #endregion

        #region Metody pro obsluhu Command

        public void Hrej(string a)
        {
            if(Sazka > Banka || Sazka < 0)
            { Hodnoceni = "Nemate dost penez / nesazejte zaporna cisla"; }
            else
            { 
            switch (a)
            { 
                case "kamen": UObrazek = 5; break;
                case "nuzky": UObrazek = 6; break;
                case "papir": UObrazek = 4; break;
                default: break;
            }
            PObrazek = PKNP.VyberKNP();
            switch (Hodnot.Vyhodnoceni(PObrazek, UObrazek))
            {
                case 1: Hodnoceni = "Remiza"; Sazka = 0; break;
                case 2: Hodnoceni = "Prohral jste"; Banka = Banka - Sazka; Sazka = 0; break;
                case 3: Hodnoceni = "Vyhral jste"; Banka = Banka + Sazka; Sazka = 0; break;
                default: break;
            }
            }
        }


        #endregion

        public MainViewModel()
        {
            /*
            Name = "Start";
            NewCommand = new Command(SetName, param => { return true; });     
             */
            Hodnoceni = "";
            Banka = 1000;
            Sazka = 0;
            PObrazek = 0;
            UObrazek = 0;
            _hrej = new Command<string>(Hrej);
            PKNP = new Model.PKNP();
            Hodnot = new Model.Vyhodnot();
        }

        public new void ChangeProperty(string propertyName) { base.ChangeProperty(propertyName); }
    }
}
