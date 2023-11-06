using Garage2._0_Group5.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Garage2._0_Group5.Models.ViewModels
{
	public class VehicleViewModel
	{
		public VehicleType SelectedVehicleType { get; set; }
		public List<SelectListItem> VehicleTypes { get; set; }
	}

}
