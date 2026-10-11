namespace GenericClasses;

public class Sample<T>
{
    private T field;

    public T Field
    {
        get { return field; }
        set { field = value; }
    }

    public string ShowInfo()
    {
        return $"The value for field is {field} and it is of type {field.GetType()}";
    }
}