using System;

public class PCBBool : PCBGenericDataType
{
    public PCBBool(int fieldPos) : base(fieldPos)
    {
    }

    public override bool IsValid()
	{
		return (value == "T") || (value == "N");
	}

	public override string ToString()
	{
		return value == "T" ? "T" : "N";
	}

}
