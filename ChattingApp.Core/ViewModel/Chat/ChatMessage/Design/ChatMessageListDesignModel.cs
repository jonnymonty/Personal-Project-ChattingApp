using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingApp.Core
{
    /// <summary>
    /// The design time data for a <see cref="ChatMessageListViewModel"/>
    /// </summary>
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListDesignModel Instance { get; } = new ChatMessageListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListDesignModel()
        {
            Items = new List<ChatMessageListItemViewModel>
            {
                new ChatMessageListItemViewModel
                {
                    Initials = "PL",
                    SenderName = "Parnell",
                    Message = "I'm about to wipe the server. We need to update to the old windows server to the new 2018 version",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ChatMessageListItemViewModel
                {
                    Initials = "LM",
                    SenderName = "Luke",
                    Message = "Let me know when you manage to spin up the new 2018 server",
                    ProfilePictureRGB = "ff0000",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3)),
                    SentByMe = true
                },
                new ChatMessageListItemViewModel
                {
                    Initials = "PL",
                    SenderName = "Parnell",
                    Message = "The new server is up. Go to 192.168.0.1.\r\nUsername is admin, password is P8ssw0rd!",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                }
            };
        }

        #endregion

    }
}