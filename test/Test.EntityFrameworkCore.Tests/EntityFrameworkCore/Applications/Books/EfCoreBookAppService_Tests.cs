using Test.Books;
using Xunit;

namespace Test.EntityFrameworkCore.Applications.Books;

[Collection(TestTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<TestEntityFrameworkCoreTestModule>
{

}