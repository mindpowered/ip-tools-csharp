// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe._Int64 {
	public sealed class Int64_Impl_ {
		
		static Int64_Impl_() {
			unchecked{
				#line 32 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				global::haxe.lang.FieldLookup.addFields(new int[]{845179051, 2012934199}, new string[]{"quotient", "modulus"});
			}
		}
		#line default
		
		public static long make(int high, int low) {
			unchecked {
				#line 34 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				long this1 = ( ( ((long) (high) ) << 32 ) | ( ((long) (low) ) & 0xffffffffL ) );
				#line 34 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				return ((long) (this1) );
			}
			#line default
		}
		
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static long _new(long x) {
			#line 36 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			long this1 = x;
			#line 36 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ((long) (this1) );
		}
		#line default
		
		
		
		public static long get_val(long this1) {
			#line 42 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return this1;
		}
		#line default
		
		public static long set_val(long this1, long x) {
			#line 45 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			this1 = x;
			#line 45 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return this1;
		}
		#line default
		
		
		
		public static int get_high(long this1) {
			unchecked {
				#line 50 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				return ((int) (( this1 >> 32 )) );
			}
			#line default
		}
		
		
		
		
		public static int get_low(long this1) {
			#line 55 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ((int) (this1) );
		}
		#line default
		
		public static long copy(long this1) {
			#line 58 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			long this2 = this1;
			#line 58 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ((long) (this2) );
		}
		#line default
		
		public static long ofInt(int x) {
			#line 61 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ((long) (x) );
		}
		#line default
		
		public static int toInt(long x) {
			unchecked {
				#line 64 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				if (( ( ((long) (x) ) < -2147483648 ) || ( ((long) (x) ) > 2147483647 ) )) {
					#line 65 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
					throw ((global::System.Exception) (global::haxe.Exception.thrown("Overflow")) );
				}
				
				#line 66 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				return ((int) (((long) (x) )) );
			}
			#line default
		}
		
		
		public static bool @is(object val) {
			#line 71 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( val is global::System.Int64 );
		}
		#line default
		
		public static bool isInt64(object val) {
			#line 74 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( val is global::System.Int64 );
		}
		#line default
		
		public static int getHigh(long x) {
			unchecked {
				#line 77 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				return ((int) (( ((long) (x) ) >> 32 )) );
			}
			#line default
		}
		
		
		public static int getLow(long x) {
			#line 80 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ((int) (((long) (x) )) );
		}
		#line default
		
		public static bool isNeg(long x) {
			#line 83 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (x) ) < 0 );
		}
		#line default
		
		public static bool isZero(long x) {
			#line 86 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (x) ) == 0 );
		}
		#line default
		
		public static int compare(long a, long b) {
			unchecked {
				#line 89 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				if (( ((long) (a) ) < ((long) (b) ) )) {
					#line 90 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
					return -1;
				}
				
				#line 91 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				if (( ((long) (a) ) > ((long) (b) ) )) {
					#line 92 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
					return 1;
				}
				
				#line 93 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				return 0;
			}
			#line default
		}
		
		
		public static int ucompare(long a, long b) {
			unchecked {
				#line 97 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				if (( ((long) (a) ) < 0 )) {
					#line 98 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
					if (( ((long) (b) ) < 0 )) {
						#line 98 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
						if (( ((long) (a) ) < ((long) (b) ) )) {
							#line 98 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
							return -1;
						}
						else if (( ((long) (a) ) > ((long) (b) ) )) {
							#line 98 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
							return 1;
						}
						else {
							#line 98 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
							return 0;
						}
						
					}
					else {
						#line 98 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
						return 1;
					}
					
				}
				
				#line 99 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				if (( ((long) (b) ) < 0 )) {
					#line 99 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
					return -1;
				}
				else if (( ((long) (a) ) < ((long) (b) ) )) {
					#line 99 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
					return -1;
				}
				else if (( ((long) (a) ) > ((long) (b) ) )) {
					#line 99 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
					return 1;
				}
				else {
					#line 99 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
					return 0;
				}
				
			}
			#line default
		}
		
		
		public static string toStr(long x) {
			#line 103 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return global::haxe.lang.Runtime.concat("", global::Std.@string(((long) (x) )));
		}
		#line default
		
		public static object divMod(long dividend, long divisor) {
			#line 106 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return new global::haxe.lang.DynamicObject(new int[]{845179051, 2012934199}, new object[]{((long) (( ((long) (dividend) ) / ((long) (divisor) ) )) ), ((long) (( ((long) (dividend) ) % ((long) (divisor) ) )) )}, new int[]{}, new double[]{});
		}
		#line default
		
		public static string toString(long this1) {
			#line 109 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return global::haxe.lang.Runtime.concat("", global::Std.@string(this1));
		}
		#line default
		
		public static long parseString(string sParam) {
			#line 112 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return global::haxe.Int64Helper.parseString(sParam);
		}
		#line default
		
		public static long fromFloat(double f) {
			#line 116 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return global::haxe.Int64Helper.fromFloat(f);
		}
		#line default
		
		public static long neg(long x) {
			#line 120 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return  - (((long) (x) )) ;
		}
		#line default
		
		public static long preIncrement(long this1) {
			unchecked {
				#line 123 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				this1 += ((long) (1) );
				#line 123 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				return this1;
			}
			#line default
		}
		
		
		public static long postIncrement(long this1) {
			unchecked {
				#line 126 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				this1 += ((long) (1) );
				#line 126 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				return ( this1 - 1 );
			}
			#line default
		}
		
		
		public static long preDecrement(long this1) {
			unchecked {
				#line 129 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				this1 -= ((long) (1) );
				#line 129 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				return this1;
			}
			#line default
		}
		
		
		public static long postDecrement(long this1) {
			unchecked {
				#line 132 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				this1 -= ((long) (1) );
				#line 132 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
				return ( this1 + 1 );
			}
			#line default
		}
		
		
		public static long @add(long a, long b) {
			#line 135 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) + ((long) (b) ) );
		}
		#line default
		
		public static long addInt(long a, int b) {
			#line 138 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) + b );
		}
		#line default
		
		public static long sub(long a, long b) {
			#line 141 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) - ((long) (b) ) );
		}
		#line default
		
		public static long subInt(long a, int b) {
			#line 144 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) - b );
		}
		#line default
		
		public static long intSub(int a, long b) {
			#line 147 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( a - ((long) (b) ) );
		}
		#line default
		
		public static long mul(long a, long b) {
			#line 150 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) * ((long) (b) ) );
		}
		#line default
		
		public static long mulInt(long a, int b) {
			#line 153 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) * b );
		}
		#line default
		
		public static long div(long a, long b) {
			#line 156 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) / ((long) (b) ) );
		}
		#line default
		
		public static long divInt(long a, int b) {
			#line 159 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) / b );
		}
		#line default
		
		public static long intDiv(int a, long b) {
			#line 162 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( a / ((long) (b) ) );
		}
		#line default
		
		public static long mod(long a, long b) {
			#line 165 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) % ((long) (b) ) );
		}
		#line default
		
		public static long modInt(long a, int b) {
			#line 168 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) % b );
		}
		#line default
		
		public static long intMod(int a, long b) {
			#line 171 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( a % ((long) (b) ) );
		}
		#line default
		
		public static bool eq(long a, long b) {
			#line 174 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) == ((long) (b) ) );
		}
		#line default
		
		public static bool eqInt(long a, int b) {
			#line 177 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) == b );
		}
		#line default
		
		public static bool neq(long a, long b) {
			#line 180 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) != ((long) (b) ) );
		}
		#line default
		
		public static bool neqInt(long a, int b) {
			#line 183 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) != b );
		}
		#line default
		
		public static bool lt(long a, long b) {
			#line 186 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) < ((long) (b) ) );
		}
		#line default
		
		public static bool ltInt(long a, int b) {
			#line 189 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) < b );
		}
		#line default
		
		public static bool intLt(int a, long b) {
			#line 192 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( a < ((long) (b) ) );
		}
		#line default
		
		public static bool lte(long a, long b) {
			#line 195 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) <= ((long) (b) ) );
		}
		#line default
		
		public static bool lteInt(long a, int b) {
			#line 198 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) <= b );
		}
		#line default
		
		public static bool intLte(int a, long b) {
			#line 201 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( a <= ((long) (b) ) );
		}
		#line default
		
		public static bool gt(long a, long b) {
			#line 204 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) > ((long) (b) ) );
		}
		#line default
		
		public static bool gtInt(long a, int b) {
			#line 207 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) > b );
		}
		#line default
		
		public static bool intGt(int a, long b) {
			#line 210 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( a > ((long) (b) ) );
		}
		#line default
		
		public static bool gte(long a, long b) {
			#line 213 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) >= ((long) (b) ) );
		}
		#line default
		
		public static bool gteInt(long a, int b) {
			#line 216 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) >= b );
		}
		#line default
		
		public static bool intGte(int a, long b) {
			#line 219 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( a >= ((long) (b) ) );
		}
		#line default
		
		public static long complement(long x) {
			#line 222 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return  ~ (((long) (x) )) ;
		}
		#line default
		
		public static long and(long a, long b) {
			#line 225 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) & ((long) (b) ) );
		}
		#line default
		
		public static long or(long a, long b) {
			#line 228 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) | ((long) (b) ) );
		}
		#line default
		
		public static long xor(long a, long b) {
			#line 231 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) ^ ((long) (b) ) );
		}
		#line default
		
		public static long shl(long a, int b) {
			#line 234 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) << b );
		}
		#line default
		
		public static long shr(long a, int b) {
			#line 237 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ( ((long) (a) ) >> b );
		}
		#line default
		
		public static long ushr(long a, int b) {
			#line 240 "/opt/haxe/std/cs/_std/haxe/Int64.hx"
			return ((long) (( ((ulong) (((long) (a) )) ) >> b )) );
		}
		#line default
		
	}
}


