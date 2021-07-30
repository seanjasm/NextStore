using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NextStore.Models
{
    public enum ItemType
    {
        Food,
        Clothes,
        [Display(Name = "Interior Decor")]
        IntDec
    }
}
