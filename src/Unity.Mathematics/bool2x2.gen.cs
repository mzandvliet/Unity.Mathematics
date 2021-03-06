// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct bool2x2 : System.IEquatable<bool2x2>
    {
        public bool2 c0;
        public bool2 c1;


        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x2(bool2 c0, bool2 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x2(bool m00, bool m01,
                       bool m10, bool m11)
        { 
            this.c0 = new bool2(m00, m10);
            this.c1 = new bool2(m01, m11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x2(bool v)
        {
            this.c0 = v;
            this.c1 = v;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool2x2(bool v) { return new bool2x2(v); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (bool2x2 lhs, bool2x2 rhs) { return new bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (bool2x2 lhs, bool rhs) { return new bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (bool lhs, bool2x2 rhs) { return new bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (bool2x2 lhs, bool2x2 rhs) { return new bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (bool2x2 lhs, bool rhs) { return new bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (bool lhs, bool2x2 rhs) { return new bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator & (bool2x2 lhs, bool2x2 rhs) { return new bool2x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator & (bool2x2 lhs, bool rhs) { return new bool2x2 (lhs.c0 & rhs, lhs.c1 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator & (bool lhs, bool2x2 rhs) { return new bool2x2 (lhs & rhs.c0, lhs & rhs.c1); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator | (bool2x2 lhs, bool2x2 rhs) { return new bool2x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator | (bool2x2 lhs, bool rhs) { return new bool2x2 (lhs.c0 | rhs, lhs.c1 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator | (bool lhs, bool2x2 rhs) { return new bool2x2 (lhs | rhs.c0, lhs | rhs.c1); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator ^ (bool2x2 lhs, bool2x2 rhs) { return new bool2x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator ^ (bool2x2 lhs, bool rhs) { return new bool2x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator ^ (bool lhs, bool2x2 rhs) { return new bool2x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }

        // [int index] 
        unsafe public bool2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool2x2* array = &this) { return ((bool2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(bool2x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((bool2x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool2x2({0}, {1},  {2}, {3})", c0.x, c1.x, c0.y, c1.y);
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 bool2x2(bool2 c0, bool2 c1) { return new bool2x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 bool2x2(bool m00, bool m01,
                                      bool m10, bool m11)
        {
            return new bool2x2(m00, m01,
                               m10, m11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 bool2x2(bool v) { return new bool2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 transpose(bool2x2 v)
        {
            return bool2x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool2x2 v)
        {
            return csum(select(uint2(0xA1E92D39u, 0x4583C801u), uint2(0x9536A0F5u, 0xAF816615u), v.c0) + 
                        select(uint2(0x9AF8D62Du, 0xE3600729u), uint2(0x5F17300Du, 0x670D6809u), v.c1));
        }

    }
}
