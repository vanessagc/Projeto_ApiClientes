using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Api.Validations
{
    public class ModelStateValidaton
    {
        public static Hashtable GetErrors(ModelStateDictionary ModelState)
        {
            Hashtable resultado = new Hashtable();

            foreach (var state in ModelState)
            {
                resultado[state.Key] = state.Value.Errors
                                        .Select(e => e.ErrorMessage)
                                        .ToList();
            }

            return resultado;
        }
    }
}
