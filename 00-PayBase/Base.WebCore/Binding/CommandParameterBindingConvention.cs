using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;


public class CommandParameterBindingConvention : IActionModelConvention
{
    public void Apply(ActionModel action)
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action));
        }

        foreach (var parameter in action.Parameters)
        {
            if (typeof(IModel).IsAssignableFrom(parameter.ParameterInfo.ParameterType))
            {
                parameter.BindingInfo = parameter.BindingInfo ?? new BindingInfo();
                parameter.BindingInfo.BindingSource = BindingSource.Body;
            }
        }
    }
}