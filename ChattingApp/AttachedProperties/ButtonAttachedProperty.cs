using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ChattingApp
{
    /// <summary>
    /// The IsBusy attached property for anything that wants to flag if the control is busy
    /// </summary>
    public class IsBusyProperty : BaseAttachedProperty<HasTextProperty, bool>
    {
    }
}
