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
    public class RaidMarkerToIcon : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var m = (RaidMarker)value;
            switch (m)
            {
                case RaidMarker.Skull:
                    return "/Icons/Markers/Skull.gif";
                case RaidMarker.Cross:
                    return "/Icons/Markers/Cross.gif";                    
                case RaidMarker.Square:
                    return "/Icons/Markers/Square.gif";                    
                case RaidMarker.Moon:
                    return "/Icons/Markers/Moon.gif";                    
                case RaidMarker.Triangle:
                    return "/Icons/Markers/Triangle.gif";                    
                case RaidMarker.Diamond:
                    return "/Icons/Markers/Diamond.gif";
                case RaidMarker.Circle:
                    return "/Icons/Markers/Circle.gif";
                case RaidMarker.Star:
                    return "/Icons/Markers/Star.gif";
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
