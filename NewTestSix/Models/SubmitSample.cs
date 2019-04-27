using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewTestSix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string ClientSampleID { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }


    public class SubmitSample
    {
        public int Id { get; set; }
        public string SampleID { get; set; }




    }

    public class RequestedAnalyses
    {
        public bool AcidStables { get; set; }
        public bool Sulfurs { get; set; }
        public bool Trp { get; set; }
        public bool FAAs { get; set; }
    }

    public enum SampleMatrixOptions
    {
        Powder,
        Liquid,
        Other
    }
}
