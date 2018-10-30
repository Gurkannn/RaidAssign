using RaidAssign.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace RaidAssign.Views.Converters
{
    public class SlotTypeToIcon : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var s = (SlotTypes)value;
            switch (s)
            {
                case SlotTypes.Tank:
                    return "/Icons/Tank_Icon.png";
                case SlotTypes.Interrupt:
                    return "/Icons/Kick_Icon.png";
                case SlotTypes.Sheep:
                    return "/Icons/Poly_Icon.jpg";
                case SlotTypes.Banish:
                    return "/Icons/Banish_Icon.jpg";
                case SlotTypes.Tranq:
                    return "/Icons/Tranq_Icon.jpg";
                default:
                    break;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
