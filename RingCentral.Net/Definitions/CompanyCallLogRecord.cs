namespace RingCentral
{
    public class CompanyCallLogRecord
    {
        /// <summary>
        /// Internal identifier of a cal log record
        /// </summary>
        public string id;

        /// <summary>
        /// Canonical URI of a call log record
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a call session
        /// </summary>
        public string sessionId;

        /// <summary>
        /// Caller information
        /// </summary>
        public CallLogCallerInfo from;

        /// <summary>
        /// Callee information
        /// </summary>
        public CallLogCallerInfo to;

        /// <summary>
        /// Call type
        /// Enum: Voice, Fax
        /// </summary>
        public string type;

        /// <summary>
        /// Call direction
        /// Enum: Inbound, Outbound
        /// </summary>
        public string direction;

        /// <summary>
        /// Indicates whether the record is deleted. Returned for deleted records, for ISync requests
        /// </summary>
        public bool? deleted;

        /// <summary>
        /// Action description of the call operation
        /// Enum: Unknown, Phone Login, Calling Card, VoIP Call, Phone Call, Paging, Hunting, Call Park, Monitoring, Text Relay, External Application, Park Location, CallOut-CallMe, Conference Call, Move, RC Meetings, Accept Call, FindMe, FollowMe, RingMe, Transfer, Call Return, Ring Directly, RingOut Web, RingOut PC, RingOut Mobile, Emergency, E911 Update, Support, Incoming Fax, Outgoing Fax
        /// </summary>
        public string action;

        /// <summary>
        /// Status description of the call operation
        /// Enum: Unknown, Accepted, Call connected, In Progress, Voicemail, Reply, Missed, Busy, Rejected, No Answer, Hang Up, Blocked, Suspended account, Call Failed, Call Failure, Internal Error, IP Phone Offline, No Calling Credit, Restricted Number, Wrong Number, Answered Not Accepted, Stopped, International Disabled, International Restricted, Abandoned, Declined, Received, Fax on Demand, Partial Receive, Receive Error, Fax Receipt Error, Sent, Fax Partially Sent, Send Error, Fax Not Sent, Fax Poor Line
        /// </summary>
        public string result;

        /// <summary>
        /// Enum: Accepted, Connected, line Busy, Not Answered, No Answer, Hang Up, Stopped, Internal Error, No Credit, Restricted Number, Wrong Number, International Disabled, International Restricted, Bad Number, Info 411 Restricted, Customer 611 Restricted, No Digital Line, Failed Try Again, Max Call Limit, Too Many Calls, Calls Not Accepted, Number Not Allowed, Number Blocked, Number Disabled, Resource Error, Call Loop, Fax Not Received, Fax Partially Sent, Fax Not Sent, Fax Poor Line, Fax Prepare Error, Fax Save Error, Fax Send Error
        /// </summary>
        public string reason;

        /// <summary>
        /// The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        public string startTime;

        /// <summary>
        /// Call duration in seconds
        /// </summary>
        public long? duration;

        /// <summary>
        /// Call recording data. Returned if a call is recorded
        /// </summary>
        public CallLogRecordingInfo recording;
    }
}