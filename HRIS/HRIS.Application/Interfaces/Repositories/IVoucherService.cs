using HRIS.Application.DTOs.Vat;
using HRIS.Application.DTOs.Voucher;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.Application.Interfaces.Repositories
{
    public interface IVoucherService
    {
        int CreateVoucher(CreateVoucherDTO model);
        int UpdateVoucher(UpdateVoucherDTO model);
        int DeleteVoucher(DeleteVoucherDTO model);
        List<VoucherDTO> GetAllVoucher();
        VoucherDTO GetVoucherById(int VoucherId);
    }
}
