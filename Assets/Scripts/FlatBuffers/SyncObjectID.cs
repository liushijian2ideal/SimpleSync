// automatically generated by the FlatBuffers compiler, do not modify

namespace SimpleSync.Serializer
{

using System;
using FlatBuffers;

public struct SyncIDList : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static SyncIDList GetRootAsSyncIDList(ByteBuffer _bb) { return GetRootAsSyncIDList(_bb, new SyncIDList()); }
  public static SyncIDList GetRootAsSyncIDList(ByteBuffer _bb, SyncIDList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public SyncIDList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ushort Length { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
  public SyncObjectID? List(int j) { int o = __p.__offset(6); return o != 0 ? (SyncObjectID?)(new SyncObjectID()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ListLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<SyncIDList> CreateSyncIDList(FlatBufferBuilder builder,
      ushort length = 0,
      VectorOffset listOffset = default(VectorOffset)) {
    builder.StartObject(2);
    SyncIDList.AddList(builder, listOffset);
    SyncIDList.AddLength(builder, length);
    return SyncIDList.EndSyncIDList(builder);
  }

  public static void StartSyncIDList(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddLength(FlatBufferBuilder builder, ushort length) { builder.AddUshort(0, length, 0); }
  public static void AddList(FlatBufferBuilder builder, VectorOffset listOffset) { builder.AddOffset(1, listOffset.Value, 0); }
  public static VectorOffset CreateListVector(FlatBufferBuilder builder, Offset<SyncObjectID>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SyncIDList> EndSyncIDList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<SyncIDList>(o);
  }
  public static void FinishSyncIDListBuffer(FlatBufferBuilder builder, Offset<SyncIDList> offset) { builder.Finish(offset.Value); }
};

public struct SyncObjectID : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static SyncObjectID GetRootAsSyncObjectID(ByteBuffer _bb) { return GetRootAsSyncObjectID(_bb, new SyncObjectID()); }
  public static SyncObjectID GetRootAsSyncObjectID(ByteBuffer _bb, SyncObjectID obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public SyncObjectID __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ushort Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }

  public static Offset<SyncObjectID> CreateSyncObjectID(FlatBufferBuilder builder,
      ushort id = 0,
      StringOffset nameOffset = default(StringOffset)) {
    builder.StartObject(2);
    SyncObjectID.AddName(builder, nameOffset);
    SyncObjectID.AddId(builder, id);
    return SyncObjectID.EndSyncObjectID(builder);
  }

  public static void StartSyncObjectID(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, ushort id) { builder.AddUshort(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static Offset<SyncObjectID> EndSyncObjectID(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<SyncObjectID>(o);
  }
};


}
