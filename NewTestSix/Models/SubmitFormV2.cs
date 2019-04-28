using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTestSix.Models
{
    public class SubmitFormV2
    {
        public int Id { get; set; }
        public string ClientSampleID { get; set; }

        public bool AcidStables { get; set; }
        public bool Sulfurs { get; set; }
        public bool Trp { get; set; }
        public bool FAAs { get; set; }

        public enum SampleMatrixOptions
        {
            Powder,
            Liquid,
            Other
        }

        public string AdditionalComments { get; set; }

    }
}
