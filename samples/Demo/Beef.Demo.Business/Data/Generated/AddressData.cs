/*
 * This file is automatically generated; any changes will be lost. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Data.Database;
using Beef.Entities;
using Beef.Mapper;
using Beef.Mapper.Converters;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.Data
{
    /// <summary>
    /// Provides the Address data access.
    /// </summary>
    public partial class AddressData
    {

        /// <summary>
        /// Provides the <see cref="Address"/> entity and database property mapping.
        /// </summary>
        public partial class DbMapper : DatabaseMapper<Address, DbMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DbMapper"/> class.
            /// </summary>
            public DbMapper()
            {
                Property(s => s.Street);
                Property(s => s.City);
                AddStandardProperties();
                DbMapperCtor();
            }
            
            /// <summary>
            /// Enables the <see cref="DbMapper"/> constructor to be extended.
            /// </summary>
            partial void DbMapperCtor();
        }
    }
}