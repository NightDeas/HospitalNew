using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.Runtime;

namespace DataBase.Entities
{
    [PrimaryKey("Id")]
    public partial class Patient : DefaultEntity
    {
        [Required]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }

        public DateTime DateOfBirth { get; set; }
        [MaxLength(10)]
        [MinLength(10)]
        public string Passport { get; set; }
        public string Address { get; set; }
        public string WorkAddress { get; set; }
        public string Telephone { get; set; }
        public byte[]? Photo { get; set; }

        public string Email { get; set; }
        public int GenreId { get; set; }


        public virtual Genre Genre { get; set; }
        public virtual InsurancePolicy InsurancePolicy{ get;set;} 
        public virtual MedCard MedCard{ get; set; }
    }
}