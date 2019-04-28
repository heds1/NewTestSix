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

        public string ClientSampleID { get; set; }
        public string AdditionalComments { get; set; }
        public bool AcidStables { get; set; }
        public bool Sulfurs { get; set; }
        public bool Trp { get; set; }
        public bool FAAs { get; set; }

        public SampleMatrixOptions _sampleMatrix { get; set; }
          
        public enum SampleMatrixOptions
        {
            Powder,
            Liquid,
            Other
        }



    }
  
}
