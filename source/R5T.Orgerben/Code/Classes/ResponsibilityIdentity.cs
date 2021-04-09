using System;

using R5T.Guide;


namespace R5T.Orgerben
{
    public class ResponsibilityIdentity : TypedGuid
    {
        #region Static

        public static ResponsibilityIdentity New()
        {
            var responsibilityIdentity = new ResponsibilityIdentity(Guid.NewGuid());
            return responsibilityIdentity;
        }

        public static ResponsibilityIdentity From(Guid value)
        {
            var responsibilityIdentity = new ResponsibilityIdentity(value);
            return responsibilityIdentity;
        }

        #endregion



        public ResponsibilityIdentity(Guid value)
            : base(value)
        {
        }
    }
}
