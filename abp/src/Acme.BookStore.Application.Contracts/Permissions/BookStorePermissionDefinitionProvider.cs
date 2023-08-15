using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions;

public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookStorePermissions.MyPermission1, L("Permission:MyPermission1"));

        var storePermission = myGroup.AddPermission(BookStorePermissions.Store.Default, L("Permission:Store"));
        storePermission.AddChild(BookStorePermissions.Store.Create, L("Permission:Create"));
        storePermission.AddChild(BookStorePermissions.Store.Update, L("Permission:Update"));
        storePermission.AddChild(BookStorePermissions.Store.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreResource>(name);
    }
}
