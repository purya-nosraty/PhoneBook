using System;
using System.ComponentModel.DataAnnotations;

namespace Modles
{
	public class Category : Object
	{
		public Category() : base()
		{
		}

		//**********
		/// <summary>
		/// ID
		/// </summary>
		public System.Guid Id { get; set; }
		//**********

		/// <summary>
		/// Firstname
		/// </summary>
		[Required]
		[Display(Name = "First Name")]
		[StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "The first name should be between {1} and {2}")]
		public string Firstname { get; set; }
		//**********

		/// <summary>
		/// Lastname
		/// </summary>
		[Required]
		[Display(Name = "Last Name")]
		[StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "The last name should be between {1} and {2}")]
		public string Lastname { get; set; }
		//**********

		//**********

		/// <summary>
		/// Lastname
		/// </summary>
		[Required]
		[Display(Name = "Phone Number")]
		[StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "The last Phone Number should be {1} digits.")]
		public string PhoneNumber { get; set; }
		//**********
	}
}
