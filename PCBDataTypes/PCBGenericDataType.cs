﻿using System;

public interface IPCBGenericDataType
{
	public enum PCBDataType {dtNone, dtMemo, dtNumber, dtBool, dtDate };

	public abstract bool IsValid();

	public abstract string GetValue();

	public abstract void SetValue(string value);
	
	public abstract string ToString();
	
	public abstract PCBDataType GetType();

	public abstract void Clear();

}

public class PCBGenericDataType : IPCBGenericDataType
{
	protected string value;
	protected int fieldPos;

	public PCBGenericDataType(int fieldPos)
	{
		value = "";
        this.fieldPos = fieldPos;
    }

	public PCBGenericDataType(string value, int fieldPos)
	{
		this.value = value;
		this.fieldPos = fieldPos;
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

	public override string ToString()
	{
		return value;
	}

	public new virtual IPCBGenericDataType.PCBDataType GetType()
	{
		return IPCBGenericDataType.PCBDataType.dtNone;
	}

    public virtual void Clear()
    {
        value = "";
    }

}

