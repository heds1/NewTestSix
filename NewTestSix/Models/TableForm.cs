using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewTestSix.Models
{
    public class TableForm
    {
        public int Id { get; set; }

        [Display(Name = "Sample ID")]
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string ClientSampleID { get; set; }

        [Display(Name = "Additional comments")]
        public string AdditionalComments { get; set; }

        [Display(Name = "Acid-stable amino acids")]
        public string AcidStables { get; set; }

        [Display(Name = "Sulfur amino acids")]
        public bool Sulfurs { get; set; }

        [Display(Name = "Tryptophan")]
        public bool Trp { get; set; }

        [Display(Name = "Free amino acids")]
        public bool FAAs { get; set; }

        public enum SampleMatrixOptions
        {
            Powder,
            Liquid,
            Other
        }

        [Display(Name = "Sample matrix")]
        [Required]
        public SampleMatrixOptions _sampleMatrix { get; set; }
    }

    //public class TableForm
    //{
    //    public int Id { get; set; }
    //    public List<TableFormData> TableFormDatas { get; set; }
    //    public string ClientSampleID { get; set; }
    //    public string AcidStables { get; set; }
    //    public string Sulfurs { get; set; }
    //    public string FAAs { get; set; }
    //    public string Trp { get; set; }
    //    public string AdditionalComments { get; set; }

    //}
    //// TableForm is equivalent of member class
    //// TableFormData is equivalent of User class. Contains the properties of TableForm...
    //public class TableFormData
    //{
    //    public int Id { get; set; }
    //    public string ClientSampleID { get; set; }
    //    public string AdditionalComments { get; set; }
    //    public string AcidStables { get; set; }
    //}

    //public class User
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}

    //public class Member
    //{
    //    public int MemberId { get; set; }
    //    public List<User> Users { get; set; }
    //}

}
