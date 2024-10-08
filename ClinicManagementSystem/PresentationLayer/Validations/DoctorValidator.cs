using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class DoctorValidator : AbstractValidator<Doctor>
    {
        public DoctorValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(doctor => doctor.FirstName)
                .NotEmpty().WithMessage("El nombre no puede estar vacio")
                .MinimumLength(3).WithMessage("El nombre debe contener minimo 3 letras")
                .MaximumLength(100).WithMessage("El nombre no puede tener mas de 100 letras");

            RuleFor(doctor => doctor.LastName)
                .NotEmpty().WithMessage("El apellido no puede estar vacio")
                .Length(3, 100).WithMessage("El apellido debe contener entre 3 y 100 letras");
        }
    }
}
