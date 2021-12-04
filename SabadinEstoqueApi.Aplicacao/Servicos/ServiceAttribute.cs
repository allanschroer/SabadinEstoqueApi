using System;

namespace SabadinEstoqueApi.Aplicacao
{
    //
    // Summary:
    //     Attribute para registrar serviços.
    //     Pode ser utilizado em interfaces e classes.
    //     Para uma classe concreta, que possui esse atributo, será registrado no Container
    //     como serviço. A classe concreta será a implementação, e poderá ser definido um
    //     ou mais serviços, que a classe implementa, ou deixar o serviço ser determinado
    //     automaticamente.
    //     Os serviços serão determinados automaticamente quando não for utilizado parâmetros
    //     no construtor deste atributo. Serão considerados serviços, todas as interfaces
    //     que a classe implementa e que contenha este mesmo atributo.
    //     É possível, ainda, registrar todas as interfaces que uma classe implementa. Para
    //     isto, é necessário usar o valor
    //     true
    //     como parâmetro no construtor deste atributo.
    //     Para intefaces, utilize quando ela for um serviço que pode ser registrado automaticamente.
    //     Ainda é possível definir o escopo de ciclo de vida do serviço, através de atributos
    //     que herdam Havan.Core.LifetimeScopeAttribute, além de qualificadores para diferênciar
    //     implementações de uma mesma interface através do uso de attributos que herdam
    //     Havan.Core.QualifierAttribute.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class ServiceAttribute : Attribute
    {
        //
        // Summary:
        //     Tipo do serviço a ser registrado. Utilizar apenas em classes concretas.
        public Type[] Services
        {
            get;
            private set;
        }

        //
        // Summary:
        //     Se deverá registrar todas interfaces que a classe com este tipo implementa.
        public bool RegisterAllInterfaces
        {
            get;
            private set;
        }

        //
        // Summary:
        //     Construtor simples, buscará os serviços a serem registrados automaticamente.
        //
        // Parameters:
        //   registerAllInterfaces:
        //     Se deverá ser registrado todas as interfaces que o serviço implementa.
        //     Caso seja falso, serão registradas apenas as classes e interfaces que também
        //     contenham Havan.Core.ServiceAttribute.
        public ServiceAttribute(bool registerAllInterfaces = false)
        {
            RegisterAllInterfaces = registerAllInterfaces;
        }

        //
        // Summary:
        //     Construtor que define os serviços a serem registrados.
        //
        // Parameters:
        //   services:
        //     Serviços a serem registrados.
        public ServiceAttribute(params Type[] services)
        {
            Services = services;
            RegisterAllInterfaces = false;
        }
    }
}