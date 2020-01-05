namespace Projeto.Domain.Validations.ClienteRules
{
    public class NomeValidation
    {
        public static bool Validar(string nome)
        {
            if (nome.Length <= 2)
                return false;

            return true;
        }
    }
}
