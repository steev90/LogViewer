﻿using Catel.IoC;
using LogViewer.Services;
using LogViewer.Models;
using Orchestra.Services;
using Orchestra.Shell.Services;

/// <summary>
/// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
/// </summary>
public static class ModuleInitializer
{
    /// <summary>
    /// Initializes the module.
    /// </summary>
    public static void Initialize()
    {
        var serviceLocator = ServiceLocator.Default;

        serviceLocator.RegisterType<IRibbonService, RibbonService>();
        serviceLocator.RegisterType<IApplicationInitializationService, ApplicationInitializationService>();
        serviceLocator.RegisterType<ILogRecordService, LogRecordService>();
        serviceLocator.RegisterType<ISettingsSerialiser, SettingsSerialiser>();
        serviceLocator.RegisterType<ILogFileService, LogFileService>();
        serviceLocator.RegisterType<ICompanyService, CompanyService>();
        serviceLocator.RegisterType<IProductService, ProductService>();
        serviceLocator.RegisterType<LogViewerModel>(RegistrationType.Singleton);
    }
}