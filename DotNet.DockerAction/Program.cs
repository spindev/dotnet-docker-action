
Console.WriteLine($"Hello from {args[0]}!");

var githubOutputFile = Environment.GetEnvironmentVariable("GITHUB_OUTPUT", EnvironmentVariableTarget.Process);

if (!string.IsNullOrWhiteSpace(githubOutputFile))
{
    using (var textWriter = new StreamWriter(githubOutputFile!, true, Encoding.UTF8))
    {
        textWriter.WriteLine($"example-output={args[0]}");
    }
}