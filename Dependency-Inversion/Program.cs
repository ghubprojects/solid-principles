#define GOOD_PRACTICE

#if BAD_PRACTICE
using Dependency_Inversion.BadPractice; 
{
    var developer = new Developer();
    developer.MakeChangesAndCommit("Initial commit");
}

#elif GOOD_PRACTICE
using Dependency_Inversion.GoodPractice; 
{
    var developer = new Developer(new GitVersionControlSystem());
    developer.MakeChangesAndCommit("Initial commit");
}
#endif