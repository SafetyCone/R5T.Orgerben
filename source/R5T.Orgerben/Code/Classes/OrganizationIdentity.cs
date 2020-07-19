using System;

using R5T.Guide;


namespace R5T.Orgerben
{
    public class OrganizationIdentity : TypedGuid
    {
        #region Static

        public static OrganizationIdentity New()
        {
            var organizationIdentity = new OrganizationIdentity(Guid.NewGuid());
            return organizationIdentity;
        }

        public static OrganizationIdentity From(Guid value)
        {
            var organizationIdentity = new OrganizationIdentity(value);
            return organizationIdentity;
        }

        #endregion



        public OrganizationIdentity(Guid value)
            : base(value)
        {
        }
    }
}
