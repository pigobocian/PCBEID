using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public interface IGenericFile
{
    public abstract void SetFileName(string fileName);
    public abstract void AddLine(string line);
    public abstract int GetLineCount();
    public abstract string GetLine(int index);
    public abstract bool SaveToFile();
}

public class GenericFile : IGenericFile
{
    private string fileName;
    private List<string> lines;

    public GenericFile()
    {
        lines = new List<string>();
    }

    public virtual void SetFileName(string fileName)
    {
        this.fileName = fileName;
    }

    public virtual void AddLine(string line)
    {
        lines.Add(line);
    }

    public virtual int GetLineCount()
    {
        return lines.Count;
    }

    public virtual string GetLine(int index)
    {
        if (index < 0 || index >= lines.Count)
        {
            throw new ArgumentOutOfRangeException("index");
        }
        return lines[index];
    }

    public virtual bool SaveToFile()
    {
        try
        {
            System.IO.File.WriteAllLines(fileName, lines);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving file: " + ex.Message);
            return false;
        }
    }
}