/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

using System.Collections.Generic;

/**
 * IP Address Conversion and CIDR calculator
 */
namespace mindpowered.iptools {
	public delegate void MyCallbackDelegate(object o);

	public class IPTools
	{
		public IPTools()
		{
			global::maglev.MagLev bus = global::maglev.MagLev.getInstance("default");
			global::iptools.IPTools myinstance = new global::iptools.IPTools(bus);
		}

		/**
		 * Convert a subnet mask to CIDR notation
		 * @param subnet_mask A subnet mask eg. 255.255.0.0
		 * @return {object} object containing information about subnet including CIDR prefix
		*/
		public object SubnetMaskToCIDR(string subnet_mask)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(subnet_mask);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("IPTools.SubnetMaskToCIDR", args, async_callback);
			return ret;
		}

		/**
		 * Given an IP address or IP address with CIDR notation, provides information about an IP address range
		 * @param ip_addr An IP address with or without CIDR notation
		 * @return {object[]} a list of objects containing information about the IP address range
		*/
		public object[] CalcCIDR(string ip_addr)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(ip_addr);
			object[] ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("IPTools.CalcCIDR", args, async_callback);
			return ret;
		}

		/**
		 * Convert an IP address to a Decimal representation
		 * @param ip_addr An IP address
		 * @return {string} Decimal representation of the provided IP address
		*/
		public string IPToDecimal(string ip_addr)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(ip_addr);
			string ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("IPTools.IPToDecimal", args, async_callback);
			return ret;
		}

		/**
		 * Convert from a Decimal representationan of an IP address
		 * @param ip4_number Decimal representation of an IP address
		 * @return {string} The IP address
		*/
		public string IP4FromDecimal(string ip4_number)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(ip4_number);
			string ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("IPTools.IP4FromDecimal", args, async_callback);
			return ret;
		}

		/**
		 * Convert from a Decimal representationan of an IP address
		 * @param ip6_number Decimal representation of an IP address
		 * @return {string} The IP address
		*/
		public string IP6FromDecimal(string ip6_number)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(ip6_number);
			string ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("IPTools.IP6FromDecimal", args, async_callback);
			return ret;
		}

		/**
		 * Convert an IPv4 address to an IPv6 address
		 * @param ip_addr An IPv4 address
		 * @return {object} An object containing IPv6 representations of the provided IPv4 address
		*/
		public object IPv4ToIPv6(string ip_addr)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(ip_addr);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("IPTools.IPv4ToIPv6", args, async_callback);
			return ret;
		}

		/**
		 * Expand the zeros in an IPv6 address
		 * @param ip6_addr An IPv6 address
		 * @return {object} The same IPv6 address with zeros expanded
		*/
		public object ExpandIPv6(string ip6_addr)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(ip6_addr);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("IPTools.ExpandIPv6", args, async_callback);
			return ret;
		}

		/**
		 * Compress the zeros in an IPv6 address
		 * @param ip6_addr An IPv6 address
		 * @return {object} The same IPv6 address with zeros compressed
		*/
		public object CompressIPv6(string ip6_addr)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(ip6_addr);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("IPTools.CompressIPv6", args, async_callback);
			return ret;
		}

	}
}

