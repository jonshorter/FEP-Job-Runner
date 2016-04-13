Imports System.Reflection

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim jsonresource As String = "FEP_Job_Runner.Newtonsoft.Json.dll"
            Dim feprestclient As String = "FEP_Job_Runner.FEPRestClient.dll"
            Dim ressharp As String = "FEP_Job_Runner.RestSharp.dll"
            EmbeddedAssembly.Load(jsonresource, "Newtonsoft.Json.dll")
            EmbeddedAssembly.Load(ressharp, "RestSharp.dll")
            EmbeddedAssembly.Load(feprestclient, "FEPRestClient.dll")

            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CurrentDomain_AssemblyResolve

        End Sub
        Private Shared Function CurrentDomain_AssemblyResolve(sender As Object, args As ResolveEventArgs) As Assembly
            Return EmbeddedAssembly.[Get](args.Name)
        End Function

    End Class


End Namespace

