// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Sms.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LinkMobilityProviderConfig
    {
        /// <summary>
        /// Initializes a new instance of the LinkMobilityProviderConfig class.
        /// </summary>
        public LinkMobilityProviderConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinkMobilityProviderConfig class.
        /// </summary>
        public LinkMobilityProviderConfig(string apiKey, string sender, ServiceWindow smsServiceWindow = default(ServiceWindow))
        {
            ApiKey = apiKey;
            Sender = sender;
            SmsServiceWindow = smsServiceWindow;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiKey")]
        public string ApiKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sender")]
        public string Sender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "smsServiceWindow")]
        public ServiceWindow SmsServiceWindow { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ApiKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApiKey");
            }
            if (Sender == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sender");
            }
            if (SmsServiceWindow != null)
            {
                SmsServiceWindow.Validate();
            }
        }
    }
}
