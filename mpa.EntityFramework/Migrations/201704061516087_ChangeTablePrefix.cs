namespace mpa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTablePrefix : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AbpAuditLogs", newName: "tbAuditLogs");
            RenameTable(name: "dbo.AbpBackgroundJobs", newName: "tbBackgroundJobs");
            RenameTable(name: "dbo.AbpFeatures", newName: "tbFeatures");
            RenameTable(name: "dbo.AbpEditions", newName: "tbEditions");
            RenameTable(name: "dbo.AbpLanguages", newName: "tbLanguages");
            RenameTable(name: "dbo.AbpLanguageTexts", newName: "tbLanguageTexts");
            RenameTable(name: "dbo.AbpNotifications", newName: "tbNotifications");
            RenameTable(name: "dbo.AbpNotificationSubscriptions", newName: "tbNotificationSubscriptions");
            RenameTable(name: "dbo.AbpOrganizationUnits", newName: "tbOrganizationUnits");
            RenameTable(name: "dbo.AbpPermissions", newName: "tbPermissions");
            RenameTable(name: "dbo.AbpRoles", newName: "tbRoles");
            RenameTable(name: "dbo.AbpUsers", newName: "tbUsers");
            RenameTable(name: "dbo.AbpUserClaims", newName: "tbUserClaims");
            RenameTable(name: "dbo.AbpUserLogins", newName: "tbUserLogins");
            RenameTable(name: "dbo.AbpUserRoles", newName: "tbUserRoles");
            RenameTable(name: "dbo.AbpSettings", newName: "tbSettings");
            RenameTable(name: "dbo.AbpTenantNotifications", newName: "tbTenantNotifications");
            RenameTable(name: "dbo.AbpTenants", newName: "tbTenants");
            RenameTable(name: "dbo.AbpUserAccounts", newName: "tbUserAccounts");
            RenameTable(name: "dbo.AbpUserLoginAttempts", newName: "tbUserLoginAttempts");
            RenameTable(name: "dbo.AbpUserNotifications", newName: "tbUserNotifications");
            RenameTable(name: "dbo.AbpUserOrganizationUnits", newName: "tbUserOrganizationUnits");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tbUserOrganizationUnits", newName: "AbpUserOrganizationUnits");
            RenameTable(name: "dbo.tbUserNotifications", newName: "AbpUserNotifications");
            RenameTable(name: "dbo.tbUserLoginAttempts", newName: "AbpUserLoginAttempts");
            RenameTable(name: "dbo.tbUserAccounts", newName: "AbpUserAccounts");
            RenameTable(name: "dbo.tbTenants", newName: "AbpTenants");
            RenameTable(name: "dbo.tbTenantNotifications", newName: "AbpTenantNotifications");
            RenameTable(name: "dbo.tbSettings", newName: "AbpSettings");
            RenameTable(name: "dbo.tbUserRoles", newName: "AbpUserRoles");
            RenameTable(name: "dbo.tbUserLogins", newName: "AbpUserLogins");
            RenameTable(name: "dbo.tbUserClaims", newName: "AbpUserClaims");
            RenameTable(name: "dbo.tbUsers", newName: "AbpUsers");
            RenameTable(name: "dbo.tbRoles", newName: "AbpRoles");
            RenameTable(name: "dbo.tbPermissions", newName: "AbpPermissions");
            RenameTable(name: "dbo.tbOrganizationUnits", newName: "AbpOrganizationUnits");
            RenameTable(name: "dbo.tbNotificationSubscriptions", newName: "AbpNotificationSubscriptions");
            RenameTable(name: "dbo.tbNotifications", newName: "AbpNotifications");
            RenameTable(name: "dbo.tbLanguageTexts", newName: "AbpLanguageTexts");
            RenameTable(name: "dbo.tbLanguages", newName: "AbpLanguages");
            RenameTable(name: "dbo.tbEditions", newName: "AbpEditions");
            RenameTable(name: "dbo.tbFeatures", newName: "AbpFeatures");
            RenameTable(name: "dbo.tbBackgroundJobs", newName: "AbpBackgroundJobs");
            RenameTable(name: "dbo.tbAuditLogs", newName: "AbpAuditLogs");
        }
    }
}
