﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace JobsService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="JobsService.JobsServiceSoap")>  _
    Public Interface JobsServiceSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/RunJobFromTemplateName", ReplyAction:="*"), _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=True)> _
        Function RunJobFromTemplateName(ByVal request As JobsService.RunJobFromTemplateNameRequest) As JobsService.RunJobFromTemplateNameResponse

        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/RunJobFromTemplateName", ReplyAction:="*")> _
        Function RunJobFromTemplateNameAsync(ByVal request As JobsService.RunJobFromTemplateNameRequest) As System.Threading.Tasks.Task(Of JobsService.RunJobFromTemplateNameResponse)

        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/RunJobTemplateFromOptionsXml", ReplyAction:="*"), _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=True)> _
        Function RunJobTemplateFromOptionsXml(ByVal request As JobsService.RunJobTemplateFromOptionsXmlRequest) As JobsService.RunJobTemplateFromOptionsXmlResponse

        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/RunJobTemplateFromOptionsXml", ReplyAction:="*")> _
        Function RunJobTemplateFromOptionsXmlAsync(ByVal request As JobsService.RunJobTemplateFromOptionsXmlRequest) As System.Threading.Tasks.Task(Of JobsService.RunJobTemplateFromOptionsXmlResponse)
    End Interface

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://tempuri.org/")> _
    Partial Public Class ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private fileToSendField As String

        Private remotePathField As String

        Private isRelativeField As String

        Private overwriteIfExistsField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)> _
        Public Property FileToSend() As String
            Get
                Return Me.fileToSendField
            End Get
            Set(value As String)
                Me.fileToSendField = value
                Me.RaisePropertyChanged("FileToSend")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)> _
        Public Property RemotePath() As String
            Get
                Return Me.remotePathField
            End Get
            Set(value As String)
                Me.remotePathField = value
                Me.RaisePropertyChanged("RemotePath")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)> _
        Public Property IsRelative() As String
            Get
                Return Me.isRelativeField
            End Get
            Set(value As String)
                Me.isRelativeField = value
                Me.RaisePropertyChanged("IsRelative")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)> _
        Public Property OverwriteIfExists() As String
            Get
                Return Me.overwriteIfExistsField
            End Get
            Set(value As String)
                Me.overwriteIfExistsField = value
                Me.RaisePropertyChanged("OverwriteIfExists")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://tempuri.org/")> _
    Partial Public Class ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private executableField As String

        Private argumentsField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)> _
        Public Property Executable() As String
            Get
                Return Me.executableField
            End Get
            Set(value As String)
                Me.executableField = value
                Me.RaisePropertyChanged("Executable")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)> _
        Public Property Arguments() As String
            Get
                Return Me.argumentsField
            End Get
            Set(value As String)
                Me.argumentsField = value
                Me.RaisePropertyChanged("Arguments")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://tempuri.org/")> _
    Partial Public Class ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private remotePathField As String

        Private isRelativeField As String

        Private wipeField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)> _
        Public Property RemotePath() As String
            Get
                Return Me.remotePathField
            End Get
            Set(value As String)
                Me.remotePathField = value
                Me.RaisePropertyChanged("RemotePath")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)> _
        Public Property IsRelative() As String
            Get
                Return Me.isRelativeField
            End Get
            Set(value As String)
                Me.isRelativeField = value
                Me.RaisePropertyChanged("IsRelative")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)> _
        Public Property Wipe() As String
            Get
                Return Me.wipeField
            End Get
            Set(value As String)
                Me.wipeField = value
                Me.RaisePropertyChanged("Wipe")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"), _
     System.ServiceModel.MessageContractAttribute(WrapperName:="RunJobFromTemplateName", WrapperNamespace:="http://tempuri.org/", IsWrapped:=True)> _
    Partial Public Class RunJobFromTemplateNameRequest

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=0)> _
        Public templateName As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=1)> _
        Public jobName As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=2)> _
        Public projectName As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=3)> _
        Public userName As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=4)> _
        Public password As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=5)> _
        Public computerNames() As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=6)> _
        Public shareNames() As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=7)> _
        Public pids() As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=8)> _
        Public processNames() As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=9), _
         System.Xml.Serialization.XmlArrayItemAttribute("JobOptionsOperationsAgentRemediationSendFile")> _
        Public sendFileOptions() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=10), _
         System.Xml.Serialization.XmlArrayItemAttribute("JobOptionsOperationsAgentRemediationExecute")> _
        Public executeOptions() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=11), _
         System.Xml.Serialization.XmlArrayItemAttribute("JobOptionsOperationsAgentRemediationErase")> _
        Public eraseOptions() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=12)> _
        Public computerSearchString As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=13)> _
        Public shareSearchString As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=14)> _
        Public moduleId As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=15)> _
        Public thirdPartyJobId As String

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=16)> _
        Public integrationInfo As String


        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New( _
                    ByVal templateName As String, _
                    ByVal jobName As String, _
                    ByVal projectName As String, _
                    ByVal userName As String, _
                    ByVal password As String, _
                    ByVal computerNames() As String, _
                    ByVal shareNames() As String, _
                    ByVal pids() As String, _
                    ByVal processNames() As String, _
                    ByVal sendFileOptions() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile, _
                    ByVal executeOptions() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute, _
                    ByVal eraseOptions() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase, _
                    ByVal computerSearchString As String, _
                    ByVal shareSearchString As String, _
                    ByVal moduleId As String, _
                    ByVal thirdPartyJobId As String, _
                    ByVal integrationInfo As String)
            MyBase.New()
            Me.templateName = templateName
            Me.jobName = jobName
            Me.projectName = projectName
            Me.userName = userName
            Me.password = password
            Me.computerNames = computerNames
            Me.shareNames = shareNames
            Me.pids = pids
            Me.processNames = processNames
            Me.sendFileOptions = sendFileOptions
            Me.executeOptions = executeOptions
            Me.eraseOptions = eraseOptions
            Me.computerSearchString = computerSearchString
            Me.shareSearchString = shareSearchString
            Me.moduleId = moduleId
            Me.thirdPartyJobId = thirdPartyJobId
            Me.integrationInfo = integrationInfo

        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"), _
     System.ServiceModel.MessageContractAttribute(WrapperName:="RunJobFromTemplateNameResponse", WrapperNamespace:="http://tempuri.org/", IsWrapped:=True)> _
    Partial Public Class RunJobFromTemplateNameResponse

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=0)> _
        Public RunJobFromTemplateNameResult As System.Guid

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal RunJobFromTemplateNameResult As System.Guid)
            MyBase.New()
            Me.RunJobFromTemplateNameResult = RunJobFromTemplateNameResult
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"), _
     System.ServiceModel.MessageContractAttribute(WrapperName:="RunJobTemplateFromOptionsXml", WrapperNamespace:="http://tempuri.org/", IsWrapped:=True)> _
    Partial Public Class RunJobTemplateFromOptionsXmlRequest

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=0)> _
        Public optionsXml As String

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal optionsXml As String)
            MyBase.New()
            Me.optionsXml = optionsXml
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"), _
     System.ServiceModel.MessageContractAttribute(WrapperName:="RunJobTemplateFromOptionsXmlResponse", WrapperNamespace:="http://tempuri.org/", IsWrapped:=True)> _
    Partial Public Class RunJobTemplateFromOptionsXmlResponse

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://tempuri.org/", Order:=0)> _
        Public RunJobTemplateFromOptionsXmlResult As System.Guid

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal RunJobTemplateFromOptionsXmlResult As System.Guid)
            MyBase.New()
            Me.RunJobTemplateFromOptionsXmlResult = RunJobTemplateFromOptionsXmlResult
        End Sub
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")> _
    Public Interface JobsServiceSoapChannel
        Inherits JobsService.JobsServiceSoap, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")> _
    Partial Public Class JobsServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of JobsService.JobsServiceSoap)
        Implements JobsService.JobsServiceSoap

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub

        Public Function RunJobFromTemplateName(ByVal request As JobsService.RunJobFromTemplateNameRequest) As JobsService.RunJobFromTemplateNameResponse Implements JobsService.JobsServiceSoap.RunJobFromTemplateName
            Return MyBase.Channel.RunJobFromTemplateName(request)
        End Function

        Public Function RunJobFromTemplateNameAsync(ByVal request As JobsService.RunJobFromTemplateNameRequest) As System.Threading.Tasks.Task(Of JobsService.RunJobFromTemplateNameResponse) Implements JobsService.JobsServiceSoap.RunJobFromTemplateNameAsync
            Return MyBase.Channel.RunJobFromTemplateNameAsync(request)
        End Function

        Public Function RunJobTemplateFromOptionsXml(ByVal request As JobsService.RunJobTemplateFromOptionsXmlRequest) As JobsService.RunJobTemplateFromOptionsXmlResponse Implements JobsService.JobsServiceSoap.RunJobTemplateFromOptionsXml
            Return MyBase.Channel.RunJobTemplateFromOptionsXml(request)
        End Function

        Public Function RunJobTemplateFromOptionsXmlAsync(ByVal request As JobsService.RunJobTemplateFromOptionsXmlRequest) As System.Threading.Tasks.Task(Of JobsService.RunJobTemplateFromOptionsXmlResponse) Implements JobsService.JobsServiceSoap.RunJobTemplateFromOptionsXmlAsync
            Return MyBase.Channel.RunJobTemplateFromOptionsXmlAsync(request)
        End Function
    End Class
End Namespace
