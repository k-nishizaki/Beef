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
using Beef.Demo.Business;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Api.Controllers
{
    /// <summary>
    /// Provides the <see cref="PostalInfo"/> Web API functionality.
    /// </summary>
    [Route("api/v1/postal")]
    public partial class PostalInfoController : ControllerBase
    {
        private readonly IPostalInfoManager _manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="PostalInfoController"/> class.
        /// </summary>
        /// <param name="manager">The <see cref="IPostalInfoManager"/>.</param>
        public PostalInfoController(IPostalInfoManager manager)
            { _manager = Check.NotNull(manager, nameof(manager)); PostalInfoControllerCtor(); }

        partial void PostalInfoControllerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The selected <see cref="PostalInfo"/> where found.</returns>
        [HttpGet("{country}/{state}/{city}")]
        [ProducesResponseType(typeof(PostalInfo), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetPostCodes(string? country, string? state, string? city) =>
            new WebApiGet<PostalInfo?>(this, () => _manager.GetPostCodesAsync(country, state, city),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NotFound);

        /// <summary>
        /// Creates a new <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="value">The <see cref="PostalInfo"/>.</param>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The created <see cref="PostalInfo"/>.</returns>
        [HttpPost("{country}/{state}/{city}")]
        [ProducesResponseType(typeof(PostalInfo), (int)HttpStatusCode.Created)]
        public IActionResult CreatePostCodes([FromBody] PostalInfo value, string? country, string? state, string? city) =>
            new WebApiPost<PostalInfo>(this, () => _manager.CreatePostCodesAsync(WebApiActionBase.Value(value), country, state, city),
                operationType: OperationType.Create, statusCode: HttpStatusCode.Created, alternateStatusCode: null);

        /// <summary>
        /// Updates an existing <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="value">The <see cref="PostalInfo"/>.</param>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The updated <see cref="PostalInfo"/>.</returns>
        [HttpPut("{country}/{state}/{city}")]
        [ProducesResponseType(typeof(PostalInfo), (int)HttpStatusCode.OK)]
        public IActionResult UpdatePostCodes([FromBody] PostalInfo value, string? country, string? state, string? city) =>
            new WebApiPut<PostalInfo>(this, value, () => _manager.GetPostCodesAsync(country, state, city), () => _manager.UpdatePostCodesAsync(WebApiActionBase.Value(value), country, state, city),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null);

        /// <summary>
        /// Patches an existing <see cref="PostalInfo"/>.
        /// </summary>
        /// <param name="value">The <see cref="JToken"/> that contains the patch content for the <see cref="PostalInfo"/>.</param>
        /// <param name="country">The Country.</param>
        /// <param name="state">The State.</param>
        /// <param name="city">The City.</param>
        /// <returns>The patched <see cref="PostalInfo"/>.</returns>
        [HttpPatch("{country}/{state}/{city}")]
        [ProducesResponseType(typeof(PostalInfo), (int)HttpStatusCode.OK)]
        public IActionResult PatchPostCodes([FromBody] JToken value, string? country, string? state, string? city) =>
            new WebApiPatch<PostalInfo>(this, value, () => _manager.GetPostCodesAsync(country, state, city), (__value) => _manager.UpdatePostCodesAsync(__value, country, state, city),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null, autoConcurrency: true);
    }
}

#pragma warning restore
#nullable restore