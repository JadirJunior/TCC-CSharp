using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.userControls.Classes
{
    public class Items
    {
        public Dictionary<int, String> items = new Dictionary<int, string>();
        private static String _seisMeses = "6 Meses";
        private static String _tresMeses = "3 Meses";
        private static String _umMes = "1 mês";
        private static String _umaSemana = "Uma semana";
        public static String SeisMeses
        {
            get {
                return _seisMeses;
            }
            set {
                SeisMeses = _seisMeses;
            }
        }

        public Items()
        {
            items.Add(1, _seisMeses);
            items.Add(2, _tresMeses);
            items.Add(3, _umMes);
            items.Add(4, _umaSemana);
        }

        public static String TresMeses
        {
            get
            {
                return _tresMeses;
            }
            set
            {
                TresMeses = _tresMeses;
            }
        }

        public static String UmMes
        {
            get
            {
                return _umMes;
            }
            set
            {
                UmMes = _umMes;
            }
        }

        public static String UmaSemana {
            get
            {
                return _umaSemana;
            }

            set
            {
                UmaSemana = _umaSemana;
            }
        }

    }
}
