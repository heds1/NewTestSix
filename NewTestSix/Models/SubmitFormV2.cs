using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewTestSix.Models
{
    public class SubmitFormV2
    {
        public int Id { get; set; }

        [Display(Name = "Sample ID")]
        [StringLength(60, MinimumLength=2)]
        [Required]
        public string ClientSampleID { get; set; }

        [Display(Name = "Additional comments")]
        public string AdditionalComments { get; set; }

        [Display(Name = "Acid-stable amino acids")]
        public bool AcidStables { get; set; }

        [Display(Name = "Sulfur amino acids")]
        public bool Sulfurs { get; set; }

        [Display(Name = "Tryptophan")]
        public bool Trp { get; set; }

        [Display(Name = "Free amino acids")]
        public bool FAAs { get; set; }

        [Display(Name = "Sample matrix")]
        [Required]
        public SampleMatrixOptions _sampleMatrix { get; set; }
          
        public enum SampleMatrixOptions
        {
            Powder,
            Liquid,
            Other
        }
    }
}
