// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EquipmentExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EquipmentExcel GetRootAsEquipmentExcel(ByteBuffer _bb) { return GetRootAsEquipmentExcel(_bb, new EquipmentExcel()); }
  public static EquipmentExcel GetRootAsEquipmentExcel(ByteBuffer _bb, EquipmentExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EquipmentExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.EquipmentCategory EquipmentCategory { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.EquipmentCategory)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EquipmentCategory.Unable; } }
  public SCHALE.Common.FlatData.Rarity Rarity { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.Rarity)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.Rarity.N; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool Wear { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int MaxLevel { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RecipeId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long TierInit { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NextTierEquipment { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StackableMax { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Icon { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(24); }
  public string ImageName { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImageNameBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetImageNameBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetImageNameArray() { return __p.__vector_as_array<byte>(26); }
  public SCHALE.Common.FlatData.Tag Tags(int j) { int o = __p.__offset(28); return o != 0 ? (SCHALE.Common.FlatData.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.Tag)0; }
  public int TagsLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.Tag> GetTagsBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.Tag>(28, 4); }
#else
  public ArraySegment<byte>? GetTagsBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public SCHALE.Common.FlatData.Tag[] GetTagsArray() { int o = __p.__offset(28); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.Tag[] a = new SCHALE.Common.FlatData.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.Tag)__p.bb.GetInt(p + i * 4); } return a; }
  public long CraftQualityTier0 { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CraftQualityTier1 { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CraftQualityTier2 { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ShiftingCraftQuality { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ShopCategoryType ShopCategory(int j) { int o = __p.__offset(38); return o != 0 ? (SCHALE.Common.FlatData.ShopCategoryType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ShopCategoryType)0; }
  public int ShopCategoryLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ShopCategoryType> GetShopCategoryBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ShopCategoryType>(38, 4); }
#else
  public ArraySegment<byte>? GetShopCategoryBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public SCHALE.Common.FlatData.ShopCategoryType[] GetShopCategoryArray() { int o = __p.__offset(38); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ShopCategoryType[] a = new SCHALE.Common.FlatData.ShopCategoryType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ShopCategoryType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ShortcutTypeId { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.EquipmentExcel> CreateEquipmentExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.EquipmentCategory EquipmentCategory = SCHALE.Common.FlatData.EquipmentCategory.Unable,
      SCHALE.Common.FlatData.Rarity Rarity = SCHALE.Common.FlatData.Rarity.N,
      uint LocalizeEtcId = 0,
      bool Wear = false,
      int MaxLevel = 0,
      int RecipeId = 0,
      long TierInit = 0,
      long NextTierEquipment = 0,
      int StackableMax = 0,
      StringOffset IconOffset = default(StringOffset),
      StringOffset ImageNameOffset = default(StringOffset),
      VectorOffset TagsOffset = default(VectorOffset),
      long CraftQualityTier0 = 0,
      long CraftQualityTier1 = 0,
      long CraftQualityTier2 = 0,
      long ShiftingCraftQuality = 0,
      VectorOffset ShopCategoryOffset = default(VectorOffset),
      long ShortcutTypeId = 0) {
    builder.StartTable(19);
    EquipmentExcel.AddShortcutTypeId(builder, ShortcutTypeId);
    EquipmentExcel.AddShiftingCraftQuality(builder, ShiftingCraftQuality);
    EquipmentExcel.AddCraftQualityTier2(builder, CraftQualityTier2);
    EquipmentExcel.AddCraftQualityTier1(builder, CraftQualityTier1);
    EquipmentExcel.AddCraftQualityTier0(builder, CraftQualityTier0);
    EquipmentExcel.AddNextTierEquipment(builder, NextTierEquipment);
    EquipmentExcel.AddTierInit(builder, TierInit);
    EquipmentExcel.AddId(builder, Id);
    EquipmentExcel.AddShopCategory(builder, ShopCategoryOffset);
    EquipmentExcel.AddTags(builder, TagsOffset);
    EquipmentExcel.AddImageName(builder, ImageNameOffset);
    EquipmentExcel.AddIcon(builder, IconOffset);
    EquipmentExcel.AddStackableMax(builder, StackableMax);
    EquipmentExcel.AddRecipeId(builder, RecipeId);
    EquipmentExcel.AddMaxLevel(builder, MaxLevel);
    EquipmentExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EquipmentExcel.AddRarity(builder, Rarity);
    EquipmentExcel.AddEquipmentCategory(builder, EquipmentCategory);
    EquipmentExcel.AddWear(builder, Wear);
    return EquipmentExcel.EndEquipmentExcel(builder);
  }

  public static void StartEquipmentExcel(FlatBufferBuilder builder) { builder.StartTable(19); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEquipmentCategory(FlatBufferBuilder builder, SCHALE.Common.FlatData.EquipmentCategory equipmentCategory) { builder.AddInt(1, (int)equipmentCategory, 0); }
  public static void AddRarity(FlatBufferBuilder builder, SCHALE.Common.FlatData.Rarity rarity) { builder.AddInt(2, (int)rarity, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(3, localizeEtcId, 0); }
  public static void AddWear(FlatBufferBuilder builder, bool wear) { builder.AddBool(4, wear, false); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int maxLevel) { builder.AddInt(5, maxLevel, 0); }
  public static void AddRecipeId(FlatBufferBuilder builder, int recipeId) { builder.AddInt(6, recipeId, 0); }
  public static void AddTierInit(FlatBufferBuilder builder, long tierInit) { builder.AddLong(7, tierInit, 0); }
  public static void AddNextTierEquipment(FlatBufferBuilder builder, long nextTierEquipment) { builder.AddLong(8, nextTierEquipment, 0); }
  public static void AddStackableMax(FlatBufferBuilder builder, int stackableMax) { builder.AddInt(9, stackableMax, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(10, iconOffset.Value, 0); }
  public static void AddImageName(FlatBufferBuilder builder, StringOffset imageNameOffset) { builder.AddOffset(11, imageNameOffset.Value, 0); }
  public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset) { builder.AddOffset(12, tagsOffset.Value, 0); }
  public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCraftQualityTier0(FlatBufferBuilder builder, long craftQualityTier0) { builder.AddLong(13, craftQualityTier0, 0); }
  public static void AddCraftQualityTier1(FlatBufferBuilder builder, long craftQualityTier1) { builder.AddLong(14, craftQualityTier1, 0); }
  public static void AddCraftQualityTier2(FlatBufferBuilder builder, long craftQualityTier2) { builder.AddLong(15, craftQualityTier2, 0); }
  public static void AddShiftingCraftQuality(FlatBufferBuilder builder, long shiftingCraftQuality) { builder.AddLong(16, shiftingCraftQuality, 0); }
  public static void AddShopCategory(FlatBufferBuilder builder, VectorOffset shopCategoryOffset) { builder.AddOffset(17, shopCategoryOffset.Value, 0); }
  public static VectorOffset CreateShopCategoryVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ShopCategoryType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ShopCategoryType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ShopCategoryType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ShopCategoryType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShopCategoryVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShortcutTypeId(FlatBufferBuilder builder, long shortcutTypeId) { builder.AddLong(18, shortcutTypeId, 0); }
  public static Offset<SCHALE.Common.FlatData.EquipmentExcel> EndEquipmentExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EquipmentExcel>(o);
  }
}


static public class EquipmentExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EquipmentCategory*/, 4 /*SCHALE.Common.FlatData.EquipmentCategory*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Rarity*/, 4 /*SCHALE.Common.FlatData.Rarity*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*Wear*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 14 /*MaxLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*RecipeId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*TierInit*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*NextTierEquipment*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*StackableMax*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 24 /*Icon*/, false)
      && verifier.VerifyString(tablePos, 26 /*ImageName*/, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*Tags*/, 4 /*SCHALE.Common.FlatData.Tag*/, false)
      && verifier.VerifyField(tablePos, 30 /*CraftQualityTier0*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*CraftQualityTier1*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 34 /*CraftQualityTier2*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 36 /*ShiftingCraftQuality*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 38 /*ShopCategory*/, 4 /*SCHALE.Common.FlatData.ShopCategoryType*/, false)
      && verifier.VerifyField(tablePos, 40 /*ShortcutTypeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}