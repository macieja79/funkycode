using System;
using System.CodeDom.Compiler;
using System.Reflection;

namespace CodeDom
{
    public class CodeDomFactory
    {
        public static TWrapper Compile<TWrapper>(string code, string typeFullName) where TWrapper : CodeDomTypeWrapper
        {
            var parameters = new CompilerParameters
            {
                GenerateExecutable = false,
                GenerateInMemory = true
            };

            // adding referenced assemblies
            // our in-memory assembly got implementation of IBonusCalculator,
            // so reference to assembly that contains IBonusCalculator must be also added
            var @interface = typeof(TWrapper).GetInterfaces()[0];
            parameters.ReferencedAssemblies.Add(@interface.Assembly.Location);
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Linq.dll");
            
            var codeDomProvider = CodeDomProvider.CreateProvider("CSharp");
            var compilerResults = codeDomProvider.CompileAssemblyFromSource(parameters, code);

            if (compilerResults.Errors.HasErrors)
            {
                foreach (CompilerError error in compilerResults.Errors)
                {
                    if (error.IsWarning)
                        continue;
                   
                    // TODO: handle errors
                    return null;
                }
            }

            // let's get our created assembly and get 
            Assembly assembly = compilerResults.CompiledAssembly;
            Type wrappedType = assembly.GetType(typeFullName);
           
            var codeDomWrapper = (TWrapper)Activator.CreateInstance(typeof(TWrapper), new object[] { wrappedType });
           
            return codeDomWrapper;
        }
    }
}
