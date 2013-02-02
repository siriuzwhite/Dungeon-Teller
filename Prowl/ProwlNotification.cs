// By Casey Watson
// http://www.caseywatson.com/

using System;

namespace Prowl
{
    public struct ProwlNotification
    {
        private const int DESCRIPTION_MAX_LENGTH = 10000;
        private const int EVENT_MAX_LENGTH = 1024;

        private const string EX_MSG_DESCRIPTION_EXCEEDS_MAX_LENGTH =
            "Provided notification description exceeds the maximum allowed length [{0}]; unable to proceed.";

        private const string EX_MSG_DESCRIPTION_NOT_PROVIDED =
            "Notification description not provided; unable to proceed.";

        private const string EX_MSG_EVENT_EXCEEDS_MAX_LENGTH =
            "Provided notification event exceeds the maximum allowed length [{0}]; unable to proceed.";

        private const string EX_MSG_EVENT_NOT_PROVIDED =
            "Notification event not provided; unable to proceed.";

        public void Validate()
        {
            if (String.IsNullOrEmpty(Description))
                throw new InvalidOperationException(EX_MSG_DESCRIPTION_NOT_PROVIDED);

            if (Description.Length > DESCRIPTION_MAX_LENGTH)
                throw new InvalidOperationException(String.Format(EX_MSG_DESCRIPTION_EXCEEDS_MAX_LENGTH, DESCRIPTION_MAX_LENGTH));

            if (String.IsNullOrEmpty(Event))
                throw new InvalidOperationException(EX_MSG_EVENT_NOT_PROVIDED);

            if (Event.Length > EVENT_MAX_LENGTH)
                throw new InvalidOperationException(String.Format(EX_MSG_EVENT_EXCEEDS_MAX_LENGTH, EVENT_MAX_LENGTH));
        }

        public string Event { get; set; }
        public string Description { get; set; }

        public ProwlNotificationPriority Priority { get; set; }
    }
}
