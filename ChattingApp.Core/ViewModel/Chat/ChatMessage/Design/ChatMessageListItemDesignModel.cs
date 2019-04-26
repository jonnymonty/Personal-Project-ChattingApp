using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingApp.Core
{
    /// <summary>
    /// The design time data for a <see cref="ChatMessageListItemViewModel"/>
    /// </summary>
    public class ChatMessageListItemDesignModel : ChatMessageListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListItemDesignModel Instance { get; } = new ChatMessageListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListItemDesignModel()
        {
            Initials = "LM";
            SenderName = "Luke";
            Message = "Some design time visual text";
            ProfilePictureRGB = "ff0000";
            SentByMe = true;
            MessageSentTime = DateTimeOffset.UtcNow;
            MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3));
        }

        #endregion

    }
}