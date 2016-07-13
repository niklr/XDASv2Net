using XDASv2Net.Attributes;

namespace XDASv2Net.Model
{
    /// <summary>
    /// The XDASv2 taxonomy event.
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// Consider this event as appropriate for any situation wherein an account, as defined above, is to be created.
        /// </summary>
        [EventInformation("0.0.0.0")]
        CREATE_ACCOUNT,

        /// <summary>
        /// This event has the opposite semantic meaning of account creation. Use this event wherever such an account, as described above, is to be deleted.
        /// </summary>
        [EventInformation("0.0.0.1")]
        DELETE_ACCOUNT,

        /// <summary>
        /// Consider this event relevant for any situation where a particular record in an identifier database is disabled by an administrator or an automated security process such that it can no longer be used until it is re-enabled.
        /// </summary>
        [EventInformation("0.0.0.2")]
        DISABLE_ACCOUNT,

        /// <summary>
        /// This is the counterpart event to the disable account event defined above.
        /// </summary>
        [EventInformation("0.0.0.3")]
        ENABLE_ACCOUNT,

        /// <summary>
        /// Consider the Query account events whenever a request for the attribute information of a particular account is made.
        /// </summary>
        [EventInformation("0.0.0.4")]
        QUERY_ACCOUNT,

        /// <summary>
        /// Consider the Modify account events whenever a request to change attribute information of a particular account is made. 
        /// </summary>
        [EventInformation("0.0.0.5")]
        MODIFY_ACCOUNT,

        /// <summary>
        /// An account security token may be a password, or any other type of authentication materials associated with a user account. Here, a user account means any type of account by which a user, application, or system service may authenticate, and then act with the rights of that account.
        /// </summary>
        [EventInformation("0.0.0.6")]
        MODIFY_ACCOUNT_SECURITY_TOKEN,

        /// <summary>
        /// This event should be reported whenever a new session (as defined above) is created.
        /// </summary>
        [EventInformation("0.0.1.0")]
        CREATE_SESSION,

        /// <summary>
        /// This event should be reported whenever an existing session (as defined above) is terminated.
        /// </summary>
        [EventInformation("0.0.1.1")]
        TERMINATE_SESSION,

        /// <summary>
        /// This event should be reported whenever attribute information is modified on an existing session.
        /// </summary>
        [EventInformation("0.0.1.3")]
        MODIFY_SESSION,

        /// <summary>
        /// This event is reported whenever a security-relevant data item or resource element is created.
        /// </summary>
        [EventInformation("0.0.2.0")]
        CREATE_DATA_ITEM,

        /// <summary>
        /// This event is reported whenever a security-relevant data item or resource element is deleted.
        /// </summary>
        [EventInformation("0.0.2.1")]
        DELETE_DATA_ITEM,

        /// <summary>
        /// This event is reported whenever a security-relevant data item or resource element is modified – either the value, or an attribute of the data item.
        /// </summary>
        [EventInformation("0.0.2.3")]
        MODIFY_DATA_ITEM_ATTRIBUTE,

        /// <summary>
        /// This event is reported whenever a security-relevant data item or resource element is queried – either for value, or for an attribute of the data item.
        /// </summary>
        [EventInformation("0.0.2.2")]
        QUERY_DATA_ITEM_ATTRIBUTE,

        /// <summary>
        /// This event is reported when a service, operation or function is enabled.
        /// </summary>
        [EventInformation("0.0.3.5")]
        ENABLE_SERVICE,

        /// <summary>
        /// This event is reported when a service, operation or function is disabled.
        /// </summary>
        [EventInformation("0.0.3.4")]
        DISABLE_SERVICE,

        /// <summary>
        /// This event is reported when a security-relevant service is invoked.
        /// </summary>
        [EventInformation("0.0.4.0")]
        INVOKE_SERVICE,

        /// <summary>
        /// This event is reported when a service is terminated.
        /// </summary>
        [EventInformation("0.0.4.1")]
        TERMINATE_SERVICE,

        /// <summary>
        /// This event is reported when any attributes of a process context are modified – this event is somewhat specific to operating systems, but some use can be found in other domain-specific applications.
        /// </summary>
        [EventInformation("0.0.4.3")]
        MODIFY_PROCESS_CONTEXT,

        /// <summary>
        /// This event is reported when a new trust association is created.
        /// </summary>
        [EventInformation("0.0.1.2")]
        ASSOCIATE_TRUST,

        /// <summary>
        /// This event is reported when an existing trust association is destroyed.
        /// </summary>
        [EventInformation("0.0.1.4")]
        DEASSOCIATE_TRUST,

        /// <summary>
        /// This event is reported when a new peer association is created.
        /// </summary>
        [EventInformation("0.0.5.0")]
        CREATE_PEER_ASSOCIATION,

        /// <summary>
        /// This event is reported when an existing peer association is destroyed.
        /// </summary>
        [EventInformation("0.0.5.1")]
        TERMINATE_PEER_ASSOCIATION,

        /// <summary>
        /// This event is reported when rights are granted by an identity to a specific data item – when a trust relationship is established between an identity and a data item.
        /// </summary>
        [EventInformation("0.0.6.0")]
        CREATE_DATA_ITEM_ASSOCIATION,

        /// <summary>
        /// This event is reported when rights are revoked from an identity to a specific data item – when a trust relationship is revoked between an identity and a data item.
        /// </summary>
        [EventInformation("0.0.6.1")]
        TERMINATE_DATA_ITEM_ASSOCIATION,

        /// <summary>
        /// This event is reported when rights are modified on the previously established relationship between an identity and specific data item.
        /// </summary>
        [EventInformation("0.0.6.3")]
        MODIFY_DATA_ITEM_ASSOCIATION,

        /// <summary>
        /// Creates a new role, or an attempt is made to create a new role.
        /// </summary>
        [EventInformation("0.0.8.0")]
        CREATE_ROLE,

        /// <summary>
        /// An existing role is deleted, or an attempt is made to delete an existing role.
        /// </summary>
        [EventInformation("0.0.8.1")]
        DELETE_ROLE,

        /// <summary>
        /// Role attributes are modified, or an attempt is made to modify role attributes.
        /// </summary>
        [EventInformation("0.0.8.5")]
        MODIFY_ROLE,

        /// <summary>
        /// Role attributes are queried, or an attempt is made to query role attributes.
        /// </summary>
        [EventInformation("0.0.8.4")]
        QUERY_ROLE,

        /// <summary>
        /// This event is reported when a server, system, or mission-critical application starts up.
        /// </summary>
        [EventInformation("0.0.9.0")]
        START_SYSTEM,

        /// <summary>
        /// This event is reported when a server, system, or mission-critical application shuts down.
        /// </summary>
        [EventInformation("0.0.9.1")]
        SHUTDOWN_SYSTEM,

        /// <summary>
        /// This event is reported when a server, system, or mission critical application backs up a critical data store.
        /// </summary>
        [EventInformation("0.0.9.6")]
        BACKUP_DATA_STORE,

        /// <summary>
        /// This event is reported when a server, system, or mission critical application restores a critical data store.
        /// </summary>
        [EventInformation("0.0.9.7")]
        RECOVER_DATA_STORE,

        /// <summary>
        /// When a user authenticates a session, a new identity is associated with that session. This identity is then used to authorize requests for protected resources.
        /// </summary>
        [EventInformation("0.0.11.0")]
        AUTHENTICATE_SESSION,

        /// <summary>
        /// When a user clicks the “Logout” button on his or her web browser, the previously authenticated identity is removed from an existing authenticated session.
        /// </summary>
        [EventInformation("0.0.11.1")]
        UNAUTHENTICATE_SESSION,

        /// <summary>
        /// A resource access token was created by a service (or identity) provider to send to a service consumer. Access is limited by time frame, specifically requested resources, or other limiting criteria, in terms of a contract specified by previously agreed upon name/value pairs in the token. The act of creating and sending an access token is the start of a new pseudo-identity with limited and specific rights to protected resources. This pseudo-identity can be used as a correlation identifier between this and future authorization events. The actually identity of the system user behind the access token may or may not be hidden from the consumer.
        /// </summary>
        [EventInformation("0.0.11.4")]
        CREATE_ACCESS_TOKEN,

        /// <summary>
        /// Used for logging events to generate eDirectory operation IDs.
        /// </summary>
        [EventInformation("0.1.0.3.0.0")]
        EDIR_OPERATIONAL_ID
    }
}