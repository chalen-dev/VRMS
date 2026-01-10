namespace VRMS.Database.Seeders;

public interface ISeeder
{
    string Name { get; }
    void Run();
}