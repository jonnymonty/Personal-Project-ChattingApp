using ChattingApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChattingApp
{
    /// <summary>
    /// The design time data for a <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatAttachmentPopupMenuDesignModel : ChatAttachmentPopupMenuViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatAttachmentPopupMenuDesignModel Instance { get; } = new ChatAttachmentPopupMenuDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatAttachmentPopupMenuDesignModel()
        {
        }

        #endregion

    }
}