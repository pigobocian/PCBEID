using System;

public class PCBDate : PCBGenericDataType
{
    public PCBDate(int fieldPos) : base(fieldPos)
    {
    }

    public override bool IsValid()
	{
		bool ret = false;
		if (value != null)
		{
			ret = (value.Length == 10) && 
				(value.ElementAt(4) == '-') && 
				(value.ElementAt(7) == '-') && 
				value.Substring(0, 4).All(char.IsNumber) && 
				value.Substring(5, 2).All(char.IsNumber) && 
				value.Substring(8, 2).All(char.IsNumber);
		}
		return ret;
	}

	public override string ToString()
	{
		return IsValid() ? value : "0";
	}

}
