Option Strict On
Option Explicit On

Imports System.ComponentModel

<Description("Represents a control that allows the user to select an option.")> _
<DefaultEvent("StateChanged")> _
<DefaultProperty("IsActivated")> _
<DefaultValue(False)> _
<DefaultBindingProperty("IsActivated")> _
Public Class Switch_electro

#Region "Events"

    ''' <summary>
    ''' Occurs when the value of the IsActivated property changes.
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    <Description("Occurs when the value of the IsActivated property changes.")> _
    <Category("Default")> _
    Public Event StateChanged As EventHandler

    '' 
    Protected Overridable Sub OnStateChanged()

        Me.ChangeButtonAppearance()
        RaiseEvent StateChanged(Me, EventArgs.Empty)

    End Sub

#End Region


#Region "Constructors"

    ''' <summary>
    ''' Initializes a new instance of the class MySwitch.
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the class MySwitch.
    ''' </summary>
    ''' <param name="blnInitialState">Indicates whether the control is initially activated or not.</param>
    ''' <remarks></remarks>
    ''' 
    Public Sub New(ByVal blnInitialState As Boolean)
        InitializeComponent()
        Me.IsActivated = blnInitialState
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the class MySwitch.
    ''' </summary>
    ''' <param name="strActivatedText">Text when control is activated.</param>
    ''' <param name="strDeactivatedText">Text when control is deactivated.</param>
    ''' <remarks></remarks>
    ''' 
    Public Sub New(ByVal strActivatedText As String, ByVal strDeactivatedText As String)
        InitializeComponent()

    End Sub


#End Region

#Region "Private variables"
    Private blnIsActivated As Boolean = False
    Private bmpDeactivatedImage As New Bitmap(My.Resources.OffState)
    Private bmpActivatedImage As New Bitmap(My.Resources.OnState)

#End Region


#Region "Control properties"

    <Description("Gets or sets the image when control is activated.")> _
   <Category("Appearance")> _
    Public Property ActivatedImage As Bitmap
        Get
            Return Me.bmpActivatedImage
        End Get
        Set(value As Bitmap)
            Me.bmpActivatedImage = value
            Me.ChangeButtonAppearance()
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the image when control is not activated.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    <Description("Gets or sets the image when control is not activated.")> _
    <Category("Appearance")> _
    Public Property DeactivatedImage As Bitmap
        Get
            Return Me.bmpDeactivatedImage
        End Get

        Set(value As Bitmap)
            Me.bmpDeactivatedImage = value
            Me.ChangeButtonAppearance()
        End Set
    End Property
    ''' <summary>
    ''' Gets or sets a value specifies whether the control is activated or not.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    <Description("Gets or sets a value specifies whether the control is activated or not.")> _
    <Category("Behavior")> _
    Public Property IsActivated As Boolean
        Get
            Return Me.blnIsActivated
        End Get
        Set(value As Boolean)
            If (value <> Me.blnIsActivated) Then
                Me.blnIsActivated = value
                OnStateChanged()
            End If
        End Set
    End Property

#End Region


#Region "Private methods"

    ''' <summary>
    ''' Change button appearance based on the value of IsActivated and ButtonStyle properties.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ChangeButtonAppearance()

        If (Me.IsActivated) Then
            Me.BackgroundImage = Me.ActivatedImage
            Me.BackgroundImageLayout = ImageLayout.None
        Else

            Me.BackgroundImage = Me.DeactivatedImage
            Me.BackgroundImageLayout = ImageLayout.None
        End If

    End Sub

    Private Sub ChangeButtonSize()
        Me.QF.Width = CInt(Me.Size.Width / 2)
        'Me.ChangeButtonPositionByState()
    End Sub

#End Region


#Region "Public methods"

    ''' <summary>
    ''' Switches the control state denying its current value.
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    <Description("Switches the control state denying its current value.")> _
    Public Sub SwitchState()
        Me.IsActivated = Not Me.IsActivated
    End Sub

#End Region

#Region "Control behavior"

    Private Sub btnSwitch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QF.KeyPress
        If (e.KeyChar = System.Convert.ToChar(Keys.Space) Or (e.KeyChar = System.Convert.ToChar(Keys.Enter))) Then
            Me.IsActivated = Not Me.IsActivated
        End If
    End Sub

    Private Sub MySwitch_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.ChangeButtonSize()
    End Sub

#End Region


End Class
