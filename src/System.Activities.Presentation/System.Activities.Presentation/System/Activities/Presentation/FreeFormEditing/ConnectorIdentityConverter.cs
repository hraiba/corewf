//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace System.Activities.Presentation.FreeFormEditing
{
    using System.Windows.Data;
    using System.Activities.Runtime;
    using System.Windows.Media;
    using System.Globalization;
    using System.Activities.Internals;
    using System.Activities.Runtime;

    class ConnectorIdentityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Fx.Assert(values[0] is Guid, "The first value should be a Guid");
            Fx.Assert(values[1] is PointCollection, "The second value should be a PointCollection");
            Guid identityGuid = (Guid)values[0];
            PointCollection points = (PointCollection)values[1];
            return identityGuid + "," + points.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw FxTrace.Exception.AsError(new NotSupportedException());
        }
    }
}
