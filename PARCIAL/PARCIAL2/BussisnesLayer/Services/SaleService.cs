using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussisnesLayer.Services
{
    public class SaleService
    {
        private SaleRepository _salesRepository;

        public SaleService()
        {
            _salesRepository = new SaleRepository();
        }

        public DataTable GetAllSales()
        {
            return _salesRepository.GetSales();
        }

        public void AddSale(Sale sale)
        {
            _salesRepository.AddSale(sale);
        }

        public void EditSale(Sale sale)
        {
            _salesRepository.UpdateSale(sale);
        }

        public void DeleteSale(int saleId)
        {
            _salesRepository.DeleteSale(saleId);
        }
    }
}
