// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/tasks/v2/task.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Tasks.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/tasks/v2/task.proto</summary>
  public static partial class TaskReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/tasks/v2/task.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaskReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBnb29nbGUvY2xvdWQvdGFza3MvdjIvdGFzay5wcm90bxIVZ29vZ2xlLmNs",
            "b3VkLnRhc2tzLnYyGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGiJnb29n",
            "bGUvY2xvdWQvdGFza3MvdjIvdGFyZ2V0LnByb3RvGh5nb29nbGUvcHJvdG9i",
            "dWYvZHVyYXRpb24ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAu",
            "cHJvdG8aF2dvb2dsZS9ycGMvc3RhdHVzLnByb3RvGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvIrQFCgRUYXNrEgwKBG5hbWUYASABKAkSTgoXYXBw",
            "X2VuZ2luZV9odHRwX3JlcXVlc3QYAiABKAsyKy5nb29nbGUuY2xvdWQudGFz",
            "a3MudjIuQXBwRW5naW5lSHR0cFJlcXVlc3RIABI6CgxodHRwX3JlcXVlc3QY",
            "AyABKAsyIi5nb29nbGUuY2xvdWQudGFza3MudjIuSHR0cFJlcXVlc3RIABIx",
            "Cg1zY2hlZHVsZV90aW1lGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVz",
            "dGFtcBIvCgtjcmVhdGVfdGltZRgFIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5U",
            "aW1lc3RhbXASNAoRZGlzcGF0Y2hfZGVhZGxpbmUYBiABKAsyGS5nb29nbGUu",
            "cHJvdG9idWYuRHVyYXRpb24SFgoOZGlzcGF0Y2hfY291bnQYByABKAUSFgoO",
            "cmVzcG9uc2VfY291bnQYCCABKAUSNQoNZmlyc3RfYXR0ZW1wdBgJIAEoCzIe",
            "Lmdvb2dsZS5jbG91ZC50YXNrcy52Mi5BdHRlbXB0EjQKDGxhc3RfYXR0ZW1w",
            "dBgKIAEoCzIeLmdvb2dsZS5jbG91ZC50YXNrcy52Mi5BdHRlbXB0Ei4KBHZp",
            "ZXcYCyABKA4yIC5nb29nbGUuY2xvdWQudGFza3MudjIuVGFzay5WaWV3IjEK",
            "BFZpZXcSFAoQVklFV19VTlNQRUNJRklFRBAAEgkKBUJBU0lDEAESCAoERlVM",
            "TBACOmjqQWUKHmNsb3VkdGFza3MuZ29vZ2xlYXBpcy5jb20vVGFzaxJDcHJv",
            "amVjdHMve3Byb2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259L3F1ZXVlcy97",
            "cXVldWV9L3Rhc2tzL3t0YXNrfUIOCgxtZXNzYWdlX3R5cGUizwEKB0F0dGVt",
            "cHQSMQoNc2NoZWR1bGVfdGltZRgBIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5U",
            "aW1lc3RhbXASMQoNZGlzcGF0Y2hfdGltZRgCIAEoCzIaLmdvb2dsZS5wcm90",
            "b2J1Zi5UaW1lc3RhbXASMQoNcmVzcG9uc2VfdGltZRgDIAEoCzIaLmdvb2ds",
            "ZS5wcm90b2J1Zi5UaW1lc3RhbXASKwoPcmVzcG9uc2Vfc3RhdHVzGAQgASgL",
            "MhIuZ29vZ2xlLnJwYy5TdGF0dXNCZAoZY29tLmdvb2dsZS5jbG91ZC50YXNr",
            "cy52MkIJVGFza1Byb3RvUAFaOmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvY2xvdWQvdGFza3MvdjI7dGFza3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Tasks.V2.TargetReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Tasks.V2.Task), global::Google.Cloud.Tasks.V2.Task.Parser, new[]{ "Name", "AppEngineHttpRequest", "HttpRequest", "ScheduleTime", "CreateTime", "DispatchDeadline", "DispatchCount", "ResponseCount", "FirstAttempt", "LastAttempt", "View" }, new[]{ "MessageType" }, new[]{ typeof(global::Google.Cloud.Tasks.V2.Task.Types.View) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Tasks.V2.Attempt), global::Google.Cloud.Tasks.V2.Attempt.Parser, new[]{ "ScheduleTime", "DispatchTime", "ResponseTime", "ResponseStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A unit of scheduled work.
  /// </summary>
  public sealed partial class Task : pb::IMessage<Task> {
    private static readonly pb::MessageParser<Task> _parser = new pb::MessageParser<Task>(() => new Task());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Task> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Tasks.V2.TaskReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Task() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Task(Task other) : this() {
      name_ = other.name_;
      scheduleTime_ = other.scheduleTime_ != null ? other.scheduleTime_.Clone() : null;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      dispatchDeadline_ = other.dispatchDeadline_ != null ? other.dispatchDeadline_.Clone() : null;
      dispatchCount_ = other.dispatchCount_;
      responseCount_ = other.responseCount_;
      firstAttempt_ = other.firstAttempt_ != null ? other.firstAttempt_.Clone() : null;
      lastAttempt_ = other.lastAttempt_ != null ? other.lastAttempt_.Clone() : null;
      view_ = other.view_;
      switch (other.MessageTypeCase) {
        case MessageTypeOneofCase.AppEngineHttpRequest:
          AppEngineHttpRequest = other.AppEngineHttpRequest.Clone();
          break;
        case MessageTypeOneofCase.HttpRequest:
          HttpRequest = other.HttpRequest.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Task Clone() {
      return new Task(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Optionally caller-specified in [CreateTask][google.cloud.tasks.v2.CloudTasks.CreateTask].
    ///
    /// The task name.
    ///
    /// The task name must have the following format:
    /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
    ///
    /// * `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]),
    ///    hyphens (-), colons (:), or periods (.).
    ///    For more information, see
    ///    [Identifying
    ///    projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects)
    /// * `LOCATION_ID` is the canonical ID for the task's location.
    ///    The list of available locations can be obtained by calling
    ///    [ListLocations][google.cloud.location.Locations.ListLocations].
    ///    For more information, see https://cloud.google.com/about/locations/.
    /// * `QUEUE_ID` can contain letters ([A-Za-z]), numbers ([0-9]), or
    ///   hyphens (-). The maximum length is 100 characters.
    /// * `TASK_ID` can contain only letters ([A-Za-z]), numbers ([0-9]),
    ///   hyphens (-), or underscores (_). The maximum length is 500 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "app_engine_http_request" field.</summary>
    public const int AppEngineHttpRequestFieldNumber = 2;
    /// <summary>
    /// HTTP request that is sent to the App Engine app handler.
    ///
    /// An App Engine task is a task that has [AppEngineHttpRequest][google.cloud.tasks.v2.AppEngineHttpRequest] set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2.AppEngineHttpRequest AppEngineHttpRequest {
      get { return messageTypeCase_ == MessageTypeOneofCase.AppEngineHttpRequest ? (global::Google.Cloud.Tasks.V2.AppEngineHttpRequest) messageType_ : null; }
      set {
        messageType_ = value;
        messageTypeCase_ = value == null ? MessageTypeOneofCase.None : MessageTypeOneofCase.AppEngineHttpRequest;
      }
    }

    /// <summary>Field number for the "http_request" field.</summary>
    public const int HttpRequestFieldNumber = 3;
    /// <summary>
    /// HTTP request that is sent to the worker.
    ///
    /// An HTTP task is a task that has [HttpRequest][google.cloud.tasks.v2.HttpRequest] set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2.HttpRequest HttpRequest {
      get { return messageTypeCase_ == MessageTypeOneofCase.HttpRequest ? (global::Google.Cloud.Tasks.V2.HttpRequest) messageType_ : null; }
      set {
        messageType_ = value;
        messageTypeCase_ = value == null ? MessageTypeOneofCase.None : MessageTypeOneofCase.HttpRequest;
      }
    }

    /// <summary>Field number for the "schedule_time" field.</summary>
    public const int ScheduleTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp scheduleTime_;
    /// <summary>
    /// The time when the task is scheduled to be attempted or retried.
    ///
    /// `schedule_time` will be truncated to the nearest microsecond.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ScheduleTime {
      get { return scheduleTime_; }
      set {
        scheduleTime_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time that the task was created.
    ///
    /// `create_time` will be truncated to the nearest second.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "dispatch_deadline" field.</summary>
    public const int DispatchDeadlineFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Duration dispatchDeadline_;
    /// <summary>
    /// The deadline for requests sent to the worker. If the worker does not
    /// respond by this deadline then the request is cancelled and the attempt
    /// is marked as a `DEADLINE_EXCEEDED` failure. Cloud Tasks will retry the
    /// task according to the [RetryConfig][google.cloud.tasks.v2.RetryConfig].
    ///
    /// Note that when the request is cancelled, Cloud Tasks will stop listing for
    /// the response, but whether the worker stops processing depends on the
    /// worker. For example, if the worker is stuck, it may not react to cancelled
    /// requests.
    ///
    /// The default and maximum values depend on the type of request:
    ///
    /// * For [HTTP tasks][google.cloud.tasks.v2.HttpRequest], the default is 10 minutes. The deadline
    ///   must be in the interval [15 seconds, 30 minutes].
    ///
    /// * For [App Engine tasks][google.cloud.tasks.v2.AppEngineHttpRequest], 0 indicates that the
    ///   request has the default deadline. The default deadline depends on the
    ///   [scaling
    ///   type](https://cloud.google.com/appengine/docs/standard/go/how-instances-are-managed#instance_scaling)
    ///   of the service: 10 minutes for standard apps with automatic scaling, 24
    ///   hours for standard apps with manual and basic scaling, and 60 minutes for
    ///   flex apps. If the request deadline is set, it must be in the interval [15
    ///   seconds, 24 hours 15 seconds]. Regardless of the task's
    ///   `dispatch_deadline`, the app handler will not run for longer than than
    ///   the service's timeout. We recommend setting the `dispatch_deadline` to
    ///   at most a few seconds more than the app handler's timeout. For more
    ///   information see
    ///   [Timeouts](https://cloud.google.com/tasks/docs/creating-appengine-handlers#timeouts).
    ///
    /// `dispatch_deadline` will be truncated to the nearest millisecond. The
    /// deadline is an approximate deadline.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration DispatchDeadline {
      get { return dispatchDeadline_; }
      set {
        dispatchDeadline_ = value;
      }
    }

    /// <summary>Field number for the "dispatch_count" field.</summary>
    public const int DispatchCountFieldNumber = 7;
    private int dispatchCount_;
    /// <summary>
    /// Output only. The number of attempts dispatched.
    ///
    /// This count includes attempts which have been dispatched but haven't
    /// received a response.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DispatchCount {
      get { return dispatchCount_; }
      set {
        dispatchCount_ = value;
      }
    }

    /// <summary>Field number for the "response_count" field.</summary>
    public const int ResponseCountFieldNumber = 8;
    private int responseCount_;
    /// <summary>
    /// Output only. The number of attempts which have received a response.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ResponseCount {
      get { return responseCount_; }
      set {
        responseCount_ = value;
      }
    }

    /// <summary>Field number for the "first_attempt" field.</summary>
    public const int FirstAttemptFieldNumber = 9;
    private global::Google.Cloud.Tasks.V2.Attempt firstAttempt_;
    /// <summary>
    /// Output only. The status of the task's first attempt.
    ///
    /// Only [dispatch_time][google.cloud.tasks.v2.Attempt.dispatch_time] will be set.
    /// The other [Attempt][google.cloud.tasks.v2.Attempt] information is not retained by Cloud Tasks.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2.Attempt FirstAttempt {
      get { return firstAttempt_; }
      set {
        firstAttempt_ = value;
      }
    }

    /// <summary>Field number for the "last_attempt" field.</summary>
    public const int LastAttemptFieldNumber = 10;
    private global::Google.Cloud.Tasks.V2.Attempt lastAttempt_;
    /// <summary>
    /// Output only. The status of the task's last attempt.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2.Attempt LastAttempt {
      get { return lastAttempt_; }
      set {
        lastAttempt_ = value;
      }
    }

    /// <summary>Field number for the "view" field.</summary>
    public const int ViewFieldNumber = 11;
    private global::Google.Cloud.Tasks.V2.Task.Types.View view_ = global::Google.Cloud.Tasks.V2.Task.Types.View.Unspecified;
    /// <summary>
    /// Output only. The view specifies which subset of the [Task][google.cloud.tasks.v2.Task] has
    /// been returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2.Task.Types.View View {
      get { return view_; }
      set {
        view_ = value;
      }
    }

    private object messageType_;
    /// <summary>Enum of possible cases for the "message_type" oneof.</summary>
    public enum MessageTypeOneofCase {
      None = 0,
      AppEngineHttpRequest = 2,
      HttpRequest = 3,
    }
    private MessageTypeOneofCase messageTypeCase_ = MessageTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageTypeOneofCase MessageTypeCase {
      get { return messageTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMessageType() {
      messageTypeCase_ = MessageTypeOneofCase.None;
      messageType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Task);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Task other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(AppEngineHttpRequest, other.AppEngineHttpRequest)) return false;
      if (!object.Equals(HttpRequest, other.HttpRequest)) return false;
      if (!object.Equals(ScheduleTime, other.ScheduleTime)) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(DispatchDeadline, other.DispatchDeadline)) return false;
      if (DispatchCount != other.DispatchCount) return false;
      if (ResponseCount != other.ResponseCount) return false;
      if (!object.Equals(FirstAttempt, other.FirstAttempt)) return false;
      if (!object.Equals(LastAttempt, other.LastAttempt)) return false;
      if (View != other.View) return false;
      if (MessageTypeCase != other.MessageTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (messageTypeCase_ == MessageTypeOneofCase.AppEngineHttpRequest) hash ^= AppEngineHttpRequest.GetHashCode();
      if (messageTypeCase_ == MessageTypeOneofCase.HttpRequest) hash ^= HttpRequest.GetHashCode();
      if (scheduleTime_ != null) hash ^= ScheduleTime.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (dispatchDeadline_ != null) hash ^= DispatchDeadline.GetHashCode();
      if (DispatchCount != 0) hash ^= DispatchCount.GetHashCode();
      if (ResponseCount != 0) hash ^= ResponseCount.GetHashCode();
      if (firstAttempt_ != null) hash ^= FirstAttempt.GetHashCode();
      if (lastAttempt_ != null) hash ^= LastAttempt.GetHashCode();
      if (View != global::Google.Cloud.Tasks.V2.Task.Types.View.Unspecified) hash ^= View.GetHashCode();
      hash ^= (int) messageTypeCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (messageTypeCase_ == MessageTypeOneofCase.AppEngineHttpRequest) {
        output.WriteRawTag(18);
        output.WriteMessage(AppEngineHttpRequest);
      }
      if (messageTypeCase_ == MessageTypeOneofCase.HttpRequest) {
        output.WriteRawTag(26);
        output.WriteMessage(HttpRequest);
      }
      if (scheduleTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ScheduleTime);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (dispatchDeadline_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(DispatchDeadline);
      }
      if (DispatchCount != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(DispatchCount);
      }
      if (ResponseCount != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(ResponseCount);
      }
      if (firstAttempt_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(FirstAttempt);
      }
      if (lastAttempt_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(LastAttempt);
      }
      if (View != global::Google.Cloud.Tasks.V2.Task.Types.View.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) View);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (messageTypeCase_ == MessageTypeOneofCase.AppEngineHttpRequest) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppEngineHttpRequest);
      }
      if (messageTypeCase_ == MessageTypeOneofCase.HttpRequest) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HttpRequest);
      }
      if (scheduleTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ScheduleTime);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (dispatchDeadline_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DispatchDeadline);
      }
      if (DispatchCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DispatchCount);
      }
      if (ResponseCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ResponseCount);
      }
      if (firstAttempt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FirstAttempt);
      }
      if (lastAttempt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastAttempt);
      }
      if (View != global::Google.Cloud.Tasks.V2.Task.Types.View.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) View);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Task other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.scheduleTime_ != null) {
        if (scheduleTime_ == null) {
          ScheduleTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ScheduleTime.MergeFrom(other.ScheduleTime);
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.dispatchDeadline_ != null) {
        if (dispatchDeadline_ == null) {
          DispatchDeadline = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        DispatchDeadline.MergeFrom(other.DispatchDeadline);
      }
      if (other.DispatchCount != 0) {
        DispatchCount = other.DispatchCount;
      }
      if (other.ResponseCount != 0) {
        ResponseCount = other.ResponseCount;
      }
      if (other.firstAttempt_ != null) {
        if (firstAttempt_ == null) {
          FirstAttempt = new global::Google.Cloud.Tasks.V2.Attempt();
        }
        FirstAttempt.MergeFrom(other.FirstAttempt);
      }
      if (other.lastAttempt_ != null) {
        if (lastAttempt_ == null) {
          LastAttempt = new global::Google.Cloud.Tasks.V2.Attempt();
        }
        LastAttempt.MergeFrom(other.LastAttempt);
      }
      if (other.View != global::Google.Cloud.Tasks.V2.Task.Types.View.Unspecified) {
        View = other.View;
      }
      switch (other.MessageTypeCase) {
        case MessageTypeOneofCase.AppEngineHttpRequest:
          if (AppEngineHttpRequest == null) {
            AppEngineHttpRequest = new global::Google.Cloud.Tasks.V2.AppEngineHttpRequest();
          }
          AppEngineHttpRequest.MergeFrom(other.AppEngineHttpRequest);
          break;
        case MessageTypeOneofCase.HttpRequest:
          if (HttpRequest == null) {
            HttpRequest = new global::Google.Cloud.Tasks.V2.HttpRequest();
          }
          HttpRequest.MergeFrom(other.HttpRequest);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            global::Google.Cloud.Tasks.V2.AppEngineHttpRequest subBuilder = new global::Google.Cloud.Tasks.V2.AppEngineHttpRequest();
            if (messageTypeCase_ == MessageTypeOneofCase.AppEngineHttpRequest) {
              subBuilder.MergeFrom(AppEngineHttpRequest);
            }
            input.ReadMessage(subBuilder);
            AppEngineHttpRequest = subBuilder;
            break;
          }
          case 26: {
            global::Google.Cloud.Tasks.V2.HttpRequest subBuilder = new global::Google.Cloud.Tasks.V2.HttpRequest();
            if (messageTypeCase_ == MessageTypeOneofCase.HttpRequest) {
              subBuilder.MergeFrom(HttpRequest);
            }
            input.ReadMessage(subBuilder);
            HttpRequest = subBuilder;
            break;
          }
          case 34: {
            if (scheduleTime_ == null) {
              ScheduleTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ScheduleTime);
            break;
          }
          case 42: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 50: {
            if (dispatchDeadline_ == null) {
              DispatchDeadline = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(DispatchDeadline);
            break;
          }
          case 56: {
            DispatchCount = input.ReadInt32();
            break;
          }
          case 64: {
            ResponseCount = input.ReadInt32();
            break;
          }
          case 74: {
            if (firstAttempt_ == null) {
              FirstAttempt = new global::Google.Cloud.Tasks.V2.Attempt();
            }
            input.ReadMessage(FirstAttempt);
            break;
          }
          case 82: {
            if (lastAttempt_ == null) {
              LastAttempt = new global::Google.Cloud.Tasks.V2.Attempt();
            }
            input.ReadMessage(LastAttempt);
            break;
          }
          case 88: {
            View = (global::Google.Cloud.Tasks.V2.Task.Types.View) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Task message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The view specifies a subset of [Task][google.cloud.tasks.v2.Task] data.
      ///
      /// When a task is returned in a response, not all
      /// information is retrieved by default because some data, such as
      /// payloads, might be desirable to return only when needed because
      /// of its large size or because of the sensitivity of data that it
      /// contains.
      /// </summary>
      public enum View {
        /// <summary>
        /// Unspecified. Defaults to BASIC.
        /// </summary>
        [pbr::OriginalName("VIEW_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The basic view omits fields which can be large or can contain
        /// sensitive data.
        ///
        /// This view does not include the
        /// [body in AppEngineHttpRequest][google.cloud.tasks.v2.AppEngineHttpRequest.body].
        /// Bodies are desirable to return only when needed, because they
        /// can be large and because of the sensitivity of the data that you
        /// choose to store in it.
        /// </summary>
        [pbr::OriginalName("BASIC")] Basic = 1,
        /// <summary>
        /// All information is returned.
        ///
        /// Authorization for [FULL][google.cloud.tasks.v2.Task.View.FULL] requires
        /// `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/)
        /// permission on the [Queue][google.cloud.tasks.v2.Queue] resource.
        /// </summary>
        [pbr::OriginalName("FULL")] Full = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// The status of a task attempt.
  /// </summary>
  public sealed partial class Attempt : pb::IMessage<Attempt> {
    private static readonly pb::MessageParser<Attempt> _parser = new pb::MessageParser<Attempt>(() => new Attempt());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Attempt> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Tasks.V2.TaskReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Attempt() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Attempt(Attempt other) : this() {
      scheduleTime_ = other.scheduleTime_ != null ? other.scheduleTime_.Clone() : null;
      dispatchTime_ = other.dispatchTime_ != null ? other.dispatchTime_.Clone() : null;
      responseTime_ = other.responseTime_ != null ? other.responseTime_.Clone() : null;
      responseStatus_ = other.responseStatus_ != null ? other.responseStatus_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Attempt Clone() {
      return new Attempt(this);
    }

    /// <summary>Field number for the "schedule_time" field.</summary>
    public const int ScheduleTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp scheduleTime_;
    /// <summary>
    /// Output only. The time that this attempt was scheduled.
    ///
    /// `schedule_time` will be truncated to the nearest microsecond.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ScheduleTime {
      get { return scheduleTime_; }
      set {
        scheduleTime_ = value;
      }
    }

    /// <summary>Field number for the "dispatch_time" field.</summary>
    public const int DispatchTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp dispatchTime_;
    /// <summary>
    /// Output only. The time that this attempt was dispatched.
    ///
    /// `dispatch_time` will be truncated to the nearest microsecond.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DispatchTime {
      get { return dispatchTime_; }
      set {
        dispatchTime_ = value;
      }
    }

    /// <summary>Field number for the "response_time" field.</summary>
    public const int ResponseTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp responseTime_;
    /// <summary>
    /// Output only. The time that this attempt response was received.
    ///
    /// `response_time` will be truncated to the nearest microsecond.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ResponseTime {
      get { return responseTime_; }
      set {
        responseTime_ = value;
      }
    }

    /// <summary>Field number for the "response_status" field.</summary>
    public const int ResponseStatusFieldNumber = 4;
    private global::Google.Rpc.Status responseStatus_;
    /// <summary>
    /// Output only. The response from the worker for this attempt.
    ///
    /// If `response_time` is unset, then the task has not been attempted or is
    /// currently running and the `response_status` field is meaningless.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Rpc.Status ResponseStatus {
      get { return responseStatus_; }
      set {
        responseStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Attempt);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Attempt other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ScheduleTime, other.ScheduleTime)) return false;
      if (!object.Equals(DispatchTime, other.DispatchTime)) return false;
      if (!object.Equals(ResponseTime, other.ResponseTime)) return false;
      if (!object.Equals(ResponseStatus, other.ResponseStatus)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (scheduleTime_ != null) hash ^= ScheduleTime.GetHashCode();
      if (dispatchTime_ != null) hash ^= DispatchTime.GetHashCode();
      if (responseTime_ != null) hash ^= ResponseTime.GetHashCode();
      if (responseStatus_ != null) hash ^= ResponseStatus.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (scheduleTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ScheduleTime);
      }
      if (dispatchTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DispatchTime);
      }
      if (responseTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ResponseTime);
      }
      if (responseStatus_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ResponseStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (scheduleTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ScheduleTime);
      }
      if (dispatchTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DispatchTime);
      }
      if (responseTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResponseTime);
      }
      if (responseStatus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResponseStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Attempt other) {
      if (other == null) {
        return;
      }
      if (other.scheduleTime_ != null) {
        if (scheduleTime_ == null) {
          ScheduleTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ScheduleTime.MergeFrom(other.ScheduleTime);
      }
      if (other.dispatchTime_ != null) {
        if (dispatchTime_ == null) {
          DispatchTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DispatchTime.MergeFrom(other.DispatchTime);
      }
      if (other.responseTime_ != null) {
        if (responseTime_ == null) {
          ResponseTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ResponseTime.MergeFrom(other.ResponseTime);
      }
      if (other.responseStatus_ != null) {
        if (responseStatus_ == null) {
          ResponseStatus = new global::Google.Rpc.Status();
        }
        ResponseStatus.MergeFrom(other.ResponseStatus);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (scheduleTime_ == null) {
              ScheduleTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ScheduleTime);
            break;
          }
          case 18: {
            if (dispatchTime_ == null) {
              DispatchTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DispatchTime);
            break;
          }
          case 26: {
            if (responseTime_ == null) {
              ResponseTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ResponseTime);
            break;
          }
          case 34: {
            if (responseStatus_ == null) {
              ResponseStatus = new global::Google.Rpc.Status();
            }
            input.ReadMessage(ResponseStatus);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code