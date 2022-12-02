using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Validations
{
    public class CheckValidLegajo : ValidationAttribute
    {
        public CheckValidLegajo()
        {
            ErrorMessage = "El legajo no cumple con las condiciones de inciar con AA y contener 5 numeros";
        }

        public override bool IsValid(object value)
        {

            string legajo =(string) value;
            if (legajo != null && legajo.Substring(0,2) == "AA" && int.TryParse(legajo.Substring(2, 5), out int valorNumerico)  )
            {
                return true;
            }
            else
            {
                return true;
            }


        }
    }
}
