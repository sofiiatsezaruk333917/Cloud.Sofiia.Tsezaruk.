/*using HostelNaUOA.Core.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace HostelNaUOA.Core.Endpoints
{
    [HttpPost("/dormitory")]
    [AllowAnonymous]
    class CreateHostelEndpoint : Endpoint<CreateHostelRequest, CreateHostelResponse>
    {
        private readonly HostelDbConfig _hostelContext;

        public CreateDormitoryEndpoint(HostelDbConfig hostelContext)
        {
            _hostelContext = hostelContext;

        }
        public override async Task HandleAsync(CreateHostelRequest req, CancellationToken ct)
        {
            var entity = new Hostel
            {
                Id = req.Id,
                Description = req.Description,
                CountBad = req.CountBad,
                FreeBedCount= req.FreeBedCount,
                
            };
            await _hostelContext.AddAsync(entity, ct);
            await SendOkAsync(ct);
        }
    }
}
*/