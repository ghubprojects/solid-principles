namespace Dependency_Inversion.GoodPractice;

public interface IVersionControlSystem {
    void Commit(string message);
    void Push();
    void Pull();
}
