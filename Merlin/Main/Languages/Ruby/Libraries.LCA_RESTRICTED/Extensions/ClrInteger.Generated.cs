﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Microsoft Public License. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Microsoft Public License, please send an email to 
 * ironruby@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Microsoft Public License.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System;
using IronRuby.Runtime;
using Microsoft.Scripting.Math;
using Microsoft.Scripting.Runtime;

namespace IronRuby.Builtins {
    [RubyClass(Extends = typeof(Byte), Inherits = typeof(Integer), Restrictions = ModuleRestrictions.None), Includes(typeof(ClrInteger), Copy = true)]
    public static partial class ByteOps { 
    }

    [RubyClass(Extends = typeof(SByte), Inherits = typeof(Integer), Restrictions = ModuleRestrictions.None), Includes(typeof(ClrInteger), Copy = true)]
    public static partial class SByteOps {
    }

    [RubyClass(Extends = typeof(Int16), Inherits = typeof(Integer), Restrictions = ModuleRestrictions.None), Includes(typeof(ClrInteger), Copy = true)]
    public static partial class Int16Ops {
    }

    [RubyClass(Extends = typeof(UInt16), Inherits = typeof(Integer), Restrictions = ModuleRestrictions.None), Includes(typeof(ClrInteger), Copy = true)]
    public static partial class UInt16Ops {
    }

    [RubyClass(Extends = typeof(UInt32), Inherits = typeof(Integer), Restrictions = ModuleRestrictions.None), Includes(typeof(ClrBigInteger), Copy = true)]
    public static partial class UInt32Ops {
    }

    [RubyClass(Extends = typeof(Int64), Inherits = typeof(Integer), Restrictions = ModuleRestrictions.None), Includes(typeof(ClrBigInteger), Copy = true)]
    public static partial class Int64Ops {
    }

    [RubyClass(Extends = typeof(UInt64), Inherits = typeof(Integer), Restrictions = ModuleRestrictions.None), Includes(typeof(ClrBigInteger), Copy = true)]
    public static partial class UInt64Ops {
    }

    #region new, size, induced_from, succ

    // *** BEGIN GENERATED CODE ***
    // Generated by ClrInteger.Generator.rb

    public static partial class ByteOps {
        [RubyMethod("size")]
        public static int Size(Byte self) {
            return sizeof(Byte);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static Byte InducedFrom(RubyClass/*!*/ self, [DefaultProtocol]int value) {
            if (value >= Byte.MinValue && value <= Byte.MaxValue) {
                return (Byte)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
        
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static Byte InducedFrom(RubyClass/*!*/ self, [NotNull]BigInteger/*!*/ value) {
            if (value >= Byte.MinValue && value <= Byte.MaxValue) {
                return (Byte)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static Byte InducedFrom(RubyClass/*!*/ self, double value) {
            if (value >= Byte.MinValue && value <= Byte.MaxValue) {
                return (Byte)value;
            }
            throw RubyExceptions.CreateRangeError("Float {0} out of range of {1}", value, self.Name);
        }
        
        [RubyMethod("inspect")]
        public static MutableString/*!*/ Inspect(object/*!*/ self) {
            return MutableString.CreateMutable(RubyEncoding.Binary).Append(self.ToString()).Append(" (Byte)");
        }
        
        [RubyMethod("succ")]
        [RubyMethod("next")]
        public static object Next(Byte self) {
            if (self == Byte.MaxValue) {
                return (Int32)self + 1;
            }
            return (Byte)(self + 1);
        }
    }
    
    public static partial class SByteOps {
        [RubyMethod("size")]
        public static int Size(SByte self) {
            return sizeof(SByte);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static SByte InducedFrom(RubyClass/*!*/ self, [DefaultProtocol]int value) {
            if (value >= SByte.MinValue && value <= SByte.MaxValue) {
                return (SByte)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
        
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static SByte InducedFrom(RubyClass/*!*/ self, [NotNull]BigInteger/*!*/ value) {
            if (value >= SByte.MinValue && value <= SByte.MaxValue) {
                return (SByte)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static SByte InducedFrom(RubyClass/*!*/ self, double value) {
            if (value >= SByte.MinValue && value <= SByte.MaxValue) {
                return (SByte)value;
            }
            throw RubyExceptions.CreateRangeError("Float {0} out of range of {1}", value, self.Name);
        }
        
        [RubyMethod("inspect")]
        public static MutableString/*!*/ Inspect(object/*!*/ self) {
            return MutableString.CreateMutable(RubyEncoding.Binary).Append(self.ToString()).Append(" (SByte)");
        }
        
        [RubyMethod("succ")]
        [RubyMethod("next")]
        public static object Next(SByte self) {
            if (self == SByte.MaxValue) {
                return (Int32)self + 1;
            }
            return (SByte)(self + 1);
        }
    }
    
    public static partial class Int16Ops {
        [RubyMethod("size")]
        public static int Size(Int16 self) {
            return sizeof(Int16);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static Int16 InducedFrom(RubyClass/*!*/ self, [DefaultProtocol]int value) {
            if (value >= Int16.MinValue && value <= Int16.MaxValue) {
                return (Int16)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
        
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static Int16 InducedFrom(RubyClass/*!*/ self, [NotNull]BigInteger/*!*/ value) {
            if (value >= Int16.MinValue && value <= Int16.MaxValue) {
                return (Int16)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static Int16 InducedFrom(RubyClass/*!*/ self, double value) {
            if (value >= Int16.MinValue && value <= Int16.MaxValue) {
                return (Int16)value;
            }
            throw RubyExceptions.CreateRangeError("Float {0} out of range of {1}", value, self.Name);
        }
        
        [RubyMethod("inspect")]
        public static MutableString/*!*/ Inspect(object/*!*/ self) {
            return MutableString.CreateMutable(RubyEncoding.Binary).Append(self.ToString()).Append(" (Int16)");
        }
        
        [RubyMethod("succ")]
        [RubyMethod("next")]
        public static object Next(Int16 self) {
            if (self == Int16.MaxValue) {
                return (Int32)self + 1;
            }
            return (Int16)(self + 1);
        }
    }
    
    public static partial class UInt16Ops {
        [RubyMethod("size")]
        public static int Size(UInt16 self) {
            return sizeof(UInt16);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static UInt16 InducedFrom(RubyClass/*!*/ self, [DefaultProtocol]int value) {
            if (value >= 0 && value <= UInt16.MaxValue) {
                return (UInt16)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
        
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static UInt16 InducedFrom(RubyClass/*!*/ self, [NotNull]BigInteger/*!*/ value) {
            if (value >= UInt16.MinValue && value <= UInt16.MaxValue) {
                return (UInt16)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static UInt16 InducedFrom(RubyClass/*!*/ self, double value) {
            if (value >= UInt16.MinValue && value <= UInt16.MaxValue) {
                return (UInt16)value;
            }
            throw RubyExceptions.CreateRangeError("Float {0} out of range of {1}", value, self.Name);
        }
        
        [RubyMethod("inspect")]
        public static MutableString/*!*/ Inspect(object/*!*/ self) {
            return MutableString.CreateMutable(RubyEncoding.Binary).Append(self.ToString()).Append(" (UInt16)");
        }
        
        [RubyMethod("succ")]
        [RubyMethod("next")]
        public static object Next(UInt16 self) {
            if (self == UInt16.MaxValue) {
                return (Int32)self + 1;
            }
            return (UInt16)(self + 1);
        }
    }
    
    public static partial class UInt32Ops {
        [RubyMethod("size")]
        public static int Size(UInt32 self) {
            return sizeof(UInt32);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static UInt32 InducedFrom(RubyClass/*!*/ self, [DefaultProtocol]int value) {
            if (value >= 0) {
                return (UInt32)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
        
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static UInt32 InducedFrom(RubyClass/*!*/ self, [NotNull]BigInteger/*!*/ value) {
            if (value >= UInt32.MinValue && value <= UInt32.MaxValue) {
                return (UInt32)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static UInt32 InducedFrom(RubyClass/*!*/ self, double value) {
            if (value >= UInt32.MinValue && value <= UInt32.MaxValue) {
                return (UInt32)value;
            }
            throw RubyExceptions.CreateRangeError("Float {0} out of range of {1}", value, self.Name);
        }
        
        [RubyMethod("inspect")]
        public static MutableString/*!*/ Inspect(object/*!*/ self) {
            return MutableString.CreateMutable(RubyEncoding.Binary).Append(self.ToString()).Append(" (UInt32)");
        }
        
        [RubyMethod("succ")]
        [RubyMethod("next")]
        public static object Next(UInt32 self) {
            if (self == UInt32.MaxValue) {
                return (BigInteger)self + 1;
            }
            return (UInt32)(self + 1);
        }
    }
    
    public static partial class Int64Ops {
        [RubyMethod("size")]
        public static int Size(Int64 self) {
            return sizeof(Int64);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static Int64 InducedFrom(RubyClass/*!*/ self, [DefaultProtocol]int value) {
            if (true) {
                return (Int64)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
        
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static Int64 InducedFrom(RubyClass/*!*/ self, [NotNull]BigInteger/*!*/ value) {
            if (value >= Int64.MinValue && value <= Int64.MaxValue) {
                return (Int64)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static Int64 InducedFrom(RubyClass/*!*/ self, double value) {
            if (value >= Int64.MinValue && value <= Int64.MaxValue) {
                return (Int64)value;
            }
            throw RubyExceptions.CreateRangeError("Float {0} out of range of {1}", value, self.Name);
        }
        
        [RubyMethod("inspect")]
        public static MutableString/*!*/ Inspect(object/*!*/ self) {
            return MutableString.CreateMutable(RubyEncoding.Binary).Append(self.ToString()).Append(" (Int64)");
        }
        
        [RubyMethod("succ")]
        [RubyMethod("next")]
        public static object Next(Int64 self) {
            if (self == Int64.MaxValue) {
                return (BigInteger)self + 1;
            }
            return (Int64)(self + 1);
        }
    }
    
    public static partial class UInt64Ops {
        [RubyMethod("size")]
        public static int Size(UInt64 self) {
            return sizeof(UInt64);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static UInt64 InducedFrom(RubyClass/*!*/ self, [DefaultProtocol]int value) {
            if (value >= 0) {
                return (UInt64)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
        
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static UInt64 InducedFrom(RubyClass/*!*/ self, [NotNull]BigInteger/*!*/ value) {
            if (value >= UInt64.MinValue && value <= UInt64.MaxValue) {
                return (UInt64)value;
            }
            throw RubyExceptions.CreateRangeError("Integer {0} out of range of {1}", value, self.Name);
        }
    
        [RubyConstructor]
        [RubyMethod("induced_from", RubyMethodAttributes.PublicSingleton)]
        public static UInt64 InducedFrom(RubyClass/*!*/ self, double value) {
            if (value >= UInt64.MinValue && value <= UInt64.MaxValue) {
                return (UInt64)value;
            }
            throw RubyExceptions.CreateRangeError("Float {0} out of range of {1}", value, self.Name);
        }
        
        [RubyMethod("inspect")]
        public static MutableString/*!*/ Inspect(object/*!*/ self) {
            return MutableString.CreateMutable(RubyEncoding.Binary).Append(self.ToString()).Append(" (UInt64)");
        }
        
        [RubyMethod("succ")]
        [RubyMethod("next")]
        public static object Next(UInt64 self) {
            if (self == UInt64.MaxValue) {
                return (BigInteger)self + 1;
            }
            return (UInt64)(self + 1);
        }
    }

    // *** END GENERATED CODE ***

    #endregion
}
