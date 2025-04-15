using System;

public class PCBMemo : PCBGenericDataType
{
	public override bool IsValid()
	{
		return true;
	}

	public override void SetValue(string value)
	{
		string buf = value.Replace("\r\n", "^");
		this.value = buf;
	}

	public string getStandardString()
	{
		string buf = value.Replace("^", "\r\n");
		return buf;
	}
}
