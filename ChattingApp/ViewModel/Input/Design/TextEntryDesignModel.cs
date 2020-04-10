using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingApp
{
    /// <summary>
    /// The design-time data for a <see cref="TextEntryViewModel"/>
    /// </summary>
    public class TextEntryDesignModel : TextEntryViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static TextEntryDesignModel Instance { get; } = new TextEntryDesignModel();

        #endregion

        #region Constructor

        public TextEntryDesignModel()
        {
            Label = "Name";
            OriginalText = "Luke Melrose";
            EditedText = "Editing";
        }

        #endregion
    }
}