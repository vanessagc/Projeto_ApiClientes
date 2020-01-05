namespace Projeto.Domain.Validations.EnderecoRules
{
    public class LogradouroValidation
    {
        public static bool Validar(string logradouro)
        {
            if (logradouro.Length <= 2)
                return false;

            return true;
        }

    }
}
