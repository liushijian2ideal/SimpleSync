// automatically generated by the FlatBuffers compiler, do not modify

namespace SimpleSync.Serializer
{

using System;
using FlatBuffers;

public struct Vec3 : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Vec3 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
  public float Y { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }
  public float Z { get { return __p.bb.GetFloat(__p.bb_pos + 8); } }

  public static Offset<Vec3> CreateVec3(FlatBufferBuilder builder, float X, float Y, float Z) {
    builder.Prep(4, 12);
    builder.PutFloat(Z);
    builder.PutFloat(Y);
    builder.PutFloat(X);
    return new Offset<Vec3>(builder.Offset);
  }
};

public struct Vec4 : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Vec4 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
  public float Y { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }
  public float Z { get { return __p.bb.GetFloat(__p.bb_pos + 8); } }
  public float W { get { return __p.bb.GetFloat(__p.bb_pos + 12); } }

  public static Offset<Vec4> CreateVec4(FlatBufferBuilder builder, float X, float Y, float Z, float W) {
    builder.Prep(4, 16);
    builder.PutFloat(W);
    builder.PutFloat(Z);
    builder.PutFloat(Y);
    builder.PutFloat(X);
    return new Offset<Vec4>(builder.Offset);
  }
};

public struct SyncObject : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static SyncObject GetRootAsSyncObject(ByteBuffer _bb) { return GetRootAsSyncObject(_bb, new SyncObject()); }
  public static SyncObject GetRootAsSyncObject(ByteBuffer _bb, SyncObject obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public SyncObject __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ushort Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
  public Vec3? Pos { get { int o = __p.__offset(6); return o != 0 ? (Vec3?)(new Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public Vec4? Rot { get { int o = __p.__offset(8); return o != 0 ? (Vec4?)(new Vec4()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public Vec3? Scale { get { int o = __p.__offset(10); return o != 0 ? (Vec3?)(new Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartSyncObject(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, ushort id) { builder.AddUshort(0, id, 0); }
  public static void AddPos(FlatBufferBuilder builder, Offset<Vec3> posOffset) { builder.AddStruct(1, posOffset.Value, 0); }
  public static void AddRot(FlatBufferBuilder builder, Offset<Vec4> rotOffset) { builder.AddStruct(2, rotOffset.Value, 0); }
  public static void AddScale(FlatBufferBuilder builder, Offset<Vec3> scaleOffset) { builder.AddStruct(3, scaleOffset.Value, 0); }
  public static Offset<SyncObject> EndSyncObject(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<SyncObject>(o);
  }
};

public struct ObjectList : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static ObjectList GetRootAsObjectList(ByteBuffer _bb) { return GetRootAsObjectList(_bb, new ObjectList()); }
  public static ObjectList GetRootAsObjectList(ByteBuffer _bb, ObjectList obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public ObjectList __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SyncObject? List(int j) { int o = __p.__offset(4); return o != 0 ? (SyncObject?)(new SyncObject()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ushort Length { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }

  public static Offset<ObjectList> CreateObjectList(FlatBufferBuilder builder,
      VectorOffset listOffset = default(VectorOffset),
      ushort length = 0) {
    builder.StartObject(2);
    ObjectList.AddList(builder, listOffset);
    ObjectList.AddLength(builder, length);
    return ObjectList.EndObjectList(builder);
  }

  public static void StartObjectList(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddList(FlatBufferBuilder builder, VectorOffset listOffset) { builder.AddOffset(0, listOffset.Value, 0); }
  public static VectorOffset CreateListVector(FlatBufferBuilder builder, Offset<SyncObject>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLength(FlatBufferBuilder builder, ushort length) { builder.AddUshort(1, length, 0); }
  public static Offset<ObjectList> EndObjectList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ObjectList>(o);
  }
  public static void FinishObjectListBuffer(FlatBufferBuilder builder, Offset<ObjectList> offset) { builder.Finish(offset.Value); }
};


}