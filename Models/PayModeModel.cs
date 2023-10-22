using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Play Mode Id")]
        public int Id { get; set; }

        [DisplayName("Play Mode Name")]
        [Required(ErrorMessage = "Play Mode Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Play mode name must be between 3 and 50 characters")]
        public string Name { get; set; } 

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Play Mode Observation is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Play mode observation must be between 3 and 50 characters")]
        public string Observation { get; set; }
    }
}
