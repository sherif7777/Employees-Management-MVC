﻿using Demo.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Demo.PL.ViewModels
{
	public class DepartmentViewModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Name Is Required")]
		[MaxLength(50)]
		public string Name { get; set; }

		[Required(ErrorMessage = "Code Is Required")]
		public string Code { get; set; }
		public DateTime DateOfCreation { get; set; }

	
	}
}
