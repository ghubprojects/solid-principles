namespace Dependency_Inversion.GoodPractice;

public class Developer(IVersionControlSystem versionControlSystem) {
    private readonly IVersionControlSystem _versionControlSystem = versionControlSystem;

    public void MakeChangesAndCommit(string commitMessage) {
        // Some code changes
        _versionControlSystem.Commit(commitMessage);
        _versionControlSystem.Push();
    }
}