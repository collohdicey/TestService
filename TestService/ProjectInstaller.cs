using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace TestService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            var process = new ServiceProcessInstaller { Account = ServiceAccount.LocalSystem };
            var serviceAdmin = new ServiceInstaller
            {
                StartType = ServiceStartMode.Manual,
                ServiceName = "MyServiceName",
                DisplayName = "My Service Display Name"
            };

            Installers.Add(process);
            Installers.Add(serviceAdmin);

            InitializeComponent();
        }
    }
}
