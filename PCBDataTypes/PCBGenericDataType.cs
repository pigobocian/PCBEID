using System;

public interface IPCBGenericDataType
{
	public enum PCBDataType {dtNone, dtMemo, dtNumber, dtBool, dtDate };

	public abstract bool IsValid();

	public abstract string GetValue();

	public abstract void SetValue(string value);
	
	public abstract string ToString();
	
	public abstract PCBDataType GetType();

}

public class PCBGenericDataType : IPCBGenericDataType
{
	protected string value;

	public PCBGenericDataType()
	{
		value = "";
	}

	public PCBGenericDataType(string value)
	{
		this.value = value;
	}

	public virtual bool IsValid()
	{
		return false;
	}

	public virtual string GetValue()
	{
		return value;
	}

	public virtual void SetValue(string value)
	{
		this.value = value;
	}

	public virtual string ToString()
	{
		return value;
	}

	public virtual IPCBGenericDataType.PCBDataType GetType()
	{
		return IPCBGenericDataType.PCBDataType.dtNone;
	}

}

