using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace CategoryManagement.Categories
{
   public class Category : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; protected set; }
        public string CategoryName { get; set; }
        protected Category()
        {

        }
        public Category(Guid? tenantId,string categoryName)
        {
            TenantId = tenantId;
            CategoryName = categoryName;
        }
    }
}
