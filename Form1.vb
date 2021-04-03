Public Class AFSMConfigurator


    'Arduino Finite State Machine
    'Copyright(C) 2018 Jelle Siemonsma

    'This program Is free software : you can redistribute it And/Or modify
    'it under the terms Of the GNU General Public License As published by
    'the Free Software Foundation, either version 3 Of the License, Or
    '(at your option) any later version.

    'This program Is distributed In the hope that it will be useful,
    'but WITHOUT ANY WARRANTY; without even the implied warranty Of
    'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.See the
    'GNU General Public License For more details.

    '<https://www.gnu.org/licenses/>.


    Public ProjectPath As String
    Public QADI As Integer = 0
    Public UseI2C As Boolean = False
    Public UseHMISerial As Boolean = False
    Public UseGPS As Boolean = False
    Public UseIntercard As Boolean = False

    Private Sub IOCollection_MouseDown(sender As Object, e As MouseEventArgs) Handles _
            IOCollection.MouseDown, DigitalIN.MouseDown, DigitalOUT.MouseDown, PWMOutput.MouseDown,
            AnalogueIN.MouseDown, Ultrasonics.MouseDown, DS18B20s.MouseDown, Servos.MouseDown, FiniteStatesListBox.MouseDown

        Dim lst As ListBox = DirectCast(sender, ListBox)
        Dim TxtStrings() As String
        Dim WrdCount As Integer

        If e.Button = Windows.Forms.MouseButtons.Right And lst.Name <> "IOCollection" Then
            Dim index As Integer = lst.IndexFromPoint(e.X, e.Y)
            If index <> ListBox.NoMatches Then
                Dim per As String = lst.Items(index)
                TxtStrings = Split(per)
                WrdCount = TxtStrings.Count
                Dim ok As MessageBoxButtons
                ok = MsgBox("Remove from list?", vbYesNo, "Remove")
                If ok = 6 Then

                    If WrdCount = 4 Then
                        IOCollection.Items.Add(TxtStrings(3))
                    End If

                    If WrdCount = 3 Then
                        If lst.Name = "DS18B20s" Then
                            If lst.Items.Count = 1 Then
                                IOCollection.Items.Add(TxtStrings(2))
                            End If
                        Else
                            IOCollection.Items.Add(TxtStrings(2))
                        End If
                    End If

                    If WrdCount = 5 Then 'trigger and echo pin
                        IOCollection.Items.Add(TxtStrings(2))
                        IOCollection.Items.Add(TxtStrings(4))
                    End If

                    If lst.Name = "FiniteStatesListBox" Then
                        If CheckFiniteState(TxtStrings(0), "h") Then
                            MsgBox("State is used in UserFiniteStateMachine.h, cannot be removed!")
                            LogBox.Items.Add("State cannot be removed from list (" & TxtStrings(0) & ")")
                        Else
                            lst.Items.Remove(per)
                        End If
                    Else
                        lst.Items.Remove(per)
                    End If

                End If
            End If
        End If


        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim index As Integer = lst.IndexFromPoint(e.X, e.Y)
            If index <> ListBox.NoMatches Then
                Dim per As String = lst.Items(index)

                Dim IOType As Char
                IOType = GetChar(per, 1)

                DigitalIN.AllowDrop = False
                DigitalOUT.AllowDrop = False
                PWMOutput.AllowDrop = False
                AnalogueIN.AllowDrop = False
                Ultrasonics.AllowDrop = False
                Servos.AllowDrop = False
                DS18B20s.AllowDrop = False

                Select Case IOType
                    Case "D"
                        DigitalIN.AllowDrop = True
                        DigitalOUT.AllowDrop = True
                        Ultrasonics.AllowDrop = True
                    Case "P"
                        PWMOutput.AllowDrop = True
                        Servos.AllowDrop = True
                        DS18B20s.AllowDrop = True
                    Case "A"
                        AnalogueIN.AllowDrop = True
                End Select

                Dim drop_effect As DragDropEffects =
                    lst.DoDragDrop(per, DragDropEffects.Move Or DragDropEffects.Copy)
                If drop_effect = DragDropEffects.Move Then
                    lst.Items.Remove(per)
                End If
                If drop_effect = DragDropEffects.Copy Then
                    lst.Items.Remove(per)
                End If
            End If
        End If


    End Sub

    Private Sub IOCollection_DragOver(sender As Object, e As DragEventArgs) Handles _
        IOCollection.DragOver, DigitalIN.DragOver, DigitalOUT.DragOver, PWMOutput.DragOver, AnalogueIN.DragOver,
        Ultrasonics.DragOver, DS18B20s.DragOver, Servos.DragOver

        If (e.AllowedEffect And DragDropEffects.Copy) = DragDropEffects.Copy Then
            e.Effect = DragDropEffects.Copy
        ElseIf (e.AllowedEffect And DragDropEffects.Move) = DragDropEffects.Move Then
            e.Effect = DragDropEffects.Move
        End If

    End Sub

    Private Sub IOCollection_DragDrop(sender As Object, e As DragEventArgs) Handles _
        IOCollection.DragDrop, DigitalIN.DragDrop, DigitalOUT.DragDrop, PWMOutput.DragDrop,
        AnalogueIN.DragDrop, Ultrasonics.DragDrop, DS18B20s.DragDrop, Servos.DragDrop


        If (e.Effect = DragDropEffects.Copy) Then

            Dim lst As ListBox = DirectCast(sender, ListBox)
            Dim item As String
            Dim Tag As String
            Dim TxtStrings() As String

            item = IOCollection.SelectedItem

            Dim pt As Point = lst.PointToClient(New Point(e.X, e.Y))
            Dim index As Integer = lst.IndexFromPoint(pt.X, pt.Y)

            If index <> -1 Then

                Tag = lst.Items.Item(index)
                TxtStrings = Split(Tag)

                'Ultrasonic
                If lst.Name = "Ultrasonics" Then
                    If InStr(Tag, " trigger ") = 0 Then
                        lst.Items.Remove(Tag)
                        lst.Items.Insert(index, Tag & " trigger " & item)
                    Else
                        If InStr(Tag, " echo ") = 0 Then
                            lst.Items.Remove(Tag)
                            lst.Items.Insert(index, Tag & " echo " & item)
                        Else
                            IOCollection.Items.Add(item)
                        End If
                    End If
                End If

                If lst.Name = "DS18B20s" Then
                    If InStr(Tag, " channel ") = 0 Then
                        lst.Items.Remove(Tag)
                        lst.Items.Insert(index, Tag & " channel " & item)
                        If lst.Items.Count <> 1 Then
                            For i As Integer = 0 To lst.Items.Count - 1
                                If i <> index Then lst.Items(i) = lst.Items(i) & " channel " & item
                            Next i
                        End If
                    Else
                        IOCollection.Items.Add(item)
                    End If
                End If


                If InStr(Tag, " on pin ") = 0 And lst.Name <> "Ultrasonics" And lst.Name <> "DS18B20s" Then
                    lst.Items.Remove(Tag)
                    lst.Items.Insert(index, Tag & " on pin " & item)
                    If lst.Name = "DigitalIN" Then
                        QADI = QADI - 1
                        If QADI = 0 Then
                            DigitalIN.ForeColor = Color.Green
                            GenConfig.Enabled = True
                        End If
                    End If
                Else
                    If lst.Name <> "Ultrasonics" And lst.Name <> "DS18B20s" Then IOCollection.Items.Add(item)
                End If


            Else
                IOCollection.Items.Add(item)
            End If

        End If


    End Sub

    Private Sub ButtonDigIn_Click(sender As Object, e As EventArgs) Handles ButtonDigIn.Click
        DigitalIN.Items.Add(DigIN.Text)
        DigIN.Text = ""
        QADI = QADI + 1
        DigitalIN.ForeColor = Color.Red
        GenConfig.Enabled = False
    End Sub

    Private Sub ButtonDigOut_Click(sender As Object, e As EventArgs) Handles ButtonDigOut.Click
        DigitalOUT.Items.Add(DigOut.Text)
        DigOut.Text = ""
    End Sub

    Private Sub ButtonUltra_Click(sender As Object, e As EventArgs) Handles ButtonUltra.Click
        Ultrasonics.Items.Add(Ultra.Text)
        Ultra.Text = ""
    End Sub

    Private Sub ButtonAnaIn_Click(sender As Object, e As EventArgs) Handles ButtonAnaIn.Click
        AnalogueIN.Items.Add(AnaIN.Text)
        AnaIN.Text = ""
    End Sub

    Private Sub ButtonPWM_Click(sender As Object, e As EventArgs) Handles ButtonPWM.Click
        PWMOutput.Items.Add(PWM.Text)
        PWM.Text = ""
    End Sub

    Private Sub WriteUserFiniteStateMachine()

        Dim CodeLine As String
        Dim LoopStop As Boolean

        Dim WriteFile As System.IO.StreamWriter
        My.Computer.FileSystem.RenameFile(ProjectPath & "UserFiniteStateMachine.h", "UserFiniteStateMachine.old")
        WriteFile = My.Computer.FileSystem.OpenTextFileWriter(ProjectPath & "UserFiniteStateMachine.h", True)
        Dim ReadFile As System.IO.StreamReader
        ReadFile = My.Computer.FileSystem.OpenTextFileReader(ProjectPath & "UserFiniteStateMachine.old")

        LoopStop = False
        Do While ReadFile.Peek() >= 0 And Not LoopStop
            CodeLine = ReadFile.ReadLine
            If InStr(CodeLine, "%END USER") Then
                LoopStop = True
            Else
                WriteFile.WriteLine(CodeLine)
            End If
        Loop

        ReadFile.Close()

        If Not CheckFiniteState("START", "old") Then
            WriteFile.WriteLine("")
            WriteFile.WriteLine("	if (MachineState == FiniteState(" & """" & "START" & """))")
            WriteFile.WriteLine("    { ")
            WriteFile.WriteLine("      //Enter actions, run once")
            WriteFile.WriteLine("      if (EnterState()) {}; ")
            WriteFile.WriteLine("      //State actions  ")
            WriteFile.WriteLine("      {};  ")
            WriteFile.WriteLine("      //Conditions and transitions  ")
            WriteFile.WriteLine("      {};  ")
            WriteFile.WriteLine("      //Exit actions, run once")
            WriteFile.WriteLine("      if (ExitState()) {}; ")
            WriteFile.WriteLine("    };")
            LogBox.Items.Add("Code block for START state made in UserFiniteStateMachine.h")
        End If

        'Check for new states in de listbox
        If FiniteStatesListBox.Items.Count <> 0 Then
            For i As Integer = 1 To FiniteStatesListBox.Items.Count
                If Not CheckFiniteState(FiniteStatesListBox.Items(i - 1), "old") Then
                    WriteFile.WriteLine("")
                    WriteFile.WriteLine("	if (MachineState == FiniteState(" & """" & FiniteStatesListBox.Items(i - 1) & """))")
                    WriteFile.WriteLine("    { ")
                    WriteFile.WriteLine("      //Enter actions, run once")
                    WriteFile.WriteLine("      if (EnterState()) {}; ")
                    WriteFile.WriteLine("      //State actions  ")
                    WriteFile.WriteLine("      {};  ")
                    WriteFile.WriteLine("      //Conditions and transitions  ")
                    WriteFile.WriteLine("      {};  ")
                    WriteFile.WriteLine("      //Exit actions, run once")
                    WriteFile.WriteLine("      if (ExitState()) {}; ")
                    WriteFile.WriteLine("    };")
                    LogBox.Items.Add("Code block for " & FiniteStatesListBox.Items(i - 1) & " state made in UserFiniteStateMachine.h")
                End If
            Next
        End If

        WriteFile.WriteLine("")
        WriteFile.WriteLine("	//*%END USER APPLICATION Generation directive dont remove!=================================")
        WriteFile.WriteLine("	//*========================================================================================")
        WriteFile.WriteLine("	//*========================================================================================")
        WriteFile.WriteLine("}")

        WriteFile.Close()

        If My.Computer.FileSystem.FileExists(ProjectPath & "UserFiniteStateMachine.old-copy") Then
            My.Computer.FileSystem.DeleteFile(ProjectPath & "UserFiniteStateMachine.old-copy")
        End If
        My.Computer.FileSystem.RenameFile(ProjectPath & "UserFiniteStateMachine.old", "UserFiniteStateMachine.old-copy")


    End Sub


    Private Sub WriteUserConfiguration()

        Dim CodeLine As String
        Dim TagLine As String
        Dim AdrLine As String
        Dim TagSplit() As String

        Dim WriteFile As System.IO.StreamWriter
        'Rename the old file
        My.Computer.FileSystem.RenameFile(ProjectPath & "UserConfiguration.h", "UserConfiguration.old")
        WriteFile = My.Computer.FileSystem.OpenTextFileWriter(ProjectPath & "UserConfiguration.h", True)
        Dim ReadFile As System.IO.StreamReader
        ReadFile = My.Computer.FileSystem.OpenTextFileReader(ProjectPath & "UserConfiguration.old")


        Dim LoopStop As Boolean

        LoopStop = False
        Do While ReadFile.Peek() >= 0 And Not LoopStop
            CodeLine = ReadFile.ReadLine
            WriteFile.WriteLine(CodeLine)
            If InStr(CodeLine, "STARTGENERATION") Then
                LoopStop = True
            End If
        Loop

        'No of pins
        WriteFile.WriteLine("const byte NoInputPins  = " & DigitalIN.Items.Count & ";")
        WriteFile.WriteLine("const byte NoOutputPins = " & DigitalOUT.Items.Count & ";")
        WriteFile.WriteLine("const byte NoUltrasonic = " & Ultrasonics.Items.Count & ";")
        WriteFile.WriteLine("const byte NoAnaInPins  = " & AnalogueIN.Items.Count & ";")
        WriteFile.WriteLine("const byte NoAnaOutPins = " & PWMOutput.Items.Count & ";")
        WriteFile.WriteLine("const byte NoServos     = " & Servos.Items.Count & ";")
        WriteFile.WriteLine("const byte NoTemp       = " & DS18B20s.Items.Count & ";")
        'WriteFile.WriteLine("const byte NoMarkers    = 0;")

        WriteFile.WriteLine("String DummyTags[]      = { """" };")

        'Skip const part, is filled by the writer
        For i As Integer = 1 To 10
            CodeLine = ReadFile.ReadLine
        Next

        TagLine = "String InputTags[]      = { "
        AdrLine = "String InputPins[]      = { "
        For i As Integer = 1 To DigitalIN.Items.Count
            TagSplit = Split(DigitalIN.Items(i - 1), " ")
            TagLine = TagLine & """" & TagSplit(0) & """"
            AdrLine = AdrLine & """" & TagSplit(3) & """"
            If i = DigitalIN.Items.Count Then
                TagLine = TagLine & " };"
                AdrLine = AdrLine & " };"
            Else
                TagLine = TagLine & ","
                AdrLine = AdrLine & ","
            End If
        Next
        If DigitalIN.Items.Count = 0 Then
            TagLine = TagLine & """"" };"
            AdrLine = AdrLine & """"" };"
        End If
        WriteFile.WriteLine(TagLine)
        WriteFile.WriteLine(AdrLine)

        TagLine = "String OutputTags[]     = { "
        AdrLine = "String OutputPins[]     = { "
        For i As Integer = 1 To DigitalOUT.Items.Count
            TagSplit = Split(DigitalOUT.Items(i - 1), " ")
            TagLine = TagLine & """" & TagSplit(0) & """"
            AdrLine = AdrLine & """" & TagSplit(3) & """"
            If i = DigitalOUT.Items.Count Then
                TagLine = TagLine & " };"
                AdrLine = AdrLine & " };"
            Else
                TagLine = TagLine & ","
                AdrLine = AdrLine & ","
            End If
        Next
        If DigitalOUT.Items.Count = 0 Then
            TagLine = TagLine & """"" };"
            AdrLine = AdrLine & """"" };"
        End If
        WriteFile.WriteLine(TagLine)
        WriteFile.WriteLine(AdrLine)

        TagLine = "String AnaInTags[]      = { "
        AdrLine = "String AnaInPins[]      = { "
        For i As Integer = 1 To AnalogueIN.Items.Count
            TagSplit = Split(AnalogueIN.Items(i - 1), " ")
            TagLine = TagLine & """" & TagSplit(0) & """"
            AdrLine = AdrLine & """" & TagSplit(3) & """"
            If i = AnalogueIN.Items.Count Then
                TagLine = TagLine & " };"
                AdrLine = AdrLine & " };"
            Else
                TagLine = TagLine & ","
                AdrLine = AdrLine & ","
            End If
        Next
        If AnalogueIN.Items.Count = 0 Then
            TagLine = TagLine & """"" };"
            AdrLine = AdrLine & """"" };"
        End If
        WriteFile.WriteLine(TagLine)
        WriteFile.WriteLine(AdrLine)

        TagLine = "String AnaOutTags[]     = { "
        AdrLine = "String AnaOutPins[]     = { "
        For i As Integer = 1 To PWMOutput.Items.Count
            TagSplit = Split(PWMOutput.Items(i - 1), " ")
            TagLine = TagLine & """" & TagSplit(0) & """"
            AdrLine = AdrLine & """" & TagSplit(3) & """"
            If i = PWMOutput.Items.Count Then
                TagLine = TagLine & " };"
                AdrLine = AdrLine & " };"
            Else
                TagLine = TagLine & ","
                AdrLine = AdrLine & ","
            End If
        Next
        If PWMOutput.Items.Count = 0 Then
            TagLine = TagLine & """"" };"
            AdrLine = AdrLine & """"" };"
        End If
        WriteFile.WriteLine(TagLine)
        WriteFile.WriteLine(AdrLine)

        TagLine = "String ServoTags[]      = { "
        AdrLine = "String ServoPins[]      = { "
        For i As Integer = 1 To Servos.Items.Count
            TagSplit = Split(Servos.Items(i - 1), " ")
            TagLine = TagLine & """" & TagSplit(0) & """"
            AdrLine = AdrLine & """" & TagSplit(3) & """"
            If i = Servos.Items.Count Then
                TagLine = TagLine & " };"
                AdrLine = AdrLine & " };"
            Else
                TagLine = TagLine & ","
                AdrLine = AdrLine & ","
            End If
        Next
        If Servos.Items.Count = 0 Then
            TagLine = TagLine & """"" };"
            AdrLine = AdrLine & """"" };"
        End If
        WriteFile.WriteLine(TagLine)
        WriteFile.WriteLine(AdrLine)

        TagLine = "String UltraTags[]      = { "
        AdrLine = "String UltraPins[]      = { "
        For i As Integer = 1 To Ultrasonics.Items.Count
            TagSplit = Split(Ultrasonics.Items(i - 1), " ")
            TagLine = TagLine & """" & TagSplit(0) & """"
            AdrLine = AdrLine & """" & TagSplit(2) & """,""" & TagSplit(4) & """"
            If i = Ultrasonics.Items.Count Then
                TagLine = TagLine & " };"
                AdrLine = AdrLine & " };"
            Else
                TagLine = TagLine & ","
                AdrLine = AdrLine & ","
            End If
        Next
        If Ultrasonics.Items.Count = 0 Then
            TagLine = TagLine & """"" };"
            AdrLine = AdrLine & """"" };"
        End If
        WriteFile.WriteLine(TagLine)
        WriteFile.WriteLine(AdrLine)

        TagLine = "String TempTags[]       = { "
        AdrLine = "String TempPins[]       = { "
        Dim OneChannelNumber As String = ""
        For i As Integer = 1 To DS18B20s.Items.Count
            TagSplit = Split(DS18B20s.Items(i - 1), " ")
            TagLine = TagLine & """" & TagSplit(0) & """"
            If i = 1 Then
                AdrLine = AdrLine & """" & TagSplit(2) & """ };"
                OneChannelNumber = TagSplit(2).Substring(3)
            End If
            If i = DS18B20s.Items.Count Then
                TagLine = TagLine & " };"
            Else
                TagLine = TagLine & ","
            End If
        Next
        If DS18B20s.Items.Count = 0 Then
            TagLine = TagLine & """"" };"
            AdrLine = AdrLine & """"" };"
            WriteFile.WriteLine("const byte OneWireChannel = 0;")
        Else
            WriteFile.WriteLine("const byte OneWireChannel = " & OneChannelNumber & ";")
        End If
        WriteFile.WriteLine(TagLine)
        WriteFile.WriteLine(AdrLine)
        'WriteFile.WriteLine("String MarkerTags[]     = { """" };")

        LoopStop = False
        Do While ReadFile.Peek() >= 0 And Not LoopStop
            CodeLine = ReadFile.ReadLine
            If InStr(CodeLine, "ENDGENERATION") Then
                WriteFile.WriteLine(CodeLine)
                LoopStop = True
            End If
        Loop

        LoopStop = False
        Do While ReadFile.Peek() >= 0 And Not LoopStop
            CodeLine = ReadFile.ReadLine
            WriteFile.WriteLine(CodeLine)
            If InStr(CodeLine, "STARTGENERATION") Then
                LoopStop = True
            End If
        Loop

        AdrLine = "String PossibleFSMStates[] = { ""START"","
        For I As Integer = 1 To FiniteStatesListBox.Items.Count
            AdrLine = AdrLine & """" & FiniteStatesListBox.Items(I - 1) & ""","
        Next
        AdrLine = AdrLine & """END"" };"
        WriteFile.WriteLine(AdrLine)

        LoopStop = False
        Do While ReadFile.Peek() >= 0 And Not LoopStop
            CodeLine = ReadFile.ReadLine
            If InStr(CodeLine, "ENDGENERATION") Then
                LoopStop = True
                WriteFile.WriteLine(CodeLine)
            End If
        Loop

        LoopStop = False
        Do While ReadFile.Peek() >= 0 And Not LoopStop
            CodeLine = ReadFile.ReadLine
            WriteFile.WriteLine(CodeLine)
            If InStr(CodeLine, "STARTGENERATION") Then
                LoopStop = True
            End If
        Loop

        AdrLine = "boolean UseI2C = "
        If CBUseI2C.Checked Then
            AdrLine = AdrLine & "true;"
        Else
            AdrLine = AdrLine & "false;"
        End If
        WriteFile.WriteLine(AdrLine)

        AdrLine = "boolean UseHMISerial = "
        If CBUseHMISerial.Checked Then
            AdrLine = AdrLine & "true;"
        Else
            AdrLine = AdrLine & "false;"
        End If
        WriteFile.WriteLine(AdrLine)

        AdrLine = "boolean UseGPS = "
        If CBUseGPS.Checked Then
            AdrLine = AdrLine & "true;"
        Else
            AdrLine = AdrLine & "false;"
        End If
        WriteFile.WriteLine(AdrLine)

        AdrLine = "boolean UseIntercard = "
        If CBUseIntercard.Checked Then
            AdrLine = AdrLine & "true;"
        Else
            AdrLine = AdrLine & "false;"
        End If
        WriteFile.WriteLine(AdrLine)

        LoopStop = False
        Do While ReadFile.Peek() >= 0 And Not LoopStop
            CodeLine = ReadFile.ReadLine
            If InStr(CodeLine, "ENDGENERATION") Then
                LoopStop = True
                WriteFile.WriteLine(CodeLine)
            End If
        Loop

        Do While ReadFile.Peek() >= 0
            CodeLine = ReadFile.ReadLine
            WriteFile.WriteLine(CodeLine)
        Loop

        WriteFile.Close()
        ReadFile.Close()

        If My.Computer.FileSystem.FileExists(ProjectPath & "UserConfiguration.old-copy") Then
            My.Computer.FileSystem.DeleteFile(ProjectPath & "UserConfiguration.old-copy")
        End If
        My.Computer.FileSystem.RenameFile(ProjectPath & "UserConfiguration.old", "UserConfiguration.old-copy")

        'MsgBox("New I/O Configuration created")

    End Sub

    Private Sub GenConfig_Click(sender As Object, e As EventArgs) Handles GenConfig.Click
        WriteUserConfiguration()
        WriteUserFiniteStateMachine()
        LogBox.Items.Add("New UserConfiguration.h and UserFiniteStateMachine.h writen")
        LogBox.Items.Add("Button for generation of new files is now blocked.")
        GenConfig.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonServo.Click
        Servos.Items.Add(Servo.Text)
        Servo.Text = ""
    End Sub

    Private Sub ButtonDS18B20_Click(sender As Object, e As EventArgs) Handles ButtonDS18B20.Click
        Dim TxtStrings() As String
        Dim TempChannel As String = ""
        DS18B20s.Items.Add(DS18B20.Text)
        DS18B20.Text = ""
        'Look for a tag with an address and if found save the address
        For i As Integer = 0 To DS18B20s.Items.Count - 1
            If InStr(DS18B20s.Items(i), " channel ") <> 0 Then
                TxtStrings = Split(DS18B20s.Items(i))
                TempChannel = TxtStrings(2)
            End If
        Next
        'Copy the address to non coupled tags
        For i As Integer = 0 To DS18B20s.Items.Count - 1
            If InStr(DS18B20s.Items(i), " channel ") = 0 And TempChannel <> "" Then
                DS18B20s.Items(i) = DS18B20s.Items(i) & " channel " & TempChannel
            End If
        Next

    End Sub

    Private Function CheckFiniteState(FiniteState As String, extent As String) As Boolean

        Dim CodeLine As String
        Dim SplitCodeLine() As String
        Dim ReadFile As IO.StreamReader
        Dim Found As Boolean

        Found = False
        ReadFile = My.Computer.FileSystem.OpenTextFileReader(ProjectPath & "UserFiniteStateMachine." & extent)
        Do While ReadFile.Peek() >= 0
            CodeLine = ReadFile.ReadLine
            If InStr(CodeLine, "MachineState == FiniteState(") Then
                SplitCodeLine = Split(CodeLine, """")
                If SplitCodeLine(1) = FiniteState Then Found = True
            End If
        Loop
        ReadFile.Close()
        Return Found

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGetMetadata.Click

        Dim CodeLine As String
        Dim SplitStringTags() As String
        Dim SplitStringPins() As String

        ButtonGetMetadata.Enabled = False

        Dim ReadFile As IO.StreamReader
        ReadFile = My.Computer.FileSystem.OpenTextFileReader(ProjectPath & "UserConfiguration.h")

        Do While ReadFile.Peek() >= 0
            CodeLine = ReadFile.ReadLine

            If InStr(CodeLine, "InputTags") Then
                SplitStringTags = Split(CodeLine, """")
                CodeLine = ReadFile.ReadLine 'read the pins
                SplitStringPins = Split(CodeLine, """")
                If SplitStringTags(1) <> "" Then
                    For i As Integer = 1 To SplitStringTags.Count \ 2
                        DigitalIN.Items.Add(SplitStringTags(i * 2 - 1) & " on pin " & SplitStringPins(i * 2 - 1))
                        IOCollection.Items.Remove(SplitStringPins(i * 2 - 1))
                    Next
                End If
            End If

            If InStr(CodeLine, "OutputTags") Then
                SplitStringTags = Split(CodeLine, """")
                CodeLine = ReadFile.ReadLine 'read the pins
                SplitStringPins = Split(CodeLine, """")
                If SplitStringTags(1) <> "" Then
                    For i As Integer = 1 To SplitStringTags.Count \ 2
                        DigitalOUT.Items.Add(SplitStringTags(i * 2 - 1) & " on pin " & SplitStringPins(i * 2 - 1))
                        IOCollection.Items.Remove(SplitStringPins(i * 2 - 1))
                    Next
                End If
            End If

            If InStr(CodeLine, "AnaInTags") Then
                SplitStringTags = Split(CodeLine, """")
                CodeLine = ReadFile.ReadLine 'read the pins
                SplitStringPins = Split(CodeLine, """")
                If SplitStringTags(1) <> "" Then
                    For i As Integer = 1 To SplitStringTags.Count \ 2
                        AnalogueIN.Items.Add(SplitStringTags(i * 2 - 1) & " on pin " & SplitStringPins(i * 2 - 1))
                        IOCollection.Items.Remove(SplitStringPins(i * 2 - 1))
                    Next
                End If
            End If

            If InStr(CodeLine, "AnaOutTags") Then
                SplitStringTags = Split(CodeLine, """")
                CodeLine = ReadFile.ReadLine 'read the pins
                SplitStringPins = Split(CodeLine, """")
                If SplitStringTags(1) <> "" Then
                    For i As Integer = 1 To SplitStringTags.Count \ 2
                        PWMOutput.Items.Add(SplitStringTags(i * 2 - 1) & " on pin " & SplitStringPins(i * 2 - 1))
                        IOCollection.Items.Remove(SplitStringPins(i * 2 - 1))
                    Next
                End If
            End If

            If InStr(CodeLine, "ServoTags") Then
                SplitStringTags = Split(CodeLine, """")
                CodeLine = ReadFile.ReadLine 'read the pins
                SplitStringPins = Split(CodeLine, """")
                If SplitStringTags(1) <> "" Then
                    For i As Integer = 1 To SplitStringTags.Count \ 2
                        Servos.Items.Add(SplitStringTags(i * 2 - 1) & " on pin " & SplitStringPins(i * 2 - 1))
                        IOCollection.Items.Remove(SplitStringPins(i * 2 - 1))
                    Next
                End If
            End If


            If InStr(CodeLine, "UltraTags") Then
                SplitStringTags = Split(CodeLine, """")
                CodeLine = ReadFile.ReadLine 'read the pins
                SplitStringPins = Split(CodeLine, """")
                Dim ExtraPos As Integer = -2
                If (SplitStringPins.Count > 3) Then
                    For i As Integer = 1 To SplitStringTags.Count \ 2
                        ExtraPos = ExtraPos + 2
                        Ultrasonics.Items.Add(SplitStringTags(i * 2 - 1) & " trigger " & SplitStringPins(i * 2 - 1 + ExtraPos) & " echo " & SplitStringPins(i * 2 + 1 + ExtraPos))
                        IOCollection.Items.Remove(SplitStringPins(i * 2 - 1 + ExtraPos))
                        IOCollection.Items.Remove(SplitStringPins(i * 2 + 1 + ExtraPos))
                    Next
                End If
            End If

            If InStr(CodeLine, "TempTags") Then
                SplitStringTags = Split(CodeLine, """")
                CodeLine = ReadFile.ReadLine 'read the pins
                SplitStringPins = Split(CodeLine, """")
                If SplitStringTags(1) <> "" Then
                    For i As Integer = 1 To SplitStringTags.Count \ 2
                        DS18B20s.Items.Add(SplitStringTags(i * 2 - 1) & " channel " & SplitStringPins(1))
                        IOCollection.Items.Remove(SplitStringPins(1))
                    Next
                End If
            End If

            If InStr(CodeLine, "PossibleFSMStates") Then
                SplitStringTags = Split(CodeLine, """,""")
                For i As Integer = 1 To SplitStringTags.Count - 2
                    FiniteStatesListBox.Items.Add(SplitStringTags(i))
                Next
            End If

            If InStr(CodeLine, "UseI2C") Then
                SplitStringTags = Split(CodeLine, " ")
                If SplitStringTags(3) = "false;" Then
                    CBUseI2C.Checked = False
                Else
                    CBUseI2C.Checked = True
                End If
            End If

            If InStr(CodeLine, "UseHMISerial") Then
                SplitStringTags = Split(CodeLine, " ")
                If SplitStringTags(3) = "false;" Then
                    CBUseHMISerial.Checked = False
                Else
                    CBUseHMISerial.Checked = True
                End If
            End If

            If InStr(CodeLine, "UseGPS") Then
                SplitStringTags = Split(CodeLine, " ")
                If SplitStringTags(3) = "false;" Then
                    CBUseGPS.Checked = False
                Else
                    CBUseGPS.Checked = True
                End If
            End If

            If InStr(CodeLine, "UseIntercard") Then
                SplitStringTags = Split(CodeLine, " ")
                If SplitStringTags(3) = "false;" Then
                    CBUseIntercard.Checked = False
                Else
                    CBUseIntercard.Checked = True
                End If
            End If
        Loop

        ReadFile.Close()
        MsgBox("Read I/O Configuration completed")
        LogBox.Items.Add("Read the previous configuration")

    End Sub

    Private Sub AFSMConfigurator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SubProjectPath() As String
        Dim NoSubProjectPath As Integer

        ProjectPath = My.Application.Info.DirectoryPath()
        SubProjectPath = Split(ProjectPath, "\")

        NoSubProjectPath = SubProjectPath.Length() - 2
        ProjectPath = SubProjectPath(0)
        For i As Integer = 1 To NoSubProjectPath - 2
            ProjectPath = ProjectPath & "\" & SubProjectPath(i)
        Next
        ProjectPath = ProjectPath & "\"

        ProjectPathName.Text = ProjectPath
        LogBox.Items.Add("Path to project files: " & ProjectPath)
        LogBox.Items.Add("For adjusting the configuration press the Get old Configuration button")

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub AddState_Click(sender As Object, e As EventArgs) Handles AddState.Click
        If NewState.Text <> "" Then
            FiniteStatesListBox.Items.Add(NewState.Text)
            NewState.Text = ""
        End If
    End Sub

    Private Sub CBUseI2C_CheckedChanged(sender As Object, e As EventArgs) Handles CBUseI2C.CheckedChanged
        LogBox.Items.Add("I2C communication is set to " & CBUseI2C.Checked)
    End Sub

    Private Sub CBUseHMISerial_CheckedChanged(sender As Object, e As EventArgs) Handles CBUseHMISerial.CheckedChanged
        LogBox.Items.Add("Serial HMI communication is set to " & CBUseHMISerial.Checked)
    End Sub

    Private Sub CBUseGPS_CheckedChanged(sender As Object, e As EventArgs) Handles CBUseGPS.CheckedChanged
        LogBox.Items.Add("GPS device connected via TX3 is " & CBUseGPS.Checked)
    End Sub

    Private Sub CBUseIntercard_CheckedChanged(sender As Object, e As EventArgs) Handles CBUseIntercard.CheckedChanged
        LogBox.Items.Add("Intercard communication is " & CBUseIntercard.Checked)
    End Sub

End Class
