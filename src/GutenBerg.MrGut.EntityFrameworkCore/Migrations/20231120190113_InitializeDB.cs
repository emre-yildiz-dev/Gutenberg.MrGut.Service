using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GutenBerg.MrGut.Migrations
{
    /// <inheritdoc />
    public partial class InitializeDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpDynamicEntityProperties_AbpDynamicProperties_DynamicPropertyId",
                table: "AbpDynamicEntityProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpDynamicEntityPropertyValues_AbpDynamicEntityProperties_DynamicEntityPropertyId",
                table: "AbpDynamicEntityPropertyValues");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpDynamicPropertyValues_AbpDynamicProperties_DynamicPropertyId",
                table: "AbpDynamicPropertyValues");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId",
                table: "AbpEntityChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpFeatures_AbpEditions_EditionId",
                table: "AbpFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpPermissions_AbpRoles_RoleId",
                table: "AbpPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpPermissions_AbpUsers_UserId",
                table: "AbpPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpSettings_AbpUsers_UserId",
                table: "AbpSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpEditions_EditionId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpWebhookSendAttempts_AbpWebhookEvents_WebhookEventId",
                table: "AbpWebhookSendAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpWebhookSubscriptions",
                table: "AbpWebhookSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpWebhookSendAttempts",
                table: "AbpWebhookSendAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpWebhookEvents",
                table: "AbpWebhookEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserNotifications",
                table: "AbpUserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLoginAttempts",
                table: "AbpUserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserAccounts",
                table: "AbpUserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenantNotifications",
                table: "AbpTenantNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpOrganizationUnitRoles",
                table: "AbpOrganizationUnitRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotifications",
                table: "AbpNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLanguageTexts",
                table: "AbpLanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLanguages",
                table: "AbpLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpFeatures",
                table: "AbpFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityPropertyChanges",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityChangeSets",
                table: "AbpEntityChangeSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityChanges",
                table: "AbpEntityChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEditions",
                table: "AbpEditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpDynamicPropertyValues",
                table: "AbpDynamicPropertyValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpDynamicProperties",
                table: "AbpDynamicProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpDynamicEntityPropertyValues",
                table: "AbpDynamicEntityPropertyValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpDynamicEntityProperties",
                table: "AbpDynamicEntityProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs");

            migrationBuilder.RenameTable(
                name: "AbpWebhookSubscriptions",
                newName: "WebhookSubscriptions");

            migrationBuilder.RenameTable(
                name: "AbpWebhookSendAttempts",
                newName: "WebhookSendAttempts");

            migrationBuilder.RenameTable(
                name: "AbpWebhookEvents",
                newName: "WebhookEvents");

            migrationBuilder.RenameTable(
                name: "AbpUserTokens",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "AbpUsers",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "AbpUserRoles",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "AbpUserOrganizationUnits",
                newName: "UserOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "AbpUserNotifications",
                newName: "UserNotifications");

            migrationBuilder.RenameTable(
                name: "AbpUserLogins",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "AbpUserLoginAttempts",
                newName: "UserLoginAttempts");

            migrationBuilder.RenameTable(
                name: "AbpUserClaims",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "AbpUserAccounts",
                newName: "UserAccounts");

            migrationBuilder.RenameTable(
                name: "AbpTenants",
                newName: "Tenants");

            migrationBuilder.RenameTable(
                name: "AbpTenantNotifications",
                newName: "TenantNotifications");

            migrationBuilder.RenameTable(
                name: "AbpSettings",
                newName: "Settings");

            migrationBuilder.RenameTable(
                name: "AbpRoles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "AbpRoleClaims",
                newName: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "AbpPermissions",
                newName: "Permissions");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnits",
                newName: "OrganizationUnits");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnitRoles",
                newName: "OrganizationUnitRoles");

            migrationBuilder.RenameTable(
                name: "AbpNotificationSubscriptions",
                newName: "NotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "AbpNotifications",
                newName: "Notifications");

            migrationBuilder.RenameTable(
                name: "AbpLanguageTexts",
                newName: "LanguageTexts");

            migrationBuilder.RenameTable(
                name: "AbpLanguages",
                newName: "Languages");

            migrationBuilder.RenameTable(
                name: "AbpFeatures",
                newName: "Features");

            migrationBuilder.RenameTable(
                name: "AbpEntityPropertyChanges",
                newName: "EntityPropertyChanges");

            migrationBuilder.RenameTable(
                name: "AbpEntityChangeSets",
                newName: "EntityChangeSets");

            migrationBuilder.RenameTable(
                name: "AbpEntityChanges",
                newName: "EntityChanges");

            migrationBuilder.RenameTable(
                name: "AbpEditions",
                newName: "Editions");

            migrationBuilder.RenameTable(
                name: "AbpDynamicPropertyValues",
                newName: "DynamicPropertyValues");

            migrationBuilder.RenameTable(
                name: "AbpDynamicProperties",
                newName: "DynamicProperties");

            migrationBuilder.RenameTable(
                name: "AbpDynamicEntityPropertyValues",
                newName: "DynamicEntityPropertyValues");

            migrationBuilder.RenameTable(
                name: "AbpDynamicEntityProperties",
                newName: "DynamicEntityProperties");

            migrationBuilder.RenameTable(
                name: "AbpBackgroundJobs",
                newName: "BackgroundJobs");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogs",
                newName: "AuditLogs");

            migrationBuilder.RenameIndex(
                name: "IX_AbpWebhookSendAttempts_WebhookEventId",
                table: "WebhookSendAttempts",
                newName: "IX_WebhookSendAttempts_WebhookEventId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserTokens_UserId",
                table: "UserTokens",
                newName: "IX_UserTokens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserTokens_TenantId_UserId",
                table: "UserTokens",
                newName: "IX_UserTokens_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_TenantId_NormalizedUserName",
                table: "Users",
                newName: "IX_Users_TenantId_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_TenantId_NormalizedEmailAddress",
                table: "Users",
                newName: "IX_Users_TenantId_NormalizedEmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_LastModifierUserId",
                table: "Users",
                newName: "IX_Users_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_DeleterUserId",
                table: "Users",
                newName: "IX_Users_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_CreatorUserId",
                table: "Users",
                newName: "IX_Users_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_UserId",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_TenantId_UserId",
                table: "UserRoles",
                newName: "IX_UserRoles_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_TenantId_RoleId",
                table: "UserRoles",
                newName: "IX_UserRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_UserId",
                table: "UserOrganizationUnits",
                newName: "IX_UserOrganizationUnits_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId",
                table: "UserOrganizationUnits",
                newName: "IX_UserOrganizationUnits_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserNotifications_UserId_State_CreationTime",
                table: "UserNotifications",
                newName: "IX_UserNotifications_UserId_State_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_UserId",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_TenantId_UserId",
                table: "UserLogins",
                newName: "IX_UserLogins_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey",
                table: "UserLogins",
                newName: "IX_UserLogins_TenantId_LoginProvider_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_ProviderKey_TenantId",
                table: "UserLogins",
                newName: "IX_UserLogins_ProviderKey_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginAttempts_UserId_TenantId",
                table: "UserLoginAttempts",
                newName: "IX_UserLoginAttempts_UserId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "UserLoginAttempts",
                newName: "IX_UserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserClaims_UserId",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserClaims_TenantId_ClaimType",
                table: "UserClaims",
                newName: "IX_UserClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_UserName",
                table: "UserAccounts",
                newName: "IX_UserAccounts_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_UserName",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_UserId",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_EmailAddress",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_EmailAddress",
                table: "UserAccounts",
                newName: "IX_UserAccounts_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_TenancyName",
                table: "Tenants",
                newName: "IX_Tenants_TenancyName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_LastModifierUserId",
                table: "Tenants",
                newName: "IX_Tenants_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_EditionId",
                table: "Tenants",
                newName: "IX_Tenants_EditionId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_DeleterUserId",
                table: "Tenants",
                newName: "IX_Tenants_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_CreatorUserId",
                table: "Tenants",
                newName: "IX_Tenants_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenantNotifications_TenantId",
                table: "TenantNotifications",
                newName: "IX_TenantNotifications_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettings_UserId",
                table: "Settings",
                newName: "IX_Settings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettings_TenantId_Name_UserId",
                table: "Settings",
                newName: "IX_Settings_TenantId_Name_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_TenantId_NormalizedName",
                table: "Roles",
                newName: "IX_Roles_TenantId_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_LastModifierUserId",
                table: "Roles",
                newName: "IX_Roles_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_DeleterUserId",
                table: "Roles",
                newName: "IX_Roles_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_CreatorUserId",
                table: "Roles",
                newName: "IX_Roles_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoleClaims_TenantId_ClaimType",
                table: "RoleClaims",
                newName: "IX_RoleClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoleClaims_RoleId",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_UserId",
                table: "Permissions",
                newName: "IX_Permissions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_TenantId_Name",
                table: "Permissions",
                newName: "IX_Permissions_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_RoleId",
                table: "Permissions",
                newName: "IX_Permissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                table: "OrganizationUnits",
                newName: "IX_OrganizationUnits_TenantId_Code");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                table: "OrganizationUnits",
                newName: "IX_OrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnitRoles_TenantId_RoleId",
                table: "OrganizationUnitRoles",
                newName: "IX_OrganizationUnitRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnitRoles_TenantId_OrganizationUnitId",
                table: "OrganizationUnitRoles",
                newName: "IX_OrganizationUnitRoles_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "NotificationSubscriptions",
                newName: "IX_NotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "NotificationSubscriptions",
                newName: "IX_NotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key",
                table: "LanguageTexts",
                newName: "IX_LanguageTexts_TenantId_Source_LanguageName_Key");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLanguages_TenantId_Name",
                table: "Languages",
                newName: "IX_Languages_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatures_TenantId_Name",
                table: "Features",
                newName: "IX_Features_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatures_EditionId_Name",
                table: "Features",
                newName: "IX_Features_EditionId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId",
                table: "EntityPropertyChanges",
                newName: "IX_EntityPropertyChanges_EntityChangeId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_UserId",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_Reason",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_Reason");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_CreationTime",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChanges_EntityTypeFullName_EntityId",
                table: "EntityChanges",
                newName: "IX_EntityChanges_EntityTypeFullName_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChanges_EntityChangeSetId",
                table: "EntityChanges",
                newName: "IX_EntityChanges_EntityChangeSetId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDynamicPropertyValues_DynamicPropertyId",
                table: "DynamicPropertyValues",
                newName: "IX_DynamicPropertyValues_DynamicPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDynamicProperties_PropertyName_TenantId",
                table: "DynamicProperties",
                newName: "IX_DynamicProperties_PropertyName_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDynamicEntityPropertyValues_DynamicEntityPropertyId",
                table: "DynamicEntityPropertyValues",
                newName: "IX_DynamicEntityPropertyValues_DynamicEntityPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId",
                table: "DynamicEntityProperties",
                newName: "IX_DynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpDynamicEntityProperties_DynamicPropertyId",
                table: "DynamicEntityProperties",
                newName: "IX_DynamicEntityProperties_DynamicPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                table: "BackgroundJobs",
                newName: "IX_BackgroundJobs_IsAbandoned_NextTryTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionDuration",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_ExecutionDuration");

            migrationBuilder.AddColumn<string>(
                name: "TargetNotifiers",
                table: "NotificationSubscriptions",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebhookSubscriptions",
                table: "WebhookSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebhookSendAttempts",
                table: "WebhookSendAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WebhookEvents",
                table: "WebhookEvents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrganizationUnits",
                table: "UserOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserNotifications",
                table: "UserNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLoginAttempts",
                table: "UserLoginAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tenants",
                table: "Tenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TenantNotifications",
                table: "TenantNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settings",
                table: "Settings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizationUnits",
                table: "OrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizationUnitRoles",
                table: "OrganizationUnitRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationSubscriptions",
                table: "NotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageTexts",
                table: "LanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Features",
                table: "Features",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityPropertyChanges",
                table: "EntityPropertyChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityChangeSets",
                table: "EntityChangeSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityChanges",
                table: "EntityChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editions",
                table: "Editions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DynamicPropertyValues",
                table: "DynamicPropertyValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DynamicProperties",
                table: "DynamicProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DynamicEntityPropertyValues",
                table: "DynamicEntityPropertyValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DynamicEntityProperties",
                table: "DynamicEntityProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackgroundJobs",
                table: "BackgroundJobs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditLogs",
                table: "AuditLogs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthYear = table.Column<int>(type: "int", nullable: true),
                    DeathYear = table.Column<int>(type: "int", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationYear = table.Column<int>(type: "int", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicEntityProperties_DynamicProperties_DynamicPropertyId",
                table: "DynamicEntityProperties",
                column: "DynamicPropertyId",
                principalTable: "DynamicProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicEntityPropertyValues_DynamicEntityProperties_DynamicEntityPropertyId",
                table: "DynamicEntityPropertyValues",
                column: "DynamicEntityPropertyId",
                principalTable: "DynamicEntityProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicPropertyValues_DynamicProperties_DynamicPropertyId",
                table: "DynamicPropertyValues",
                column: "DynamicPropertyId",
                principalTable: "DynamicProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityChanges_EntityChangeSets_EntityChangeSetId",
                table: "EntityChanges",
                column: "EntityChangeSetId",
                principalTable: "EntityChangeSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityPropertyChanges_EntityChanges_EntityChangeId",
                table: "EntityPropertyChanges",
                column: "EntityChangeId",
                principalTable: "EntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Editions_EditionId",
                table: "Features",
                column: "EditionId",
                principalTable: "Editions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationUnits_OrganizationUnits_ParentId",
                table: "OrganizationUnits",
                column: "ParentId",
                principalTable: "OrganizationUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Users_UserId",
                table: "Permissions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_CreatorUserId",
                table: "Roles",
                column: "CreatorUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_DeleterUserId",
                table: "Roles",
                column: "DeleterUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_LastModifierUserId",
                table: "Roles",
                column: "LastModifierUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_Users_UserId",
                table: "Settings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Editions_EditionId",
                table: "Tenants",
                column: "EditionId",
                principalTable: "Editions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_CreatorUserId",
                table: "Tenants",
                column: "CreatorUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_DeleterUserId",
                table: "Tenants",
                column: "DeleterUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_LastModifierUserId",
                table: "Tenants",
                column: "LastModifierUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_CreatorUserId",
                table: "Users",
                column: "CreatorUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_DeleterUserId",
                table: "Users",
                column: "DeleterUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_LastModifierUserId",
                table: "Users",
                column: "LastModifierUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WebhookSendAttempts_WebhookEvents_WebhookEventId",
                table: "WebhookSendAttempts",
                column: "WebhookEventId",
                principalTable: "WebhookEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DynamicEntityProperties_DynamicProperties_DynamicPropertyId",
                table: "DynamicEntityProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_DynamicEntityPropertyValues_DynamicEntityProperties_DynamicEntityPropertyId",
                table: "DynamicEntityPropertyValues");

            migrationBuilder.DropForeignKey(
                name: "FK_DynamicPropertyValues_DynamicProperties_DynamicPropertyId",
                table: "DynamicPropertyValues");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityChanges_EntityChangeSets_EntityChangeSetId",
                table: "EntityChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityPropertyChanges_EntityChanges_EntityChangeId",
                table: "EntityPropertyChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Editions_EditionId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationUnits_OrganizationUnits_ParentId",
                table: "OrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Users_UserId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_CreatorUserId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_DeleterUserId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_LastModifierUserId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Settings_Users_UserId",
                table: "Settings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Editions_EditionId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_CreatorUserId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_DeleterUserId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_LastModifierUserId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreatorUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_DeleterUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_LastModifierUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_WebhookSendAttempts_WebhookEvents_WebhookEventId",
                table: "WebhookSendAttempts");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebhookSubscriptions",
                table: "WebhookSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebhookSendAttempts",
                table: "WebhookSendAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WebhookEvents",
                table: "WebhookEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrganizationUnits",
                table: "UserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserNotifications",
                table: "UserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLoginAttempts",
                table: "UserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tenants",
                table: "Tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TenantNotifications",
                table: "TenantNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settings",
                table: "Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizationUnits",
                table: "OrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizationUnitRoles",
                table: "OrganizationUnitRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationSubscriptions",
                table: "NotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageTexts",
                table: "LanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Features",
                table: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityPropertyChanges",
                table: "EntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityChangeSets",
                table: "EntityChangeSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityChanges",
                table: "EntityChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editions",
                table: "Editions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DynamicPropertyValues",
                table: "DynamicPropertyValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DynamicProperties",
                table: "DynamicProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DynamicEntityPropertyValues",
                table: "DynamicEntityPropertyValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DynamicEntityProperties",
                table: "DynamicEntityProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackgroundJobs",
                table: "BackgroundJobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditLogs",
                table: "AuditLogs");

            migrationBuilder.DropColumn(
                name: "TargetNotifiers",
                table: "NotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "WebhookSubscriptions",
                newName: "AbpWebhookSubscriptions");

            migrationBuilder.RenameTable(
                name: "WebhookSendAttempts",
                newName: "AbpWebhookSendAttempts");

            migrationBuilder.RenameTable(
                name: "WebhookEvents",
                newName: "AbpWebhookEvents");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "AbpUserTokens");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AbpUsers");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "AbpUserRoles");

            migrationBuilder.RenameTable(
                name: "UserOrganizationUnits",
                newName: "AbpUserOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "UserNotifications",
                newName: "AbpUserNotifications");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "AbpUserLogins");

            migrationBuilder.RenameTable(
                name: "UserLoginAttempts",
                newName: "AbpUserLoginAttempts");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "AbpUserClaims");

            migrationBuilder.RenameTable(
                name: "UserAccounts",
                newName: "AbpUserAccounts");

            migrationBuilder.RenameTable(
                name: "Tenants",
                newName: "AbpTenants");

            migrationBuilder.RenameTable(
                name: "TenantNotifications",
                newName: "AbpTenantNotifications");

            migrationBuilder.RenameTable(
                name: "Settings",
                newName: "AbpSettings");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AbpRoles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "AbpRoleClaims");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "AbpPermissions");

            migrationBuilder.RenameTable(
                name: "OrganizationUnits",
                newName: "AbpOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "OrganizationUnitRoles",
                newName: "AbpOrganizationUnitRoles");

            migrationBuilder.RenameTable(
                name: "NotificationSubscriptions",
                newName: "AbpNotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "AbpNotifications");

            migrationBuilder.RenameTable(
                name: "LanguageTexts",
                newName: "AbpLanguageTexts");

            migrationBuilder.RenameTable(
                name: "Languages",
                newName: "AbpLanguages");

            migrationBuilder.RenameTable(
                name: "Features",
                newName: "AbpFeatures");

            migrationBuilder.RenameTable(
                name: "EntityPropertyChanges",
                newName: "AbpEntityPropertyChanges");

            migrationBuilder.RenameTable(
                name: "EntityChangeSets",
                newName: "AbpEntityChangeSets");

            migrationBuilder.RenameTable(
                name: "EntityChanges",
                newName: "AbpEntityChanges");

            migrationBuilder.RenameTable(
                name: "Editions",
                newName: "AbpEditions");

            migrationBuilder.RenameTable(
                name: "DynamicPropertyValues",
                newName: "AbpDynamicPropertyValues");

            migrationBuilder.RenameTable(
                name: "DynamicProperties",
                newName: "AbpDynamicProperties");

            migrationBuilder.RenameTable(
                name: "DynamicEntityPropertyValues",
                newName: "AbpDynamicEntityPropertyValues");

            migrationBuilder.RenameTable(
                name: "DynamicEntityProperties",
                newName: "AbpDynamicEntityProperties");

            migrationBuilder.RenameTable(
                name: "BackgroundJobs",
                newName: "AbpBackgroundJobs");

            migrationBuilder.RenameTable(
                name: "AuditLogs",
                newName: "AbpAuditLogs");

            migrationBuilder.RenameIndex(
                name: "IX_WebhookSendAttempts_WebhookEventId",
                table: "AbpWebhookSendAttempts",
                newName: "IX_AbpWebhookSendAttempts_WebhookEventId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTokens_UserId",
                table: "AbpUserTokens",
                newName: "IX_AbpUserTokens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTokens_TenantId_UserId",
                table: "AbpUserTokens",
                newName: "IX_AbpUserTokens_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TenantId_NormalizedUserName",
                table: "AbpUsers",
                newName: "IX_AbpUsers_TenantId_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TenantId_NormalizedEmailAddress",
                table: "AbpUsers",
                newName: "IX_AbpUsers_TenantId_NormalizedEmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Users_LastModifierUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DeleterUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CreatorUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_TenantId_UserId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_TenantId_RoleId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganizationUnits_TenantId_UserId",
                table: "AbpUserOrganizationUnits",
                newName: "IX_AbpUserOrganizationUnits_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganizationUnits_TenantId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                newName: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_UserNotifications_UserId_State_CreationTime",
                table: "AbpUserNotifications",
                newName: "IX_AbpUserNotifications_UserId_State_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_TenantId_UserId",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_TenantId_LoginProvider_ProviderKey",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_ProviderKey_TenantId",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_ProviderKey_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLoginAttempts_UserId_TenantId",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginAttempts_UserId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "AbpUserClaims",
                newName: "IX_AbpUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_TenantId_ClaimType",
                table: "AbpUserClaims",
                newName: "IX_AbpUserClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_UserName",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_UserName",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_UserId",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_EmailAddress",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_EmailAddress",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_TenancyName",
                table: "AbpTenants",
                newName: "IX_AbpTenants_TenancyName");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_LastModifierUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_EditionId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_EditionId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_DeleterUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_CreatorUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TenantNotifications_TenantId",
                table: "AbpTenantNotifications",
                newName: "IX_AbpTenantNotifications_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_Settings_UserId",
                table: "AbpSettings",
                newName: "IX_AbpSettings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Settings_TenantId_Name_UserId",
                table: "AbpSettings",
                newName: "IX_AbpSettings_TenantId_Name_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_TenantId_NormalizedName",
                table: "AbpRoles",
                newName: "IX_AbpRoles_TenantId_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_LastModifierUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_DeleterUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_CreatorUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_TenantId_ClaimType",
                table: "AbpRoleClaims",
                newName: "IX_AbpRoleClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AbpRoleClaims",
                newName: "IX_AbpRoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_UserId",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_TenantId_Name",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_RoleId",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_TenantId_Code");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnitRoles_TenantId_RoleId",
                table: "AbpOrganizationUnitRoles",
                newName: "IX_AbpOrganizationUnitRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnitRoles_TenantId_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles",
                newName: "IX_AbpOrganizationUnitRoles_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageTexts_TenantId_Source_LanguageName_Key",
                table: "AbpLanguageTexts",
                newName: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_TenantId_Name",
                table: "AbpLanguages",
                newName: "IX_AbpLanguages_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Features_TenantId_Name",
                table: "AbpFeatures",
                newName: "IX_AbpFeatures_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Features_EditionId_Name",
                table: "AbpFeatures",
                newName: "IX_AbpFeatures_EditionId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_EntityPropertyChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                newName: "IX_AbpEntityPropertyChanges_EntityChangeId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_UserId",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_Reason",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_Reason");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_CreationTime",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChanges_EntityTypeFullName_EntityId",
                table: "AbpEntityChanges",
                newName: "IX_AbpEntityChanges_EntityTypeFullName_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChanges_EntityChangeSetId",
                table: "AbpEntityChanges",
                newName: "IX_AbpEntityChanges_EntityChangeSetId");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicPropertyValues_DynamicPropertyId",
                table: "AbpDynamicPropertyValues",
                newName: "IX_AbpDynamicPropertyValues_DynamicPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicProperties_PropertyName_TenantId",
                table: "AbpDynamicProperties",
                newName: "IX_AbpDynamicProperties_PropertyName_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicEntityPropertyValues_DynamicEntityPropertyId",
                table: "AbpDynamicEntityPropertyValues",
                newName: "IX_AbpDynamicEntityPropertyValues_DynamicEntityPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId",
                table: "AbpDynamicEntityProperties",
                newName: "IX_AbpDynamicEntityProperties_EntityFullName_DynamicPropertyId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicEntityProperties_DynamicPropertyId",
                table: "AbpDynamicEntityProperties",
                newName: "IX_AbpDynamicEntityProperties_DynamicPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_BackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs",
                newName: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_UserId",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_ExecutionDuration",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_ExecutionDuration");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpWebhookSubscriptions",
                table: "AbpWebhookSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpWebhookSendAttempts",
                table: "AbpWebhookSendAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpWebhookEvents",
                table: "AbpWebhookEvents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserNotifications",
                table: "AbpUserNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLoginAttempts",
                table: "AbpUserLoginAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserAccounts",
                table: "AbpUserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenantNotifications",
                table: "AbpTenantNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpOrganizationUnitRoles",
                table: "AbpOrganizationUnitRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotifications",
                table: "AbpNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLanguageTexts",
                table: "AbpLanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLanguages",
                table: "AbpLanguages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpFeatures",
                table: "AbpFeatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityPropertyChanges",
                table: "AbpEntityPropertyChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityChangeSets",
                table: "AbpEntityChangeSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityChanges",
                table: "AbpEntityChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEditions",
                table: "AbpEditions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpDynamicPropertyValues",
                table: "AbpDynamicPropertyValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpDynamicProperties",
                table: "AbpDynamicProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpDynamicEntityPropertyValues",
                table: "AbpDynamicEntityPropertyValues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpDynamicEntityProperties",
                table: "AbpDynamicEntityProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpDynamicEntityProperties_AbpDynamicProperties_DynamicPropertyId",
                table: "AbpDynamicEntityProperties",
                column: "DynamicPropertyId",
                principalTable: "AbpDynamicProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpDynamicEntityPropertyValues_AbpDynamicEntityProperties_DynamicEntityPropertyId",
                table: "AbpDynamicEntityPropertyValues",
                column: "DynamicEntityPropertyId",
                principalTable: "AbpDynamicEntityProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpDynamicPropertyValues_AbpDynamicProperties_DynamicPropertyId",
                table: "AbpDynamicPropertyValues",
                column: "DynamicPropertyId",
                principalTable: "AbpDynamicProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId",
                table: "AbpEntityChanges",
                column: "EntityChangeSetId",
                principalTable: "AbpEntityChangeSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId",
                principalTable: "AbpEntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpFeatures_AbpEditions_EditionId",
                table: "AbpFeatures",
                column: "EditionId",
                principalTable: "AbpEditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpPermissions_AbpRoles_RoleId",
                table: "AbpPermissions",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpPermissions_AbpUsers_UserId",
                table: "AbpPermissions",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                table: "AbpRoles",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                table: "AbpRoles",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                table: "AbpRoles",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpSettings_AbpUsers_UserId",
                table: "AbpSettings",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpEditions_EditionId",
                table: "AbpTenants",
                column: "EditionId",
                principalTable: "AbpEditions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                table: "AbpTenants",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                table: "AbpTenants",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                table: "AbpTenants",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                table: "AbpUsers",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                table: "AbpUsers",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                table: "AbpUsers",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpWebhookSendAttempts_AbpWebhookEvents_WebhookEventId",
                table: "AbpWebhookSendAttempts",
                column: "WebhookEventId",
                principalTable: "AbpWebhookEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
