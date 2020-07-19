using System;

using R5T.Guide;


namespace R5T.Orgerben
{
    public class OrganizationRoleIdentity : TypedGuid
    {
        #region Static

        public static OrganizationRoleIdentity New()
        {
            var organizationRoleIdentity = new OrganizationRoleIdentity(Guid.NewGuid());
            return organizationRoleIdentity;
        }

        public static OrganizationRoleIdentity From(Guid value)
        {
            var organizationRoleIdentity = new OrganizationRoleIdentity(value);
            return organizationRoleIdentity;
        }

        #endregion


        public OrganizationRoleIdentity(Guid value)
        : base(value)
        {
        }
    }
}
