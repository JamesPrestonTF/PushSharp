using System;
using System.Collections.Generic;

namespace PushSharp.Firebase
{
    public class FcmMulticastResultException : Exception
    {
        public FcmMulticastResultException() : base("One or more Registration Id's failed in the multicast notification")
        {
            Succeeded = new List<FcmNotification>();
            Failed = new Dictionary<FcmNotification, Exception>();
        }

        public List<FcmNotification> Succeeded { get; set; }

        public Dictionary<FcmNotification, Exception> Failed { get; set; }
    }
}
