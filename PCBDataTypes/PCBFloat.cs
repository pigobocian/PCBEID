using System;

public class PCBFloat : PCBGenericDataType
{
    public PCBFloat(int fieldPos) : base(fieldPos)
    {
    }

    public override bool IsValid()
	{
		bool ret = false;
		if (value != null)
		{
			int charCount = 0;
			for (int i = 0; i < value.Length; i++)
			{
				if (char.IsNumber(value.ElementAt(i)) || value.ElementAt(i) == '.')
				{
					charCount++;
				}
			}
			ret = (charCount == value.Length) && (value.Length > 0);
		}
		return ret;
	}

	public override string ToString()
	{
		return IsValid() ? value : "0";
	}

	
}
