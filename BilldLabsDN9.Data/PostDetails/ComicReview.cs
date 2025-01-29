using BilldLabsDN9.Data.Enums;
using BilldLabsDN9.Data.Interfaces;
using BilldLabsDN9.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilldLabsDN9.Data.PostDetails
{
    public class ComicReview : BasePostDetail
    {
        [Required]
        [Range(0, 5)]
        public Decimal ReviewScore { get; set; } = 0.0m;
        public string Review { get; set; } = string.Empty;
        public string ComicTitle { get; set; } = string.Empty;
        public string ComicAuthor { get; set; } = string.Empty;
        public string ComicArtist { get; set; } = string.Empty;
        public string CoverArist { get; set; } = string.Empty;
        [Required]
        [MinLength(1)]
        public string CoverUrl { get; set; } = string.Empty;
        [Required]
        [MinLength(1)]
        public string CoverAltText { get; set; } = string.Empty;
        public string ReferralUrl { get; set; } = string.Empty;

        public override string GetBody()
        {
            return "I am a comic remview.";
        }

    }
}
