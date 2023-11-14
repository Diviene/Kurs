﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Shared.Models
{
        public class MinimumAgeAttribute : ValidationAttribute
        {
            private readonly int _minimumAge;

            public MinimumAgeAttribute(int minimumAge)
            {
                _minimumAge = minimumAge;
            }

            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value is DateTime dateOfBirth)
                {
                    var age = DateTime.Today.Year - dateOfBirth.Year;
                    if (dateOfBirth > DateTime.Today.AddYears(-age))
                    {
                        age--;
                    }

                    if (age < _minimumAge)
                    {
                        return new ValidationResult(GetErrorMessage());
                    }
                }

                return ValidationResult.Success;
            }

            private string GetErrorMessage()
            {
                return $"Вам должно быть {_minimumAge} лет для того, чтобы зарегистрироваться.";
            }
        }
    }
