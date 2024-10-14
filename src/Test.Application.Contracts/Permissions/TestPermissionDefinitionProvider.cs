using Test.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Test.Permissions;

public class TestPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TestPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(TestPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(TestPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(TestPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(TestPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TestPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TestResource>(name);
    }
}
