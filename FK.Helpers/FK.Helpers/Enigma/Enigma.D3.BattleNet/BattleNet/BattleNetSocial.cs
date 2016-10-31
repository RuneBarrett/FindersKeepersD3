using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.BattleNet
{
	[Version("2.1.0.26451")]
	[Obsolete("Fields not updated")]
	public class BattleNetSocial : MemoryObject
	{
		public const int SizeOf = 0xB48; // 2888

		public int x000_VTable { get { return Read<int>(0x000); } }
		public int _x004 { get { return Read<int>(0x004); } }
		public int x008_Ptr_HeroSelect { get { return Read<int>(0x008); } }
		public int _x00C { get { return Read<int>(0x00C); } }
		public int x010_StructStart { get { return Read<int>(0x010); } }
		public int _x014 { get { return Read<int>(0x014); } }
		public int _x018 { get { return Read<int>(0x018); } }
		public int _x01C { get { return Read<int>(0x01C); } }
		public int _x020 { get { return Read<int>(0x020); } }
		public int _x024 { get { return Read<int>(0x024); } }
		public int _x028 { get { return Read<int>(0x028); } }
		public int _x02C { get { return Read<int>(0x02C); } }
		public int _x030 { get { return Read<int>(0x030); } }
		public int _x034 { get { return Read<int>(0x034); } }
		public int _x038 { get { return Read<int>(0x038); } }
		public int _x03C { get { return Read<int>(0x03C); } }
		public int _x040 { get { return Read<int>(0x040); } }
		public int _x044 { get { return Read<int>(0x044); } }
		public int _x048 { get { return Read<int>(0x048); } }
		public int _x04C { get { return Read<int>(0x04C); } }
		public int _x050 { get { return Read<int>(0x050); } }
		public int _x054 { get { return Read<int>(0x054); } }
		public int _x058 { get { return Read<int>(0x058); } }
		public int _x05C { get { return Read<int>(0x05C); } }
		public int _x060 { get { return Read<int>(0x060); } }
		public int _x064 { get { return Read<int>(0x064); } }
		public int _x068 { get { return Read<int>(0x068); } }
		public int _x06C { get { return Read<int>(0x06C); } }
		public int _x070 { get { return Read<int>(0x070); } }
		public int _x074 { get { return Read<int>(0x074); } }
		public int _x078 { get { return Read<int>(0x078); } }
		public int _x07C { get { return Read<int>(0x07C); } }
		public int _x080 { get { return Read<int>(0x080); } }
		public int _x084 { get { return Read<int>(0x084); } }
		public int _x088 { get { return Read<int>(0x088); } }
		public int _x08C { get { return Read<int>(0x08C); } }
		public int _x090 { get { return Read<int>(0x090); } }
		public int _x094 { get { return Read<int>(0x094); } }
		public int _x098 { get { return Read<int>(0x098); } }
		public int _x09C { get { return Read<int>(0x09C); } }
		public int _x0A0 { get { return Read<int>(0x0A0); } }
		public int _x0A4 { get { return Read<int>(0x0A4); } }
		public int _x0A8 { get { return Read<int>(0x0A8); } }
		public int _x0AC { get { return Read<int>(0x0AC); } }
		public int _x0B0 { get { return Read<int>(0x0B0); } }
		public int _x0B4 { get { return Read<int>(0x0B4); } }
		public int _x0B8 { get { return Read<int>(0x0B8); } }
		public int _x0BC { get { return Read<int>(0x0BC); } }
		public int _x0C0 { get { return Read<int>(0x0C0); } }
		public int _x0C4 { get { return Read<int>(0x0C4); } }
		public int _x0C8 { get { return Read<int>(0x0C8); } }
		public int _x0CC { get { return Read<int>(0x0CC); } }
		public int _x0D0 { get { return Read<int>(0x0D0); } }
		public int _x0D4 { get { return Read<int>(0x0D4); } }
		public int _x0D8 { get { return Read<int>(0x0D8); } }
		public int _x0DC { get { return Read<int>(0x0DC); } }
		public int x0E0_StructStart { get { return Read<int>(0x0E0); } }
		public int _x0E4 { get { return Read<int>(0x0E4); } }
		public int _x0E8 { get { return Read<int>(0x0E8); } }
		public int _x0EC { get { return Read<int>(0x0EC); } }
		public int _x0F0 { get { return Read<int>(0x0F0); } }
		public int _x0F4 { get { return Read<int>(0x0F4); } }
		public int _x0F8 { get { return Read<int>(0x0F8); } }
		public int _x0FC { get { return Read<int>(0x0FC); } }
		public int _x100 { get { return Read<int>(0x100); } }
		public int _x104 { get { return Read<int>(0x104); } }
		public int _x108 { get { return Read<int>(0x108); } }
		public int _x10C { get { return Read<int>(0x10C); } }
		public int _x110 { get { return Read<int>(0x110); } }
		public int _x114 { get { return Read<int>(0x114); } }
		public int _x118 { get { return Read<int>(0x118); } }
		public int _x11C { get { return Read<int>(0x11C); } }
		public int _x120 { get { return Read<int>(0x120); } }
		public int _x124 { get { return Read<int>(0x124); } }
		public int _x128 { get { return Read<int>(0x128); } }
		public int _x12C { get { return Read<int>(0x12C); } }
		public int _x130 { get { return Read<int>(0x130); } }
		public int _x134 { get { return Read<int>(0x134); } }
		public int _x138 { get { return Read<int>(0x138); } }
		public int _x13C { get { return Read<int>(0x13C); } }
		public int _x140 { get { return Read<int>(0x140); } }
		public int _x144 { get { return Read<int>(0x144); } }
		public int _x148 { get { return Read<int>(0x148); } }
		public int _x14C { get { return Read<int>(0x14C); } }
		public int _x150 { get { return Read<int>(0x150); } }
		public int _x154 { get { return Read<int>(0x154); } }
		public int _x158 { get { return Read<int>(0x158); } }
		public int _x15C { get { return Read<int>(0x15C); } }
		public int _x160 { get { return Read<int>(0x160); } }
		public int _x164 { get { return Read<int>(0x164); } }
		public int _x168 { get { return Read<int>(0x168); } }
		public int _x16C { get { return Read<int>(0x16C); } }
		public int _x170 { get { return Read<int>(0x170); } }
		public int _x174 { get { return Read<int>(0x174); } }
		public int _x178 { get { return Read<int>(0x178); } }
		public int _x17C { get { return Read<int>(0x17C); } }
		public int _x180 { get { return Read<int>(0x180); } }
		public int _x184 { get { return Read<int>(0x184); } }
		public int x188_StructStart { get { return Read<int>(0x188); } }
		public int _x18C { get { return Read<int>(0x18C); } }
		public int _x190 { get { return Read<int>(0x190); } }
		public int _x194 { get { return Read<int>(0x194); } }
		public int _x198 { get { return Read<int>(0x198); } }
		public int _x19C { get { return Read<int>(0x19C); } }
		public int _x1A0 { get { return Read<int>(0x1A0); } }
		public int _x1A4 { get { return Read<int>(0x1A4); } }
		public int _x1A8 { get { return Read<int>(0x1A8); } }
		public int _x1AC { get { return Read<int>(0x1AC); } }
		public int _x1B0 { get { return Read<int>(0x1B0); } }
		public int _x1B4 { get { return Read<int>(0x1B4); } }
		public int _x1B8 { get { return Read<int>(0x1B8); } }
		public int _x1BC { get { return Read<int>(0x1BC); } }
		public int _x1C0 { get { return Read<int>(0x1C0); } }
		public int _x1C4 { get { return Read<int>(0x1C4); } }
		public int _x1C8 { get { return Read<int>(0x1C8); } }
		public int _x1CC { get { return Read<int>(0x1CC); } }
		public int _x1D0 { get { return Read<int>(0x1D0); } }
		public int _x1D4 { get { return Read<int>(0x1D4); } }
		public int _x1D8 { get { return Read<int>(0x1D8); } }
		public int _x1DC { get { return Read<int>(0x1DC); } }
		public int _x1E0 { get { return Read<int>(0x1E0); } }
		public int _x1E4 { get { return Read<int>(0x1E4); } }
		public int _x1E8 { get { return Read<int>(0x1E8); } }
		public int _x1EC { get { return Read<int>(0x1EC); } }
		public int _x1F0 { get { return Read<int>(0x1F0); } }
		public int _x1F4 { get { return Read<int>(0x1F4); } }
		public int _x1F8 { get { return Read<int>(0x1F8); } }
		public int _x1FC { get { return Read<int>(0x1FC); } }
		public int _x200 { get { return Read<int>(0x200); } }
		public int _x204 { get { return Read<int>(0x204); } }
		public int _x208 { get { return Read<int>(0x208); } }
		public int _x20C { get { return Read<int>(0x20C); } }
		public int _x210 { get { return Read<int>(0x210); } }
		public int _x214 { get { return Read<int>(0x214); } }
		public int _x218 { get { return Read<int>(0x218); } }
		public int _x21C { get { return Read<int>(0x21C); } }
		public int _x220 { get { return Read<int>(0x220); } }
		public int _x224 { get { return Read<int>(0x224); } }
		public int _x228 { get { return Read<int>(0x228); } }
		public int _x22C { get { return Read<int>(0x22C); } }
		public int x230_StructStart { get { return Read<int>(0x230); } }
		public int _x234 { get { return Read<int>(0x234); } }
		public int _x238 { get { return Read<int>(0x238); } }
		public int _x23C { get { return Read<int>(0x23C); } }
		public int _x240 { get { return Read<int>(0x240); } }
		public int _x244 { get { return Read<int>(0x244); } }
		public int _x248 { get { return Read<int>(0x248); } }
		public int _x24C { get { return Read<int>(0x24C); } }
		public int _x250 { get { return Read<int>(0x250); } }
		public int _x254 { get { return Read<int>(0x254); } }
		public int _x258 { get { return Read<int>(0x258); } }
		public int _x25C { get { return Read<int>(0x25C); } }
		public int _x260 { get { return Read<int>(0x260); } }
		public int _x264 { get { return Read<int>(0x264); } }
		public int _x268 { get { return Read<int>(0x268); } }
		public int _x26C { get { return Read<int>(0x26C); } }
		public int _x270 { get { return Read<int>(0x270); } }
		public int _x274 { get { return Read<int>(0x274); } }
		public int _x278 { get { return Read<int>(0x278); } }
		public int _x27C { get { return Read<int>(0x27C); } }
		public int _x280 { get { return Read<int>(0x280); } }
		public int _x284 { get { return Read<int>(0x284); } }
		public int _x288 { get { return Read<int>(0x288); } }
		public int _x28C { get { return Read<int>(0x28C); } }
		public int _x290 { get { return Read<int>(0x290); } }
		public int _x294 { get { return Read<int>(0x294); } }
		public int _x298 { get { return Read<int>(0x298); } }
		public int _x29C { get { return Read<int>(0x29C); } }
		public int _x2A0 { get { return Read<int>(0x2A0); } }
		public int _x2A4 { get { return Read<int>(0x2A4); } }
		public int _x2A8 { get { return Read<int>(0x2A8); } }
		public int _x2AC { get { return Read<int>(0x2AC); } }
		public int _x2B0 { get { return Read<int>(0x2B0); } }
		public int _x2B4 { get { return Read<int>(0x2B4); } }
		public int _x2B8 { get { return Read<int>(0x2B8); } }
		public int _x2BC { get { return Read<int>(0x2BC); } }
		public int _x2C0 { get { return Read<int>(0x2C0); } }
		public int _x2C4 { get { return Read<int>(0x2C4); } }
		public int _x2C8 { get { return Read<int>(0x2C8); } }
		public int _x2CC { get { return Read<int>(0x2CC); } }
		public int _x2D0 { get { return Read<int>(0x2D0); } }
		public int _x2D4 { get { return Read<int>(0x2D4); } }
		public int x2D8_StructStart { get { return Read<int>(0x2D8); } }
		public int x2DC_Ptr_28Bytes { get { return Read<int>(0x2DC); } }
		public int x2E0 { get { return Read<int>(0x2E0); } }
		public int _x2E4 { get { return Read<int>(0x2E4); } }
		public int x2E8 { get { return Read<int>(0x2E8); } }
		public int x2EC_StructStart { get { return Read<int>(0x2EC); } }
		public int _x2F0 { get { return Read<int>(0x2F0); } }
		public int x2F4 { get { return Read<int>(0x2F4); } }
		public int _x2F8 { get { return Read<int>(0x2F8); } }
		public int _x2FC { get { return Read<int>(0x2FC); } }
		public int _x300 { get { return Read<int>(0x300); } }
		public int _x304 { get { return Read<int>(0x304); } }
		public int _x308 { get { return Read<int>(0x308); } }
		public int _x30C { get { return Read<int>(0x30C); } }
		public int _x310 { get { return Read<int>(0x310); } }
		public int _x314 { get { return Read<int>(0x314); } }
		public int _x318 { get { return Read<int>(0x318); } }
		public int _x31C { get { return Read<int>(0x31C); } }
		public int _x320 { get { return Read<int>(0x320); } }
		public int _x324 { get { return Read<int>(0x324); } }
		public int _x328 { get { return Read<int>(0x328); } }
		public int _x32C { get { return Read<int>(0x32C); } }
		public int _x330 { get { return Read<int>(0x330); } }
		public int _x334 { get { return Read<int>(0x334); } }
		public int _x338 { get { return Read<int>(0x338); } }
		public int _x33C { get { return Read<int>(0x33C); } }
		public int _x340 { get { return Read<int>(0x340); } }
		public int _x344 { get { return Read<int>(0x344); } }
		public int _x348 { get { return Read<int>(0x348); } }
		public int _x34C { get { return Read<int>(0x34C); } }
		public int _x350 { get { return Read<int>(0x350); } }
		public int _x354 { get { return Read<int>(0x354); } }
		public int _x358 { get { return Read<int>(0x358); } }
		public int _x35C { get { return Read<int>(0x35C); } }
		public int _x360 { get { return Read<int>(0x360); } }
		public int _x364 { get { return Read<int>(0x364); } }
		public int _x368 { get { return Read<int>(0x368); } }
		public int _x36C { get { return Read<int>(0x36C); } }
		public int _x370 { get { return Read<int>(0x370); } }
		public int _x374 { get { return Read<int>(0x374); } }
		public int x378_Ptr_Platform { get { return Read<int>(0x378); } }
		public int x37C { get { return Read<int>(0x37C); } }
		public int x380 { get { return Read<int>(0x380); } }
		public int x384 { get { return Read<int>(0x384); } }
		public Map x388_MapEx { get { return Read<Map>(0x388); } }
		public Map x3F8_MapEx { get { return Read<Map>(0x3F8); } }
		public Map x468_MapEx { get { return Read<Map>(0x468); } }
		public Map x4D8_MapEx { get { return Read<Map>(0x4D8); } }
		public Map x548_MapEx { get { return Read<Map>(0x548); } }
		public int x5B8 { get { return Read<int>(0x5B8); } }
		public int _x5BC { get { return Read<int>(0x5BC); } }
		public Map x5C0_MapEx { get { return Read<Map>(0x5C0); } }
		public Map x630_MapEx { get { return Read<Map>(0x630); } }
		public Map x6A0_MapEx { get { return Read<Map>(0x6A0); } }
		public int x710 { get { return Read<int>(0x710); } }
		public int x714 { get { return Read<int>(0x714); } }
		public int x718 { get { return Read<int>(0x718); } }
		public Allocator x71C_Ptr_Allocator { get { return Dereference<Allocator>(0x71C); } }
		public Allocator x720_Allocator_10x40Bytes { get { return Read<Allocator>(0x720); } }
		public int x73C_One { get { return Read<int>(0x73C); } }
		public int x740_StructStart { get { return Read<int>(0x740); } }
		public int _x744 { get { return Read<int>(0x744); } }
		public int _x748 { get { return Read<int>(0x748); } }
		public int _x74C { get { return Read<int>(0x74C); } }
		public int _x750 { get { return Read<int>(0x750); } }
		public int _x754 { get { return Read<int>(0x754); } }
		public int _x758 { get { return Read<int>(0x758); } }
		public int _x75C { get { return Read<int>(0x75C); } }
		public int _x760 { get { return Read<int>(0x760); } }
		public int _x764 { get { return Read<int>(0x764); } }
		public int _x768 { get { return Read<int>(0x768); } }
		public int _x76C { get { return Read<int>(0x76C); } }
		public Map x770_MapEx { get { return Read<Map>(0x770); } }
		public int _x7E0 { get { return Read<int>(0x7E0); } }
		public int _x7E4 { get { return Read<int>(0x7E4); } }
		public Map x7E8_MapEx { get { return Read<Map>(0x7E8); } }
		public int x858 { get { return Read<int>(0x858); } }
		public int x85C { get { return Read<int>(0x85C); } }
		public int x860 { get { return Read<int>(0x860); } }
		public Allocator x864_Ptr_Allocator { get { return Dereference<Allocator>(0x864); } }
		public Allocator x868_Allocator_10x72Bytes { get { return Read<Allocator>(0x868); } }
		public int x884_One { get { return Read<int>(0x884); } }
		public int x888_StructStart { get { return Read<int>(0x888); } }
		public int _x88C { get { return Read<int>(0x88C); } }
		public int _x890 { get { return Read<int>(0x890); } }
		public int _x894 { get { return Read<int>(0x894); } }
		public int _x898 { get { return Read<int>(0x898); } }
		public int _x89C { get { return Read<int>(0x89C); } }
		public int _x8A0 { get { return Read<int>(0x8A0); } }
		public int _x8A4 { get { return Read<int>(0x8A4); } }
		public int _x8A8 { get { return Read<int>(0x8A8); } }
		public int _x8AC { get { return Read<int>(0x8AC); } }
		public int _x8B0 { get { return Read<int>(0x8B0); } }
		public int x8B4_StructStart { get { return Read<int>(0x8B4); } }
		public int _x8B8 { get { return Read<int>(0x8B8); } }
		public int _x8BC { get { return Read<int>(0x8BC); } }
		public int _x8C0 { get { return Read<int>(0x8C0); } }
		public int _x8C4 { get { return Read<int>(0x8C4); } }
		public int _x8C8 { get { return Read<int>(0x8C8); } }
		public int _x8CC { get { return Read<int>(0x8CC); } }
		public int _x8D0 { get { return Read<int>(0x8D0); } }
		public int _x8D4 { get { return Read<int>(0x8D4); } }
		public int _x8D8 { get { return Read<int>(0x8D8); } }
		public int _x8DC { get { return Read<int>(0x8DC); } }
		public int x8E0 { get { return Read<int>(0x8E0); } }
		public int x8E4 { get { return Read<int>(0x8E4); } }
		public int x8E8 { get { return Read<int>(0x8E8); } }
		public int x8EC { get { return Read<int>(0x8EC); } }
		public int x8F0 { get { return Read<int>(0x8F0); } }
		public int x8F4 { get { return Read<int>(0x8F4); } }
		public int x8F8 { get { return Read<int>(0x8F8); } }
		public int x8FC { get { return Read<int>(0x8FC); } }
		public int x900 { get { return Read<int>(0x900); } }
		public int x904 { get { return Read<int>(0x904); } }
		public int x908 { get { return Read<int>(0x908); } }
		public int x90C { get { return Read<int>(0x90C); } }
		public int x910 { get { return Read<int>(0x910); } }
		public int _x914 { get { return Read<int>(0x914); } }
		public Map x918_MapEx { get { return Read<Map>(0x918); } }
		public int x988 { get { return Read<int>(0x988); } }
		public int _x98C { get { return Read<int>(0x98C); } }
	}
}