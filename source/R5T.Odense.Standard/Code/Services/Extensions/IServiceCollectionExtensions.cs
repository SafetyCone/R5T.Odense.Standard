using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.Odense.Default;


namespace R5T.Odense.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IVisualStudioSolutionFileProjectTypeGuidProvider"/> service.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFileProjectTypeGuidProvider(this IServiceCollection services)
        {
            services.AddDefaultVisualStudioSolutionFileProjectTypeGuidProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IVisualStudioSolutionFileProjectTypeGuidProvider"/> service.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFileProjectTypeGuidProvider> AddVisualStudioSolutionFileProjectTypeGuidProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFileProjectTypeGuidProvider>(() => services.AddVisualStudioSolutionFileProjectTypeGuidProvider());
            return serviceAction;
        }
    }
}
