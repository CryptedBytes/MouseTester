Public Class Form1
    Dim debugActive = True



    Dim timePassedValue As Integer = 0
    Dim timePassedValueLEFT As Integer = 0
    Dim timePassedValueRIGHT As Integer = 0
    Dim resetValues As Boolean = False
    Dim firstTimeMID As Boolean = True
    Dim firstTimeLEFT As Boolean = True
    Dim firstTimeRIGHT As Boolean = True
    Dim scrollCount As Integer = 0
    Dim useExperimentalSecond2MinuteConversation As Boolean = False
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Dim warnedUser As Boolean = False
    Dim initializedInterface As Boolean = False

    Dim latencyTest_firstLeftData As Integer = 0
    Dim latencyTest_lastLeftData As Integer = 0
    Dim latencyTest_firstLeftRecordedBOOL As Boolean = False
    Dim latencyTest_lastLeftRecordedBOOL As Boolean = False
    Dim latencyTest_rawResultAvailable As Boolean = False
    Dim latencyTest_processedResultData As Integer
    Dim latencyTest_leftMouseButtonLatencyArithmeticAverageData As Integer
    Public latencyTest_fullHistoryOfProcessedDataARRAY As List(Of Integer)
    Dim latencyTest_rawMediumData As Integer




    Private Sub incrementMIDValue()

        If firstTimeMID = True Then
            clickCountLabelMID.Text = "1"
            firstTimeMID = False
            Debug.WriteLine("first middle mouse click event received.")
        Else
            clickCountLabelMID.Text = clickCountLabelMID.Text + 1
            Debug.WriteLine("middle mouse click event received.")
        End If

    End Sub

    Private Sub incrementLEFTValue()

        If firstTimeLEFT = True Then
            clickCountLabelLEFT.Text = "1"
            firstTimeLEFT = False
            Debug.WriteLine("first left mouse click event received.")
        Else
            clickCountLabelLEFT.Text = clickCountLabelLEFT.Text + 1
            Debug.WriteLine("left mouse click event received.")
        End If

    End Sub


    Private Sub incrementRIGHTValue()

        If firstTimeRIGHT = True Then
            clickCountLabelRIGHT.Text = "1"
            firstTimeRIGHT = False
            Debug.WriteLine("first right mouse click event received.")
        Else
            clickCountLabelRIGHT.Text = clickCountLabelRIGHT.Text + 1
            Debug.WriteLine("right mouse click event received.")
        End If

    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown



        If e.Button = MouseButtons.Middle Then
            incrementMIDValue()
        ElseIf e.Button = MouseButtons.Left Then
            incrementLEFTValue()
        ElseIf e.Button = MouseButtons.Right Then
            incrementRIGHTValue()
        Else
            MsgBox("Unknown mouse event received.")


        End If


    End Sub

    Private Sub timingEngine_Tick(sender As Object, e As EventArgs) Handles timingEngineMID.Tick

        timePassedValue = timePassedValue + 1
        Debug.WriteLine("one more second from your life has just passed. current value is:" & timePassedValue)

    End Sub

    Private Sub UIEngine_Tick(sender As Object, e As EventArgs) Handles UIEngine.Tick




        If useExperimentalSecond2MinuteConversation = True Then

            '  If timePassedValue > 60 And timePassedLabel.Text.Contains("sec") Then

            '            timePassedLabel.Text = "Last click was received " & timePassedValue / 60 & " minutes ago."
            '       Else
            '          timePassedLabel.Text = "Last click was received " & timePassedValue & " seconds ago."

            ' End If

        Else
            lastClickTimeLabelLEFT.Text = "It's been " & timePassedValueLEFT & " seconds since last click received."
            lastClickTimeLabelMID.Text = "It's been " & timePassedValue & " seconds since last click received."
            lastClickTimeLabelRIGHT.Text = "It's been " & timePassedValueRIGHT & " seconds since last click received."
        End If






        If GetActiveWindow = Me.Handle Then
            focusLostLabel.Visible = Not True
        Else


            focusLostLabel.Visible = True
        End If




    End Sub



    Private Sub Label1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        If e.Button = MouseButtons.Middle Then
            MsgBox("In order to reset the counter, click this reset link with left mouse button.", MsgBoxStyle.Information, "Possible mistaken click")
        Else
            firstTimeMID = True
            '  counterLabel.Text = "00"
        End If


    End Sub

    Private Sub focusLostLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles focusLostLabel.MouseDown
        If e.Button = MouseButtons.Middle Then
            incrementMIDValue()
        ElseIf e.Button = MouseButtons.Left Then
            incrementLEFTValue()
        ElseIf e.Button = MouseButtons.Right Then
            incrementRIGHTValue()
        Else
            MsgBox("Unknown mouse event received.")


        End If

    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Middle Then
            incrementMIDValue()
        ElseIf e.Button = MouseButtons.Left Then
            incrementLEFTValue()
        ElseIf e.Button = MouseButtons.Right Then
            incrementRIGHTValue()
        Else
            MsgBox("Unknown mouse event received.")


        End If

    End Sub

    Private Sub timePassedLabel_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Middle Then
            incrementMIDValue()
        ElseIf e.Button = MouseButtons.Left Then
            incrementLEFTValue()
        ElseIf e.Button = MouseButtons.Right Then
            incrementRIGHTValue()
        Else
            MsgBox("Unknown mouse event received.")


        End If

    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Middle Then
            incrementMIDValue()
        ElseIf e.Button = MouseButtons.Left Then
            incrementLEFTValue()
        ElseIf e.Button = MouseButtons.Right Then
            incrementRIGHTValue()
        Else
            MsgBox("Unknown mouse event received.")


        End If

    End Sub

    Private Sub counterLabel_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Middle Then
            incrementMIDValue()
        ElseIf e.Button = MouseButtons.Left Then
            incrementLEFTValue()
        ElseIf e.Button = MouseButtons.Right Then
            incrementRIGHTValue()
        Else
            MsgBox("Unknown mouse event received.")


        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        focusLostLabel.Location = New Point(535, 9)
        Size = New Size(1920, 1080)
        WindowState = FormWindowState.Maximized
        Button1.Visible = False
        '  scrollTestPanel.Location = New Point(1666, 967)
        initializedInterface = True


        If debugActive = False Then
            If CheckBox1.Checked = True Then
                TopMost = True
            Else
                TopMost = Not True
            End If

        Else
            TopMost = False
            debugTopmostWarn.Visible = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim itemNumber As Integer = 0
        Do Until ListBox1.Items.Count = 256
            ListBox1.Items.Add("Item " & itemNumber)
            itemNumber = itemNumber + 1
        Loop
        Button1.Visible = False

    End Sub

    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel, Panel3.MouseClick
        If e.Delta > 0 Then
            scrollDirectionLabel.Text = "Mouse scroll direction: UP"
            scrollCount = scrollCount + 1
            scrollCountLabel.Text = "You've scrolled " & scrollCount & " lines!"
        ElseIf e.Delta < 0 Then
            scrollDirectionLabel.Text = "Mouse scroll direction: DOWN"

            scrollCount = scrollCount + 1
            scrollCountLabel.Text = "You've scrolled " & scrollCount & " lines!"
        Else
            scrollDirectionLabel.Text = "Mouse scroll direction: ERROR"
        End If
    End Sub

    Private Sub ListBox1_MouseWhell(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseWheel
        If e.Delta > 0 Then
            scrollDirectionLabel.Text = "Mouse scroll direction: UP"
            scrollCount = scrollCount + 1
            scrollCountLabel.Text = "You've scrolled " & scrollCount & " lines!"
        ElseIf e.Delta < 0 Then
            scrollDirectionLabel.Text = "Mouse scroll direction: DOWN"

            scrollCount = scrollCount + 1
            scrollCountLabel.Text = "You've scrolled " & scrollCount & " lines!"
        Else
            scrollDirectionLabel.Text = "Mouse scroll direction: ERROR"
        End If

    End Sub

    Private Sub scrollCountLabel_TextChanged(sender As Object, e As EventArgs) Handles scrollCountLabel.TextChanged

        If scrollCount < 1 Then
        Else
            scrollTestPanel.Visible = False
        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TopMost = False
        Close()
    End Sub


    Private Sub timingEngineLEFT_Tick(sender As Object, e As EventArgs) Handles timingEngineLEFT.Tick
        timePassedValueLEFT = timePassedValueLEFT + 1
    End Sub

    Private Sub timingEngineRIGHT_Tick(sender As Object, e As EventArgs) Handles timingEngineRIGHT.Tick
        timePassedValueRIGHT = timePassedValueRIGHT + 1
    End Sub


    Private Sub clickCountLabelLEFT_TextChanged(sender As Object, e As EventArgs) Handles clickCountLabelLEFT.TextChanged



        If clickCountLabelLEFT.Text = "00" Or "0" Then

        Else
            timingEngineLEFT.Stop()
            lastClickTimeLabelLEFT.Text = "It's been 0 seconds since last click received."
            timePassedValueLEFT = 0
            timingEngineLEFT.Start()
            LatencyTestPanel.Visible = True
        End If


        Debug.WriteLine("left text changed event hit")


        If clickCountLabelLEFT.Text IsNot "00" Then

            If latencyTest_firstLeftRecordedBOOL = False Then

                latencyTest_firstLeftData = My.Computer.Clock.LocalTime.Millisecond
                latencyTest_firstLeftRecordedBOOL = True

            Else

                latencyTest_lastLeftData = My.Computer.Clock.LocalTime.Millisecond
                latencyTest_lastLeftRecordedBOOL = True
            End If


        End If

        If latencyTest_lastLeftRecordedBOOL = True Then
            latencyTest_rawResultAvailable = True
            latencyTestLabel_firstLeftRegisterTime.Text = latencyTest_firstLeftData
            latencyTestLabel_lastLeftRegisterTime.Text = latencyTest_lastLeftData
            latencyTest_processedResultData = latencyTest_lastLeftData - latencyTest_firstLeftData


            If latencyTest_processedResultData.ToString.Contains("-") Then
                'discard this result.
                latencyTestLabel_leftMouseButtonLatencyResult.Text = "Computing error. Please press faster."

            Else

                If latencyTest_processedResultData > 0 Then


                    latencyTest_fullHistoryOfProcessedDataListBox.Items.Add(latencyTest_processedResultData)
                    latencyTestLabel_leftMouseButtonLatencyResult.Text = latencyTest_processedResultData.ToString & " ms"
                End If


            End If

            If latencyTest_fullHistoryOfProcessedDataListBox.Items.Count > 5 Then
                ' latencyTest_leftMouseButtonLatencyArithmeticAverageData = 

                For Each mediumData In latencyTest_fullHistoryOfProcessedDataListBox.Items
                    ' Console.WriteLine(mediumData.ToString)
                    latencyTest_rawMediumData = latencyTest_rawMediumData + mediumData
                Next

                latencyTest_leftMouseButtonLatencyArithmeticAverageData = latencyTest_rawMediumData / latencyTest_fullHistoryOfProcessedDataListBox.Items.Count
                latencyTestLabel_leftMouseButtonLatencyArithmeticAverage.Text = latencyTest_leftMouseButtonLatencyArithmeticAverageData & " ms*"
            Else
                latencyTestLabel_leftMouseButtonLatencyArithmeticAverage.Text = "Waiting for more data..."
            End If







            'RESET ALL DATA NOW: 'deprecated, use method call

            'latencyTest_firstLeftData = 0
            'latencyTest_lastLeftData = 0
            'latencyTest_firstLeftRecordedBOOL = False
            'latencyTest_lastLeftRecordedBOOL = False
            'latencyTest_rawResultAvailable = False
            'latencyTest_processedResultData = 0


            resetLatencyTest()

        End If

    End Sub


    Private Sub clickCountLabelMID_TextChanged(sender As Object, e As EventArgs) Handles clickCountLabelMID.TextChanged
        If clickCountLabelMID.Text = "00" Or "0" Then

        Else
            timingEngineMID.Stop()
            lastClickTimeLabelMID.Text = "It's been 0 seconds since last click received."

            timePassedValue = 0
            timingEngineMID.Start()

        End If


        Debug.WriteLine("right text changed event hit")

    End Sub

    Private Sub clickCountLabelRIGHT_TextChanged(sender As Object, e As EventArgs) Handles clickCountLabelRIGHT.TextChanged
        If clickCountLabelRIGHT.Text = "00" Or "0" Then

        Else
            timingEngineRIGHT.Stop()
            lastClickTimeLabelRIGHT.Text = "It's been 0 seconds since last click received."

            timePassedValueRIGHT = 0
            timingEngineRIGHT.Start()

        End If


        Debug.WriteLine("right text changed event hit")
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If initializedInterface = True Then
            If Size.Width.ToString = "1932" Then

            Else

                WindowState = FormWindowState.Maximized
                If warnedUser = True Then

                Else
                    MsgBox("This application MUST be used with maximized window state and focus. Else, it won't work. Click OK to automatically set size and continue. No future warnings will be shown.", MsgBoxStyle.Information, "Size alteration is forbidden")
                    warnedUser = True
                End If


            End If
        Else

        End If

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        If e.Button = MouseButtons.Middle Then
            incrementMIDValue()
        ElseIf e.Button = MouseButtons.Left Then
            incrementLEFTValue()
        ElseIf e.Button = MouseButtons.Right Then
            incrementRIGHTValue()
        Else
            MsgBox("Unknown mouse event received.")


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clickCountLabelLEFT.Text = "00"
        clickCountLabelMID.Text = "00"
        clickCountLabelRIGHT.Text = "00"

        timingEngineLEFT.Stop()
        timingEngineMID.Stop()
        timingEngineRIGHT.Stop()

        timePassedValue = 0
        timePassedValueLEFT = 0
        timePassedValueRIGHT = 0
        'timingEngineLEFT.Start()
        'timingEngineMID.Start()
        'timingEngineRIGHT.Start()

        resetLatencyTest()


    End Sub

    Private Sub Panel6_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel6.MouseDown
        If e.Button = MouseButtons.Middle Then
            incrementMIDValue()
        ElseIf e.Button = MouseButtons.Left Then
            incrementLEFTValue()
        ElseIf e.Button = MouseButtons.Right Then
            incrementRIGHTValue()
        Else
            MsgBox("Unknown mouse event received.")


        End If
    End Sub

    Private Sub Panel5_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel5.MouseDown
        If e.Button = MouseButtons.Middle Then
            incrementMIDValue()
        ElseIf e.Button = MouseButtons.Left Then
            incrementLEFTValue()
        ElseIf e.Button = MouseButtons.Right Then
            incrementRIGHTValue()
        Else
            MsgBox("Unknown mouse event received.")


        End If
    End Sub

    Private Sub LatencyTestLabel_leftMouseButtonLatencyResult_Click(sender As Object, e As EventArgs) Handles latencyTestLabel_leftMouseButtonLatencyResult.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If debugActive = False Then
            If CheckBox1.Checked = True Then
                TopMost = True
            Else
                TopMost = Not True
            End If

        Else
            TopMost = False
            debugTopmostWarn.Visible = True

        End If

    End Sub


    Private Sub resetLatencyTest()
        latencyTest_firstLeftData = 0
        latencyTest_lastLeftData = 0
        latencyTest_firstLeftRecordedBOOL = False
        latencyTest_lastLeftRecordedBOOL = False
        latencyTest_rawResultAvailable = False
        latencyTest_processedResultData = 0
        latencyTest_rawMediumData = 0

    End Sub
    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        resetLatencyTest()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Restart()
    End Sub

    Private Sub CursorPosTimer_Tick(sender As Object, e As EventArgs) Handles CursorPosTimer.Tick
        cursorPosLabel.Text = Cursor.Position.X.ToString + ", " + Cursor.Position.Y.ToString
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CursorPosTimer.Interval = 1
        Else
            CursorPosTimer.Interval = 100
        End If
    End Sub
End Class
