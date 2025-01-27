/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Beef;
using Beef.AspNetCore.WebApi;
using Beef.Entities;
using Cdr.Banking.Business;
using Cdr.Banking.Common.Entities;
using RefDataNamespace = Cdr.Banking.Common.Entities;

namespace Cdr.Banking.Api.Controllers
{
    /// <summary>
    /// Provides the <see cref="Account"/> Web API functionality.
    /// </summary>
    [Route("api/v1/banking/accounts")]
    public partial class AccountController : ControllerBase
    {
        private readonly IAccountManager _manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="manager">The <see cref="IAccountManager"/>.</param>
        public AccountController(IAccountManager manager)
            { _manager = Check.NotNull(manager, nameof(manager)); AccountControllerCtor(); }

        partial void AccountControllerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Get all accounts.
        /// </summary>
        /// <param name="productCategory">The Product Category (see <see cref="RefDataNamespace.ProductCategory"/>).</param>
        /// <param name="openStatus">The Open Status (see <see cref="RefDataNamespace.OpenStatus"/>).</param>
        /// <param name="isOwned">Indicates whether Is Owned.</param>
        /// <returns>The <see cref="AccountCollection"/></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(AccountCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult GetAccounts([FromQuery(Name = "product-category")] string? productCategory = default, [FromQuery(Name = "open-status")] string? openStatus = default, [FromQuery(Name = "is-owned")] bool? isOwned = default)
        {
            var args = new AccountArgs { ProductCategorySid = productCategory, OpenStatusSid = openStatus, IsOwned = isOwned };
            return new WebApiGet<AccountCollectionResult, AccountCollection, Account>(this, () => _manager.GetAccountsAsync(args, WebApiQueryString.CreatePagingArgs(this)),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Get <see cref="AccountDetail"/>.
        /// </summary>
        /// <param name="accountId">The <see cref="Account"/> identifier.</param>
        /// <returns>The selected <see cref="AccountDetail"/> where found.</returns>
        [HttpGet("{accountId}")]
        [ProducesResponseType(typeof(AccountDetail), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetDetail(string? accountId) =>
            new WebApiGet<AccountDetail?>(this, () => _manager.GetDetailAsync(accountId),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NotFound);

        /// <summary>
        /// Get <see cref="Account"/> <see cref="Balance"/>.
        /// </summary>
        /// <param name="accountId">The <see cref="Account"/> identifier.</param>
        /// <returns>The selected <see cref="Balance"/> where found.</returns>
        [HttpGet("{accountId}/balance")]
        [ProducesResponseType(typeof(Balance), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetBalance(string? accountId) =>
            new WebApiGet<Balance?>(this, () => _manager.GetBalanceAsync(accountId),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NotFound);
    }
}

#pragma warning restore
#nullable restore