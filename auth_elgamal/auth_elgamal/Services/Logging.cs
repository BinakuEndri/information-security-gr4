namespace auth_elgamal.Services;

public interface IAuthLogger
{
    void Info(string message);
    void Warn(string message);
    void Error(string message);
}

public sealed class NoopAuthLogger : IAuthLogger
{
    public void Info(string message) { }
    public void Warn(string message) { }
    public void Error(string message) { }
}

public sealed class ConsoleAuthLogger : IAuthLogger
{
    private static string Ts() => DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff 'UTC'");

    public void Info(string message) => Console.WriteLine($"[INFO]  {Ts()}  {message}");
    public void Warn(string message) => Console.WriteLine($"[WARN]  {Ts()}  {message}");
    public void Error(string message) => Console.WriteLine($"[ERROR] {Ts()}  {message}");
}
