using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using SVPWeb.Controllers;

namespace SVPWeb.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();

            //dependencia para el uso de User&Roles
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());

            //trabajador
            //container.RegisterType<IMasterService<Trabajador>, MasterService<Trabajador>>();
            //container.RegisterType<IMasterRepository<Trabajador>, MasterRepository<Trabajador>>();


            //container.RegisterType<InterfaceAlumno, RepositorioAlumno>();
            //container.RegisterType<InterfaceAmbiente, RepositorioAmbiente>();
            //container.RegisterType<InterfaceApoderado, RepositorioApoderado>();
            //container.RegisterType<InterfaceAsistenciaAl, RepositorioAsistenciaAl>();
            //container.RegisterType<InterfaceAsistenciaTra, RepositorioAsistenciaTra>();
            //container.RegisterType<InterfaceBien, RepositorioBien>();
            //container.RegisterType<InterfaceCargo, RepositorioCargo>();
            //container.RegisterType<InterfaceDetalleSede, RepositorioDetalleSede>();
            //container.RegisterType<InterfaceGrado, RepositorioGrado>();
            //container.RegisterType<InterfaceJustificacionAl, RepositorioJustificacionAl>();
            //container.RegisterType<InterfaceJustificacionTra, RepositorioJustificacionTra>();
            //container.RegisterType<InterfaceMovimiento, RepositorioMovimiento>();
            //container.RegisterType<InterfacePermisoHorasLaborales, RepositorioPermisoHoraLaboral>();
            //container.RegisterType<InterfaceProveedor, RepositorioProveedor>();
            //container.RegisterType<InterfaceSeccion, RepositorioSeccion>();
            //container.RegisterType<InterfaceSede, RepositorioSede>();
            //container.RegisterType<InterfaceTrabajador, RepositorioTrabajador>();
            //container.RegisterType<InterfaceVisitante, RepositorioVisitante>();
            //container.RegisterType<InterfaceVisitaVisitante, RepositorioVisitaVisitante>();
            //container.RegisterType<InterfacePermisoAlumno, RepositorioPermisoAlumno>();
        }
    }
}
