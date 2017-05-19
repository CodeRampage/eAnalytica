using Emissions_Analytica.Pages;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Emissions_Analytica
{

    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find appropriate page
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Browser:
                    return new LoginScreen();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
