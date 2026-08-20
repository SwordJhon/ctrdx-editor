#Requires AutoHotkey v2.0
#SingleInstance Force

A_ScriptName := 'Release Windows'

; python release_windows.py <version>
EditorReleaseGui := Gui('+DPIScale -MinimizeBox -MaximizeBox +OwnDialogs')
EditorReleaseGui.SetFont 'S11'
EditorReleaseGui.MarginY := EditorReleaseGui.MarginX := 8
Version := EditorReleaseGui.AddEdit('r1 w180', '1.0')
EditorReleaseGui.AddButton('r1 w180', 'Proceed').OnEvent('Click', (*) => (
    RunWait('python release_windows.py ' Version.Value),
    MsgBox('Done',, 'Owner' EditorReleaseGui.Hwnd),
    ExitApp()
))
EditorReleaseGui.Show