using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Api.Pages.TokenModels
{
    public class Token
    {
        public string AccessToken { get; set; }
        public DateTime Expration { get; set; } //yenilenme tarihini tutar
        public string RefreshToken { get; set; } //süre dolduysa yeni token yüklenir
    }
}
