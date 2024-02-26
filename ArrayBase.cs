using System;
public abstract class ArrayBase : IDimension
{
    protected abstract void InputArray();
    protected abstract void RandomArray();
    protected virtual void CreateArray(bool userValues = false)
    {
        if (!userValues)
        {
            RandomArray();
        }
        else
        {
            InputArray();
        }
    }
    public abstract void Average();
    public abstract void Print();
    public abstract void Recreate(bool userValues = false);
}
