// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FieldSceneExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FieldSceneExcel GetRootAsFieldSceneExcel(ByteBuffer _bb) { return GetRootAsFieldSceneExcel(_bb, new FieldSceneExcel()); }
  public static FieldSceneExcel GetRootAsFieldSceneExcel(ByteBuffer _bb, FieldSceneExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldSceneExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DateId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroupId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ArtLevelPath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetArtLevelPathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetArtLevelPathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetArtLevelPathArray() { return __p.__vector_as_array<byte>(10); }
  public string DesignLevelPath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDesignLevelPathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetDesignLevelPathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetDesignLevelPathArray() { return __p.__vector_as_array<byte>(12); }
  public long BGMId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ConditionalBGMQuestId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConditionalBGMQuestIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConditionalBGMQuestIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetConditionalBGMQuestIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetConditionalBGMQuestIdArray() { return __p.__vector_as_array<long>(16); }
  public long BeginConditionalBGMScenarioGroupId(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BeginConditionalBGMScenarioGroupIdLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBeginConditionalBGMScenarioGroupIdBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetBeginConditionalBGMScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetBeginConditionalBGMScenarioGroupIdArray() { return __p.__vector_as_array<long>(18); }
  public long EndConditionalBGMScenarioGroupId(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int EndConditionalBGMScenarioGroupIdLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetEndConditionalBGMScenarioGroupIdBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetEndConditionalBGMScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetEndConditionalBGMScenarioGroupIdArray() { return __p.__vector_as_array<long>(20); }
  public long ConditionalBGMId(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConditionalBGMIdLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConditionalBGMIdBytes() { return __p.__vector_as_span<long>(22, 8); }
#else
  public ArraySegment<byte>? GetConditionalBGMIdBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public long[] GetConditionalBGMIdArray() { return __p.__vector_as_array<long>(22); }

  public static Offset<SCHALE.Common.FlatData.FieldSceneExcel> CreateFieldSceneExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      long DateId = 0,
      long GroupId = 0,
      StringOffset ArtLevelPathOffset = default(StringOffset),
      StringOffset DesignLevelPathOffset = default(StringOffset),
      long BGMId = 0,
      VectorOffset ConditionalBGMQuestIdOffset = default(VectorOffset),
      VectorOffset BeginConditionalBGMScenarioGroupIdOffset = default(VectorOffset),
      VectorOffset EndConditionalBGMScenarioGroupIdOffset = default(VectorOffset),
      VectorOffset ConditionalBGMIdOffset = default(VectorOffset)) {
    builder.StartTable(10);
    FieldSceneExcel.AddBGMId(builder, BGMId);
    FieldSceneExcel.AddGroupId(builder, GroupId);
    FieldSceneExcel.AddDateId(builder, DateId);
    FieldSceneExcel.AddUniqueId(builder, UniqueId);
    FieldSceneExcel.AddConditionalBGMId(builder, ConditionalBGMIdOffset);
    FieldSceneExcel.AddEndConditionalBGMScenarioGroupId(builder, EndConditionalBGMScenarioGroupIdOffset);
    FieldSceneExcel.AddBeginConditionalBGMScenarioGroupId(builder, BeginConditionalBGMScenarioGroupIdOffset);
    FieldSceneExcel.AddConditionalBGMQuestId(builder, ConditionalBGMQuestIdOffset);
    FieldSceneExcel.AddDesignLevelPath(builder, DesignLevelPathOffset);
    FieldSceneExcel.AddArtLevelPath(builder, ArtLevelPathOffset);
    return FieldSceneExcel.EndFieldSceneExcel(builder);
  }

  public static void StartFieldSceneExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddDateId(FlatBufferBuilder builder, long dateId) { builder.AddLong(1, dateId, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long groupId) { builder.AddLong(2, groupId, 0); }
  public static void AddArtLevelPath(FlatBufferBuilder builder, StringOffset artLevelPathOffset) { builder.AddOffset(3, artLevelPathOffset.Value, 0); }
  public static void AddDesignLevelPath(FlatBufferBuilder builder, StringOffset designLevelPathOffset) { builder.AddOffset(4, designLevelPathOffset.Value, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long bGMId) { builder.AddLong(5, bGMId, 0); }
  public static void AddConditionalBGMQuestId(FlatBufferBuilder builder, VectorOffset conditionalBGMQuestIdOffset) { builder.AddOffset(6, conditionalBGMQuestIdOffset.Value, 0); }
  public static VectorOffset CreateConditionalBGMQuestIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionalBGMQuestIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionalBGMQuestIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionalBGMQuestIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionalBGMQuestIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddBeginConditionalBGMScenarioGroupId(FlatBufferBuilder builder, VectorOffset beginConditionalBGMScenarioGroupIdOffset) { builder.AddOffset(7, beginConditionalBGMScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateBeginConditionalBGMScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBeginConditionalBGMScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBeginConditionalBGMScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBeginConditionalBGMScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBeginConditionalBGMScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddEndConditionalBGMScenarioGroupId(FlatBufferBuilder builder, VectorOffset endConditionalBGMScenarioGroupIdOffset) { builder.AddOffset(8, endConditionalBGMScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateEndConditionalBGMScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEndConditionalBGMScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEndConditionalBGMScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEndConditionalBGMScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEndConditionalBGMScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConditionalBGMId(FlatBufferBuilder builder, VectorOffset conditionalBGMIdOffset) { builder.AddOffset(9, conditionalBGMIdOffset.Value, 0); }
  public static VectorOffset CreateConditionalBGMIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionalBGMIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionalBGMIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionalBGMIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionalBGMIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.FieldSceneExcel> EndFieldSceneExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.FieldSceneExcel>(o);
  }
}


static public class FieldSceneExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*DateId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*GroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 10 /*ArtLevelPath*/, false)
      && verifier.VerifyString(tablePos, 12 /*DesignLevelPath*/, false)
      && verifier.VerifyField(tablePos, 14 /*BGMId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*ConditionalBGMQuestId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*BeginConditionalBGMScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*EndConditionalBGMScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 22 /*ConditionalBGMId*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}