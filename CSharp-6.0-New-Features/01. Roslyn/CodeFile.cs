public class CodeFile<T>
{
    #region Fields
    private T value;
    #endregion

    #region Constructors
    public CodeFile(T value)
    {
        this.value = value;
    }
    #endregion

    #region Properties
    public T Type => this.value;
    #endregion
}
