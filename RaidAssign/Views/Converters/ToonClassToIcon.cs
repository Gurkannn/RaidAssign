using RaidAssign.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RaidAssign.Views.Converters
{
    public class ToonClassToIcon : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cls = (Classes)value;
            switch (cls)
            {
                case Classes.Warrior:
                    return "/Icons/Warrior_Icon.gif";
                case Classes.Druid:
                    return "/Icons/Druid_Icon.gif";
                case Classes.Shaman:
                    return "/Icons/Shaman_Icon.gif";
                case Classes.Priest:
                    return "/Icons/Priest_Icon.gif";
                case Classes.Paladin:
                    return "/Icons/Paladin_Icon.gif";
                case Classes.Rogue:
                    return "/Icons/Rogue_Icon.gif";
                case Classes.Warlock:
                    return "/Icons/Warlock_Icon.gif";
                case Classes.Mage:
                    return "/Icons/Mage_Icon.gif";
                case Classes.Hunter:
                    return "/Icons/Hunter_Icon.gif";
                default:
                    return null;
            }            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
