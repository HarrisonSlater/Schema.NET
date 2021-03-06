namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// &lt;p&gt;A delivery method is a standardized procedure for transferring the product or service to the destination of fulfillment chosen by the customer. Delivery methods are characterized by the means of transportation used, and by the organization or group that is the contracting party for the sending organization or person.&lt;/p&gt;
    /// &lt;p&gt;Commonly used values:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeDirectDownload&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeFreight&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeMail&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeOwnFleet&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModePickUp&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DHL&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#FederalExpress&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#UPS&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public enum DeliveryMethod
    {
        /// <summary>
        /// A DeliveryMethod in which an item is collected on site, e.g. in a store or at a box office.
        /// </summary>
        [EnumMember(Value = "http://schema.org/OnSitePickup")]
        OnSitePickup,

        /// <summary>
        /// A DeliveryMethod in which an item is delivered using a business owned delivery service (such as Domino's Pizza's fleet)
        /// </summary>
        [EnumMember(Value = "http://purl.org/goodrelations/v1#DeliveryModeOwnFleet")]
        DeliveryModeOwnFleet
    }
}
