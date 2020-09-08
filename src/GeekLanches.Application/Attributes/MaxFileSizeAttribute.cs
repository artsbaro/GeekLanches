using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GeekLanches.Application.Attributes
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {

        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            if (value is IFormFile file && file.Length > _maxFileSize)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"tamanho máximo permitido é { _maxFileSize} bytes.";
        }
    }
}
