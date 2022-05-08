// See https://aka.ms/new-console-template for more information


public interface IDataStore<T> where T : EntityBase
{
    public void Create(T inputObject);
    public T Read(int id);
    public List<T> ReadList();
    public void Update(T inputObject);
    public void Delete(int id);
}

