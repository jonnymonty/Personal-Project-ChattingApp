﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingApp.Core
{
    /// <summary>
    /// A view model for each chat message thread item's attachment (in this case an image) in a chat thread
    /// </summary>
    public class ChatMessageListItemImageAttachmentViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// The thumbnail url
        /// </summary>
        private string mThumbnailUrl;

        #endregion

        /// <summary>
        /// The title of this image file
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The original file name of the attachment
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The file size in bytes of this attachment
        /// </summary>
        public long FileSize { get; set; }

        public string ThumbnailUrl
        {
            get => mThumbnailUrl;
            set
            {
                // If value didn't change, return 
                if (value == mThumbnailUrl)
                    return;

                // Update value
                mThumbnailUrl = value;

                // TODO: Download image from website
                //       Save file to local storage/cache
                //       Set LocalFilePath value
                //
                //       For now, just set the file path directly
                Task.Delay(2000).ContinueWith(t => LocalFilePath = "/Images/Samples/rusty.jpg");
            }
        }

        /// <summary>
        /// The local file path pn this machine to the downloaded thumbnail
        /// </summary>
        public string LocalFilePath { get; set; }
    }
}