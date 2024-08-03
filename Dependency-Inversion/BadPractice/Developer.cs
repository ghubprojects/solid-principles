namespace Dependency_Inversion.BadPractice;

public class Developer {
    private readonly GitVersionControlSystem _versionControlSystem;

    public Developer() {
        _versionControlSystem = new GitVersionControlSystem();
    }

    public void MakeChangesAndCommit(string commitMessage) {
        // Some code changes
        _versionControlSystem.Commit(commitMessage);
        _versionControlSystem.Push();
    }
}
