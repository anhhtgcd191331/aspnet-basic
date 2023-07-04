namespace server_website_movie.UnitOfWork;

public interface IUnitOfWork: IDisposable
{
    void SaveChange();
}
