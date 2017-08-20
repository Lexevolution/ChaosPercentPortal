Imports System.Runtime.InteropServices

Public NotInheritable Class InputHelper
    Private Sub New()
    End Sub

#Region "Methods"
#Region "PressKey()"
    ''' <summary>
    ''' Virtually presses a key.
    ''' </summary>
    ''' <param name="Key">The key to press.</param>
    ''' <param name="HardwareKey">Whether or not to press the key using its hardware scan code.</param>
    ''' <remarks></remarks>
    Public Shared Sub PressKey(ByVal Key As Keys, Optional ByVal HardwareKey As Boolean = False)
        If HardwareKey = False Then
            InputHelper.SetKeyState(Key, False)
            InputHelper.SetKeyState(Key, True)
        Else
            InputHelper.SetHardwareKeyState(Key, False)
            InputHelper.SetHardwareKeyState(Key, True)
        End If
    End Sub
#End Region

#Region "SetKeyState()"
    ''' <summary>
    ''' Virtually sends a key event.
    ''' </summary>
    ''' <param name="Key">The key of the event to send.</param>
    ''' <param name="KeyUp">Whether to push down or release the key.</param>
    ''' <remarks></remarks>
    Public Shared Sub SetKeyState(ByVal Key As Keys, ByVal KeyUp As Boolean)
        Key = ReplaceBadKeys(Key)

        Dim KeyboardInput As New KEYBDINPUT With {
            .wVk = Key,
            .wScan = 0,
            .time = 0,
            .dwFlags = If(KeyUp, KEYEVENTF.KEYUP, 0),
            .dwExtraInfo = IntPtr.Zero
        }

        Dim Union As New INPUTUNION With {.ki = KeyboardInput}
        Dim Input As New INPUT With {
            .type = INPUTTYPE.KEYBOARD,
            .U = Union
        }

        SendInput(1, New INPUT() {Input}, Marshal.SizeOf(GetType(INPUT)))
    End Sub
#End Region

#Region "SetHardwareKeyState()"
    ''' <summary>
    ''' Virtually sends a key event using the key's scan code.
    ''' </summary>
    ''' <param name="Key">The key of the event to send.</param>
    ''' <param name="KeyUp">Whether to push down or release the key.</param>
    ''' <remarks></remarks>
    Public Shared Sub SetHardwareKeyState(ByVal Key As Keys, ByVal KeyUp As Boolean)
        Key = ReplaceBadKeys(Key)

        Dim KeyboardInput As New KEYBDINPUT With {
            .wVk = 0,
            .wScan = MapVirtualKeyEx(CUInt(Key), 0, GetKeyboardLayout(0)),
            .time = 0,
            .dwFlags = KEYEVENTF.SCANCODE Or If(KeyUp, KEYEVENTF.KEYUP, 0),
            .dwExtraInfo = IntPtr.Zero
        }

        Dim Union As New INPUTUNION With {.ki = KeyboardInput}
        Dim Input As New INPUT With {
            .type = INPUTTYPE.KEYBOARD,
            .U = Union
        }

        SendInput(1, New INPUT() {Input}, Marshal.SizeOf(GetType(INPUT)))
    End Sub
#End Region

#Region "ReplaceBadKeys()"
    ''' <summary>
    ''' Replaces bad keys with their corresponding VK_* value.
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared Function ReplaceBadKeys(ByVal Key As Keys) As Keys
        Dim ReturnValue As Keys = Key

        If ReturnValue.HasFlag(Keys.Control) Then
            ReturnValue = (ReturnValue And Not Keys.Control) Or Keys.ControlKey 'Replace Keys.Control with Keys.ControlKey.
        End If

        If ReturnValue.HasFlag(Keys.Shift) Then
            ReturnValue = (ReturnValue And Not Keys.Shift) Or Keys.ShiftKey 'Replace Keys.Shift with Keys.ShiftKey.
        End If

        If ReturnValue.HasFlag(Keys.Alt) Then
            ReturnValue = (ReturnValue And Not Keys.Alt) Or Keys.Menu 'Replace Keys.Alt with Keys.Menu.
        End If

        Return ReturnValue
    End Function
#End Region
#End Region

#Region "WinAPI P/Invokes"
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SendInput(ByVal nInputs As UInteger, <MarshalAs(UnmanagedType.LPArray)> ByVal pInputs() As INPUT, ByVal cbSize As Integer) As UInteger
    End Function

    <DllImport("user32.dll")>
    Private Shared Function MapVirtualKeyEx(uCode As UInteger, uMapType As UInteger, dwhkl As IntPtr) As UInteger
    End Function

    <DllImport("user32.dll")>
    Private Shared Function GetKeyboardLayout(idThread As UInteger) As IntPtr
    End Function

#Region "Enumerations"
    Private Enum INPUTTYPE As UInteger
        MOUSE = 0
        KEYBOARD = 1
        HARDWARE = 2
    End Enum

    <Flags()>
    Private Enum KEYEVENTF As UInteger
        EXTENDEDKEY = &H1
        KEYUP = &H2
        SCANCODE = &H8
        UNICODE = &H4
    End Enum
#End Region

#Region "Structures"
    <StructLayout(LayoutKind.Explicit)>
    Private Structure INPUTUNION
        <FieldOffset(0)> Public mi As MOUSEINPUT
        <FieldOffset(0)> Public ki As KEYBDINPUT
        <FieldOffset(0)> Public hi As HARDWAREINPUT
    End Structure

    Private Structure INPUT
        Public type As Integer
        Public U As INPUTUNION
    End Structure

    Private Structure MOUSEINPUT
        Public dx As Integer
        Public dy As Integer
        Public mouseData As Integer
        Public dwFlags As Integer
        Public time As Integer
        Public dwExtraInfo As IntPtr
    End Structure

    Private Structure KEYBDINPUT
        Public wVk As UShort
        Public wScan As Short
        Public dwFlags As UInteger
        Public time As Integer
        Public dwExtraInfo As IntPtr
    End Structure

    Private Structure HARDWAREINPUT
        Public uMsg As Integer
        Public wParamL As Short
        Public wParamH As Short
    End Structure
#End Region
#End Region
End Class