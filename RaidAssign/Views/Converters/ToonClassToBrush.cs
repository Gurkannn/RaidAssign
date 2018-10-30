using RaidAssign.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace RaidAssign.Views.Converters
{
    class ToonClassToBrush : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var r = (Classes)value;
            switch (r)
            {
                case Classes.Warrior:
                    return Brushes.SaddleBrown;
                case Classes.Druid:
                    return Brushes.Orange;
                case Classes.Shaman:
                    return Brushes.DarkBlue;
                case Classes.Priest:
                    return Brushes.WhiteSmoke;
                case Classes.Paladin:
                    return Brushes.DeepPink;
                case Classes.Rogue:
                    return Brushes.Yellow;
                case Classes.Warlock:
                    return Brushes.MediumPurple;
                case Classes.Mage:
                    return Brushes.AliceBlue;
                case Classes.Hunter:
                    return Brushes.ForestGreen;
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
