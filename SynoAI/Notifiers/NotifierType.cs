﻿
namespace SynoAI.Notifiers
{
    /// <summary>
    /// A list of support notification types.
    /// </summary>
    public enum NotifierType
    {
        /// <summary>
        /// Sends a notification email with the image attached.
        /// </summary>
        Email,
        /// <summary>
        /// Sends a notification message and image using the Pushbullet API.
        /// </summary>
        Pushbullet,
        /// <summary>
        /// Sends a notification message and image using the Pushover API.
        /// </summary>
        Pushover,
        /// <summary>
        /// Sends a notification to Telegram with the image attached.
        /// </summary>
        Telegram,
        /// <summary>
        /// Calls a webhook with the image attached.
        /// </summary>
        Webhook
    }
}
