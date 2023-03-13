using SharedModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLEC_API.Helper
{
    public interface IPaymentRepo
    {
        bool Save(Payment pay);
        bool Update(Payment pay);
        List<Payment> GetAll();
        Payment GetById(int id);
        bool Delete(int id);
    }
}
