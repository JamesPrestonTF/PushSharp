using PushSharp.Core;

namespace PushSharp.Firebase
{
    public class FcmServiceConnectionFactory : IServiceConnectionFactory<FcmNotification>
    {
        public FcmServiceConnectionFactory(FcmConfiguration configuration)
        {
            Configuration = configuration;
        }

        public FcmConfiguration Configuration { get; private set; }

        public IServiceConnection<FcmNotification> Create()
        {
            return new FcmServiceConnection(Configuration);
        }
    }
}
