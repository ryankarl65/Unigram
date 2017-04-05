// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Help
{
	/// <summary>
	/// RCP method help.saveAppLog.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLHelpSaveAppLog : TLObject
	{
		public TLVector<TLInputAppEvent> Events { get; set; }

		public TLHelpSaveAppLog() { }
		public TLHelpSaveAppLog(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.HelpSaveAppLog; } }

		public override void Read(TLBinaryReader from)
		{
			Events = TLFactory.Read<TLVector<TLInputAppEvent>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x6F02F748);
			to.WriteObject(Events);
		}
	}
}