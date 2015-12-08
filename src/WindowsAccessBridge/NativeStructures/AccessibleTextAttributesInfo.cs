﻿using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using jint = System.Int32;
using jfloat = System.Single;
using BOOL = System.Int32;

namespace AccessBridgeExplorer.WindowsAccessBridge.NativeStructures {
  // standard attributes for text; note: tabstops are not supported
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  public struct AccessibleTextAttributesInfo {
    public BOOL bold;
    public BOOL italic;
    public BOOL underline;
    public BOOL strikethrough;
    public BOOL superscript;
    public BOOL subscript;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.SHORT_STRING_SIZE)]
    public string backgroundColor;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.SHORT_STRING_SIZE)]
    public string foregroundColor;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.SHORT_STRING_SIZE)]
    public string fontFamily;
    public jint fontSize;

    public jint alignment;
    public jint bidiLevel;

    public jfloat firstLineIndent;
    public jfloat leftIndent;
    public jfloat rightIndent;
    public jfloat lineSpacing;
    public jfloat spaceAbove;
    public jfloat spaceBelow;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.MAX_STRING_SIZE)]
    public string fullAttributesString;
  }
}
