// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/websecurityscanner/v1/scan_run_error_trace.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.WebSecurityScanner.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/websecurityscanner/v1/scan_run_error_trace.proto</summary>
  public static partial class ScanRunErrorTraceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/websecurityscanner/v1/scan_run_error_trace.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScanRunErrorTraceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvY2xvdWQvd2Vic2VjdXJpdHlzY2FubmVyL3YxL3NjYW5fcnVu",
            "X2Vycm9yX3RyYWNlLnByb3RvEiJnb29nbGUuY2xvdWQud2Vic2VjdXJpdHlz",
            "Y2FubmVyLnYxGjpnb29nbGUvY2xvdWQvd2Vic2VjdXJpdHlzY2FubmVyL3Yx",
            "L3NjYW5fY29uZmlnX2Vycm9yLnByb3RvIo0DChFTY2FuUnVuRXJyb3JUcmFj",
            "ZRJICgRjb2RlGAEgASgOMjouZ29vZ2xlLmNsb3VkLndlYnNlY3VyaXR5c2Nh",
            "bm5lci52MS5TY2FuUnVuRXJyb3JUcmFjZS5Db2RlEk4KEXNjYW5fY29uZmln",
            "X2Vycm9yGAIgASgLMjMuZ29vZ2xlLmNsb3VkLndlYnNlY3VyaXR5c2Nhbm5l",
            "ci52MS5TY2FuQ29uZmlnRXJyb3ISIwobbW9zdF9jb21tb25faHR0cF9lcnJv",
            "cl9jb2RlGAMgASgFIrgBCgRDb2RlEhQKEENPREVfVU5TUEVDSUZJRUQQABIS",
            "Cg5JTlRFUk5BTF9FUlJPUhABEhUKEVNDQU5fQ09ORklHX0lTU1VFEAISHwob",
            "QVVUSEVOVElDQVRJT05fQ09ORklHX0lTU1VFEAMSHAoYVElNRURfT1VUX1dI",
            "SUxFX1NDQU5OSU5HEAQSFgoSVE9PX01BTllfUkVESVJFQ1RTEAUSGAoUVE9P",
            "X01BTllfSFRUUF9FUlJPUlMQBkKKAgomY29tLmdvb2dsZS5jbG91ZC53ZWJz",
            "ZWN1cml0eXNjYW5uZXIudjFCFlNjYW5SdW5FcnJvclRyYWNlUHJvdG9QAVpU",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC93",
            "ZWJzZWN1cml0eXNjYW5uZXIvdjE7d2Vic2VjdXJpdHlzY2FubmVyqgIiR29v",
            "Z2xlLkNsb3VkLldlYlNlY3VyaXR5U2Nhbm5lci5WMcoCIkdvb2dsZVxDbG91",
            "ZFxXZWJTZWN1cml0eVNjYW5uZXJcVjHqAiVHb29nbGU6OkNsb3VkOjpXZWJT",
            "ZWN1cml0eVNjYW5uZXI6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.WebSecurityScanner.V1.ScanConfigErrorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace), global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Parser, new[]{ "Code", "ScanConfigError", "MostCommonHttpErrorCode" }, null, new[]{ typeof(global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Output only.
  /// Defines an error trace message for a ScanRun.
  /// </summary>
  public sealed partial class ScanRunErrorTrace : pb::IMessage<ScanRunErrorTrace>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScanRunErrorTrace> _parser = new pb::MessageParser<ScanRunErrorTrace>(() => new ScanRunErrorTrace());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ScanRunErrorTrace> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTraceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ScanRunErrorTrace() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ScanRunErrorTrace(ScanRunErrorTrace other) : this() {
      code_ = other.code_;
      scanConfigError_ = other.scanConfigError_ != null ? other.scanConfigError_.Clone() : null;
      mostCommonHttpErrorCode_ = other.mostCommonHttpErrorCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ScanRunErrorTrace Clone() {
      return new ScanRunErrorTrace(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code code_ = global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code.Unspecified;
    /// <summary>
    /// Output only. Indicates the error reason code.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "scan_config_error" field.</summary>
    public const int ScanConfigErrorFieldNumber = 2;
    private global::Google.Cloud.WebSecurityScanner.V1.ScanConfigError scanConfigError_;
    /// <summary>
    /// Output only. If the scan encounters SCAN_CONFIG_ISSUE error, this field has the error
    /// message encountered during scan configuration validation that is performed
    /// before each scan run.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.WebSecurityScanner.V1.ScanConfigError ScanConfigError {
      get { return scanConfigError_; }
      set {
        scanConfigError_ = value;
      }
    }

    /// <summary>Field number for the "most_common_http_error_code" field.</summary>
    public const int MostCommonHttpErrorCodeFieldNumber = 3;
    private int mostCommonHttpErrorCode_;
    /// <summary>
    /// Output only. If the scan encounters TOO_MANY_HTTP_ERRORS, this field indicates the most
    /// common HTTP error code, if such is available. For example, if this code is
    /// 404, the scan has encountered too many NOT_FOUND responses.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MostCommonHttpErrorCode {
      get { return mostCommonHttpErrorCode_; }
      set {
        mostCommonHttpErrorCode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ScanRunErrorTrace);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ScanRunErrorTrace other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (!object.Equals(ScanConfigError, other.ScanConfigError)) return false;
      if (MostCommonHttpErrorCode != other.MostCommonHttpErrorCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code.Unspecified) hash ^= Code.GetHashCode();
      if (scanConfigError_ != null) hash ^= ScanConfigError.GetHashCode();
      if (MostCommonHttpErrorCode != 0) hash ^= MostCommonHttpErrorCode.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Code != global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (scanConfigError_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ScanConfigError);
      }
      if (MostCommonHttpErrorCode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MostCommonHttpErrorCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Code != global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (scanConfigError_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ScanConfigError);
      }
      if (MostCommonHttpErrorCode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MostCommonHttpErrorCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code != global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      if (scanConfigError_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ScanConfigError);
      }
      if (MostCommonHttpErrorCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MostCommonHttpErrorCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ScanRunErrorTrace other) {
      if (other == null) {
        return;
      }
      if (other.Code != global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code.Unspecified) {
        Code = other.Code;
      }
      if (other.scanConfigError_ != null) {
        if (scanConfigError_ == null) {
          ScanConfigError = new global::Google.Cloud.WebSecurityScanner.V1.ScanConfigError();
        }
        ScanConfigError.MergeFrom(other.ScanConfigError);
      }
      if (other.MostCommonHttpErrorCode != 0) {
        MostCommonHttpErrorCode = other.MostCommonHttpErrorCode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Code = (global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code) input.ReadEnum();
            break;
          }
          case 18: {
            if (scanConfigError_ == null) {
              ScanConfigError = new global::Google.Cloud.WebSecurityScanner.V1.ScanConfigError();
            }
            input.ReadMessage(ScanConfigError);
            break;
          }
          case 24: {
            MostCommonHttpErrorCode = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Code = (global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace.Types.Code) input.ReadEnum();
            break;
          }
          case 18: {
            if (scanConfigError_ == null) {
              ScanConfigError = new global::Google.Cloud.WebSecurityScanner.V1.ScanConfigError();
            }
            input.ReadMessage(ScanConfigError);
            break;
          }
          case 24: {
            MostCommonHttpErrorCode = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ScanRunErrorTrace message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Output only.
      /// Defines an error reason code.
      /// Next id: 7
      /// </summary>
      public enum Code {
        /// <summary>
        /// Default value is never used.
        /// </summary>
        [pbr::OriginalName("CODE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Indicates that the scan run failed due to an internal server error.
        /// </summary>
        [pbr::OriginalName("INTERNAL_ERROR")] InternalError = 1,
        /// <summary>
        /// Indicates a scan configuration error, usually due to outdated ScanConfig
        /// settings, such as starting_urls or the DNS configuration.
        /// </summary>
        [pbr::OriginalName("SCAN_CONFIG_ISSUE")] ScanConfigIssue = 2,
        /// <summary>
        /// Indicates an authentication error, usually due to outdated ScanConfig
        /// authentication settings.
        /// </summary>
        [pbr::OriginalName("AUTHENTICATION_CONFIG_ISSUE")] AuthenticationConfigIssue = 3,
        /// <summary>
        /// Indicates a scan operation timeout, usually caused by a very large site.
        /// </summary>
        [pbr::OriginalName("TIMED_OUT_WHILE_SCANNING")] TimedOutWhileScanning = 4,
        /// <summary>
        /// Indicates that a scan encountered excessive redirects, either to
        /// authentication or some other page outside of the scan scope.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_REDIRECTS")] TooManyRedirects = 5,
        /// <summary>
        /// Indicates that a scan encountered numerous errors from the web site
        /// pages. When available, most_common_http_error_code field indicates the
        /// most common HTTP error code encountered during the scan.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_HTTP_ERRORS")] TooManyHttpErrors = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code