using System.Runtime.Serialization;

namespace PushSharp.Firebase
{
    public enum FcmResponseStatus
    {
        [EnumMember(Value = "Ok")]
        Ok,

        [EnumMember(Value = "Error")]
        Error,

        [EnumMember(Value = "TopicsMessageRateExceeded")]
        TopicsMessageRateExceeded,

        [EnumMember(Value = "DeviceMessageRateExceeded")]
        DeviceMessageRateExceeded,

        [EnumMember(Value = "InvalidRegistration")]
        InvalidRegistrationToken,

        [EnumMember(Value = "NotRegistered")]
        UnregisteredDevice,

        [EnumMember(Value = "MessageTooBig")]
        MessageTooBig,

        [EnumMember(Value = "MissingRegistration")]
        MissingRegistrationToken,

        [EnumMember(Value = "Unavailable")]
        Unavailable,

        [EnumMember(Value = "MismatchSenderId")]
        MismatchedSender,

        [EnumMember(Value = "CanonicalRegistrationId")]
        CanonicalRegistrationId,

        [EnumMember(Value = "InvalidDataKey")]
        InvalidDataKey,

        [EnumMember(Value = "InvalidTtl")]
        InvalidTtl,

        [EnumMember(Value = "InternalServerError")]
        InternalServerError,

        [EnumMember(Value = "InvalidPackageName")]
        InvalidPackageName
    }
}
