namespace Dependency_Inversion.GoodPractice;

public class GitVersionControlSystem : IVersionControlSystem {
    public void Commit(string message) {
        Console.WriteLine($"Committing with message: {message}");
    }

    public void Push() {
        Console.WriteLine("Pushing to remote repository.");
    }

    public void Pull() {
        Console.WriteLine("Pulling from remote repository.");
    }
}