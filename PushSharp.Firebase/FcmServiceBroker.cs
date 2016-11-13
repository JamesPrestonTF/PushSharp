using PushSharp.Core;

namespace PushSharp.Firebase
{
    public class FcmServiceBroker : ServiceBroker<FcmNotification>
    {
        public FcmServiceBroker(FcmConfiguration configuration) : base(new FcmServiceConnectionFactory(configuration))
        {
        }
    }
}
