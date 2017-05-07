public class CodeFile<T>
{
    #region Fields
    private readonly T value;
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
