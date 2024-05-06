using Eplan.ElApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class setLogic
{
  [Start]
  public void Action()
  {
    //Creamos la variable para la acción.
    CommandLineInterpreter oCLI = new CommandLineInterpreter();
    //Creamos la variable para guardar las propiedades de la acción a realizar.
    ActionCallingContext acc = new ActionCallingContext();

    //Escribimos los parametros
    acc.AddParameter("PropertyId","20371");
    acc.AddParameter("PropertyIndex","1");
    acc.AddParameter("PropertyValue","1");
    //Ahora con las información en la variable acc, hacemos la llamada a la acción.
    oCLI.Execute("XEsSetPropertyAction",acc);
  }
}
    
