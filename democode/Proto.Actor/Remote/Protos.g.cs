// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Protos.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto.Remote {

  /// <summary>Holder for reflection information generated from Protos.proto</summary>
  public static partial class ProtosReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtosReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxQcm90b3MucHJvdG8SBnJlbW90ZRoYUHJvdG8uQWN0b3IvcHJvdG9zLnBy",
            "b3RvImQKDE1lc3NhZ2VCYXRjaBISCgp0eXBlX25hbWVzGAEgAygJEhQKDHRh",
            "cmdldF9uYW1lcxgCIAMoCRIqCgllbnZlbG9wZXMYAyADKAsyFy5yZW1vdGUu",
            "TWVzc2FnZUVudmVsb3BlInsKD01lc3NhZ2VFbnZlbG9wZRIPCgd0eXBlX2lk",
            "GAEgASgFEhQKDG1lc3NhZ2VfZGF0YRgCIAEoDBIOCgZ0YXJnZXQYAyABKAUS",
            "GgoGc2VuZGVyGAQgASgLMgouYWN0b3IuUElEEhUKDXNlcmlhbGl6ZXJfaWQY",
            "BSABKAUiLQoPQWN0b3JQaWRSZXF1ZXN0EgwKBG5hbWUYASABKAkSDAoEa2lu",
            "ZBgCIAEoCSIrChBBY3RvclBpZFJlc3BvbnNlEhcKA3BpZBgBIAEoCzIKLmFj",
            "dG9yLlBJRCIGCgRVbml0IhAKDkNvbm5lY3RSZXF1ZXN0IjAKD0Nvbm5lY3RS",
            "ZXNwb25zZRIdChVkZWZhdWx0X3NlcmlhbGl6ZXJfaWQYASABKAUyfQoIUmVt",
            "b3RpbmcSPAoHQ29ubmVjdBIWLnJlbW90ZS5Db25uZWN0UmVxdWVzdBoXLnJl",
            "bW90ZS5Db25uZWN0UmVzcG9uc2UiABIzCgdSZWNlaXZlEhQucmVtb3RlLk1l",
            "c3NhZ2VCYXRjaBoMLnJlbW90ZS5Vbml0IgAoATABQg+qAgxQcm90by5SZW1v",
            "dGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Proto.ProtosReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Remote.MessageBatch), global::Proto.Remote.MessageBatch.Parser, new[]{ "TypeNames", "TargetNames", "Envelopes" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Remote.MessageEnvelope), global::Proto.Remote.MessageEnvelope.Parser, new[]{ "TypeId", "MessageData", "Target", "Sender", "SerializerId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Remote.ActorPidRequest), global::Proto.Remote.ActorPidRequest.Parser, new[]{ "Name", "Kind" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Remote.ActorPidResponse), global::Proto.Remote.ActorPidResponse.Parser, new[]{ "Pid" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Remote.Unit), global::Proto.Remote.Unit.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Remote.ConnectRequest), global::Proto.Remote.ConnectRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Remote.ConnectResponse), global::Proto.Remote.ConnectResponse.Parser, new[]{ "DefaultSerializerId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MessageBatch : pb::IMessage<MessageBatch> {
    private static readonly pb::MessageParser<MessageBatch> _parser = new pb::MessageParser<MessageBatch>(() => new MessageBatch());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessageBatch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Remote.ProtosReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageBatch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageBatch(MessageBatch other) : this() {
      typeNames_ = other.typeNames_.Clone();
      targetNames_ = other.targetNames_.Clone();
      envelopes_ = other.envelopes_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageBatch Clone() {
      return new MessageBatch(this);
    }

    /// <summary>Field number for the "type_names" field.</summary>
    public const int TypeNamesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_typeNames_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> typeNames_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> TypeNames {
      get { return typeNames_; }
    }

    /// <summary>Field number for the "target_names" field.</summary>
    public const int TargetNamesFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_targetNames_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> targetNames_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> TargetNames {
      get { return targetNames_; }
    }

    /// <summary>Field number for the "envelopes" field.</summary>
    public const int EnvelopesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Proto.Remote.MessageEnvelope> _repeated_envelopes_codec
        = pb::FieldCodec.ForMessage(26, global::Proto.Remote.MessageEnvelope.Parser);
    private readonly pbc::RepeatedField<global::Proto.Remote.MessageEnvelope> envelopes_ = new pbc::RepeatedField<global::Proto.Remote.MessageEnvelope>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Proto.Remote.MessageEnvelope> Envelopes {
      get { return envelopes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessageBatch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessageBatch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!typeNames_.Equals(other.typeNames_)) return false;
      if(!targetNames_.Equals(other.targetNames_)) return false;
      if(!envelopes_.Equals(other.envelopes_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= typeNames_.GetHashCode();
      hash ^= targetNames_.GetHashCode();
      hash ^= envelopes_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      typeNames_.WriteTo(output, _repeated_typeNames_codec);
      targetNames_.WriteTo(output, _repeated_targetNames_codec);
      envelopes_.WriteTo(output, _repeated_envelopes_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += typeNames_.CalculateSize(_repeated_typeNames_codec);
      size += targetNames_.CalculateSize(_repeated_targetNames_codec);
      size += envelopes_.CalculateSize(_repeated_envelopes_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessageBatch other) {
      if (other == null) {
        return;
      }
      typeNames_.Add(other.typeNames_);
      targetNames_.Add(other.targetNames_);
      envelopes_.Add(other.envelopes_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            typeNames_.AddEntriesFrom(input, _repeated_typeNames_codec);
            break;
          }
          case 18: {
            targetNames_.AddEntriesFrom(input, _repeated_targetNames_codec);
            break;
          }
          case 26: {
            envelopes_.AddEntriesFrom(input, _repeated_envelopes_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class MessageEnvelope : pb::IMessage<MessageEnvelope> {
    private static readonly pb::MessageParser<MessageEnvelope> _parser = new pb::MessageParser<MessageEnvelope>(() => new MessageEnvelope());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessageEnvelope> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Remote.ProtosReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageEnvelope() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageEnvelope(MessageEnvelope other) : this() {
      typeId_ = other.typeId_;
      messageData_ = other.messageData_;
      target_ = other.target_;
      Sender = other.sender_ != null ? other.Sender.Clone() : null;
      serializerId_ = other.serializerId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageEnvelope Clone() {
      return new MessageEnvelope(this);
    }

    /// <summary>Field number for the "type_id" field.</summary>
    public const int TypeIdFieldNumber = 1;
    private int typeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TypeId {
      get { return typeId_; }
      set {
        typeId_ = value;
      }
    }

    /// <summary>Field number for the "message_data" field.</summary>
    public const int MessageDataFieldNumber = 2;
    private pb::ByteString messageData_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString MessageData {
      get { return messageData_; }
      set {
        messageData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 3;
    private int target_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Target {
      get { return target_; }
      set {
        target_ = value;
      }
    }

    /// <summary>Field number for the "sender" field.</summary>
    public const int SenderFieldNumber = 4;
    private global::Proto.PID sender_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.PID Sender {
      get { return sender_; }
      set {
        sender_ = value;
      }
    }

    /// <summary>Field number for the "serializer_id" field.</summary>
    public const int SerializerIdFieldNumber = 5;
    private int serializerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SerializerId {
      get { return serializerId_; }
      set {
        serializerId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessageEnvelope);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessageEnvelope other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TypeId != other.TypeId) return false;
      if (MessageData != other.MessageData) return false;
      if (Target != other.Target) return false;
      if (!object.Equals(Sender, other.Sender)) return false;
      if (SerializerId != other.SerializerId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TypeId != 0) hash ^= TypeId.GetHashCode();
      if (MessageData.Length != 0) hash ^= MessageData.GetHashCode();
      if (Target != 0) hash ^= Target.GetHashCode();
      if (sender_ != null) hash ^= Sender.GetHashCode();
      if (SerializerId != 0) hash ^= SerializerId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (TypeId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(TypeId);
      }
      if (MessageData.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(MessageData);
      }
      if (Target != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Target);
      }
      if (sender_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Sender);
      }
      if (SerializerId != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(SerializerId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TypeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TypeId);
      }
      if (MessageData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(MessageData);
      }
      if (Target != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Target);
      }
      if (sender_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Sender);
      }
      if (SerializerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SerializerId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessageEnvelope other) {
      if (other == null) {
        return;
      }
      if (other.TypeId != 0) {
        TypeId = other.TypeId;
      }
      if (other.MessageData.Length != 0) {
        MessageData = other.MessageData;
      }
      if (other.Target != 0) {
        Target = other.Target;
      }
      if (other.sender_ != null) {
        if (sender_ == null) {
          sender_ = new global::Proto.PID();
        }
        Sender.MergeFrom(other.Sender);
      }
      if (other.SerializerId != 0) {
        SerializerId = other.SerializerId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            TypeId = input.ReadInt32();
            break;
          }
          case 18: {
            MessageData = input.ReadBytes();
            break;
          }
          case 24: {
            Target = input.ReadInt32();
            break;
          }
          case 34: {
            if (sender_ == null) {
              sender_ = new global::Proto.PID();
            }
            input.ReadMessage(sender_);
            break;
          }
          case 40: {
            SerializerId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ActorPidRequest : pb::IMessage<ActorPidRequest> {
    private static readonly pb::MessageParser<ActorPidRequest> _parser = new pb::MessageParser<ActorPidRequest>(() => new ActorPidRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ActorPidRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Remote.ProtosReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActorPidRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActorPidRequest(ActorPidRequest other) : this() {
      name_ = other.name_;
      kind_ = other.kind_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActorPidRequest Clone() {
      return new ActorPidRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "kind" field.</summary>
    public const int KindFieldNumber = 2;
    private string kind_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Kind {
      get { return kind_; }
      set {
        kind_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ActorPidRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ActorPidRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Kind != other.Kind) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Kind.Length != 0) hash ^= Kind.GetHashCode();
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
      if (Kind.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Kind);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Kind.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Kind);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ActorPidRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Kind.Length != 0) {
        Kind = other.Kind;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Kind = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ActorPidResponse : pb::IMessage<ActorPidResponse> {
    private static readonly pb::MessageParser<ActorPidResponse> _parser = new pb::MessageParser<ActorPidResponse>(() => new ActorPidResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ActorPidResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Remote.ProtosReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActorPidResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActorPidResponse(ActorPidResponse other) : this() {
      Pid = other.pid_ != null ? other.Pid.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActorPidResponse Clone() {
      return new ActorPidResponse(this);
    }

    /// <summary>Field number for the "pid" field.</summary>
    public const int PidFieldNumber = 1;
    private global::Proto.PID pid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.PID Pid {
      get { return pid_; }
      set {
        pid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ActorPidResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ActorPidResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pid, other.Pid)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (pid_ != null) hash ^= Pid.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (pid_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pid);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (pid_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pid);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ActorPidResponse other) {
      if (other == null) {
        return;
      }
      if (other.pid_ != null) {
        if (pid_ == null) {
          pid_ = new global::Proto.PID();
        }
        Pid.MergeFrom(other.Pid);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (pid_ == null) {
              pid_ = new global::Proto.PID();
            }
            input.ReadMessage(pid_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Unit : pb::IMessage<Unit> {
    private static readonly pb::MessageParser<Unit> _parser = new pb::MessageParser<Unit>(() => new Unit());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Unit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Remote.ProtosReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Unit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Unit(Unit other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Unit Clone() {
      return new Unit(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Unit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Unit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Unit other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class ConnectRequest : pb::IMessage<ConnectRequest> {
    private static readonly pb::MessageParser<ConnectRequest> _parser = new pb::MessageParser<ConnectRequest>(() => new ConnectRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConnectRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Remote.ProtosReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectRequest(ConnectRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectRequest Clone() {
      return new ConnectRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConnectRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConnectRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConnectRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class ConnectResponse : pb::IMessage<ConnectResponse> {
    private static readonly pb::MessageParser<ConnectResponse> _parser = new pb::MessageParser<ConnectResponse>(() => new ConnectResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConnectResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Remote.ProtosReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectResponse(ConnectResponse other) : this() {
      defaultSerializerId_ = other.defaultSerializerId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectResponse Clone() {
      return new ConnectResponse(this);
    }

    /// <summary>Field number for the "default_serializer_id" field.</summary>
    public const int DefaultSerializerIdFieldNumber = 1;
    private int defaultSerializerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DefaultSerializerId {
      get { return defaultSerializerId_; }
      set {
        defaultSerializerId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConnectResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConnectResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DefaultSerializerId != other.DefaultSerializerId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DefaultSerializerId != 0) hash ^= DefaultSerializerId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DefaultSerializerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(DefaultSerializerId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DefaultSerializerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DefaultSerializerId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConnectResponse other) {
      if (other == null) {
        return;
      }
      if (other.DefaultSerializerId != 0) {
        DefaultSerializerId = other.DefaultSerializerId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            DefaultSerializerId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
