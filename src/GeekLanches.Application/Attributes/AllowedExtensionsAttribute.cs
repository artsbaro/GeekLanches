﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace GeekLanches.Application.Attributes
{
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _Extensions;
        public AllowedExtensionsAttribute(string[] Extensions)
        {
            _Extensions = Extensions;
        }

        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            var extension = Path.GetExtension(file.FileName);
            if (!_Extensions.Contains(extension.ToLower()))
                return new ValidationResult(GetErrorMessage());

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"Extensão da foto não permitida!";
        }
    }
}
