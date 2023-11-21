using Garage2._0_Group5.Data;
using Garage2._0_Group5.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0_Group5.ViewComponents
{
    //public class ReceiptViewComponent : ViewComponent
    //{
    //    private readonly Garage2_0_Group5Context db;

    //    public ReceiptViewComponent(Garage2_0_Group5Context db)
    //    {
    //        this.db = db;
    //    }

    //    //public async Task<IViewComponentResult> InvokeAsync(string vehicleId)
    //    //{
    //    //    var vehicle = await db.Vehicle.Where(v => v.ID == vehicleId).FirstOrDefaultAsync();

    //    //    var departureTime = DateTime.Now;
    //    //    var total = departureTime - vehicle.TimeOfRegistration;
    //    //    var price = Math.Round(total.TotalMinutes * 2);

    //    //    var model = new ReceiptViewModel
    //    //    {
    //    //        DepartureTime = departureTime,
    //    //        TotalTime = total,
    //    //        Price = price
    //    //    };

    //    //    return View(model);
    //    //}
    //}
}
