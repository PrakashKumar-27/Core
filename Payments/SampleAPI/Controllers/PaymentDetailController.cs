using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentDetailController : ControllerBase
    {
        private readonly PaymentDetailContext _context;

        public PaymentDetailController(PaymentDetailContext context)
        {
            _context = context;
        }

        // GET: api/PaymentDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDetail>>> GetPaymentDetails()
        {
            List<PaymentDetail> paymentDetails = new List<PaymentDetail>();
            PaymentDetail paymentDetail = new PaymentDetail();
            paymentDetails.Add(paymentDetail);
            return paymentDetails;
        }

        // GET: api/PaymentDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDetail>> GetPaymentDetail(int id)
        {
            PaymentDetail paymentDetail = new PaymentDetail();
            return paymentDetail;
        }


        // POST: api/PaymentDetail
        [HttpPost]
        public async Task<ActionResult<PaymentDetail>> PostPaymentDetail(PaymentDetail paymentDetail)
        {
            PaymentDetail paymentDetaill = new PaymentDetail();
            return paymentDetaill;
        }

        // DELETE: api/PaymentDetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PaymentDetail>> DeletePaymentDetail(int id)
        {
            PaymentDetail paymentDetail = new PaymentDetail();
            return paymentDetail;
        }

        private bool PaymentDetailExists(int id)
        {
            return false;        
        }
    }
}
