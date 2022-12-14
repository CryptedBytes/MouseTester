<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timingEngineMID = New System.Windows.Forms.Timer(Me.components)
        Me.UIEngine = New System.Windows.Forms.Timer(Me.components)
        Me.focusLostLabel = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.scrollDirectionLabel = New System.Windows.Forms.Label()
        Me.scrollCountLabel = New System.Windows.Forms.Label()
        Me.scrollTestPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lastClickTimeLabelLEFT = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.clickCountLabelLEFT = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lastClickTimeLabelMID = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.clickCountLabelMID = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lastClickTimeLabelRIGHT = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.clickCountLabelRIGHT = New System.Windows.Forms.Label()
        Me.timingEngineLEFT = New System.Windows.Forms.Timer(Me.components)
        Me.timingEngineRIGHT = New System.Windows.Forms.Timer(Me.components)
        Me.latencyTestLabel_firstLeftRegisterTime = New System.Windows.Forms.Label()
        Me.latencyTestLabel_lastLeftRegisterTime = New System.Windows.Forms.Label()
        Me.latencyTestLabel_leftMouseButtonLatencyResult = New System.Windows.Forms.Label()
        Me.LatencyTestPanel = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.latencyTestLabel_leftMouseButtonLatencyArithmeticAverage = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.debugTopmostWarn = New System.Windows.Forms.Label()
        Me.latencyTest_fullHistoryOfProcessedDataListBox = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cursorPosLabel = New System.Windows.Forms.Label()
        Me.CursorPosTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.scrollTestPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.LatencyTestPanel.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'timingEngineMID
        '
        Me.timingEngineMID.Interval = 1000
        '
        'UIEngine
        '
        Me.UIEngine.Enabled = True
        Me.UIEngine.Interval = 500
        '
        'focusLostLabel
        '
        Me.focusLostLabel.AutoSize = True
        Me.focusLostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.focusLostLabel.ForeColor = System.Drawing.Color.Red
        Me.focusLostLabel.Location = New System.Drawing.Point(-876, -8)
        Me.focusLostLabel.Name = "focusLostLabel"
        Me.focusLostLabel.Size = New System.Drawing.Size(913, 25)
        Me.focusLostLabel.TabIndex = 7
        Me.focusLostLabel.Text = "WARNING: Focus is required to be able to test this mouse! Please click anywhere i" &
    "n this form."
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(949, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(222, 44)
        Me.ListBox1.TabIndex = 9
        Me.ListBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 10.25!)
        Me.Button1.Location = New System.Drawing.Point(1644, 970)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 69)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Populate ListBox with items and start mouse scroll whell testing"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'scrollDirectionLabel
        '
        Me.scrollDirectionLabel.AutoSize = True
        Me.scrollDirectionLabel.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scrollDirectionLabel.Location = New System.Drawing.Point(1663, 977)
        Me.scrollDirectionLabel.Name = "scrollDirectionLabel"
        Me.scrollDirectionLabel.Size = New System.Drawing.Size(193, 20)
        Me.scrollDirectionLabel.TabIndex = 11
        Me.scrollDirectionLabel.Text = "Mouse scroll direction: NONE"
        '
        'scrollCountLabel
        '
        Me.scrollCountLabel.AutoSize = True
        Me.scrollCountLabel.Font = New System.Drawing.Font("Segoe UI Light", 11.25!)
        Me.scrollCountLabel.Location = New System.Drawing.Point(1663, 997)
        Me.scrollCountLabel.Name = "scrollCountLabel"
        Me.scrollCountLabel.Size = New System.Drawing.Size(180, 20)
        Me.scrollCountLabel.TabIndex = 12
        Me.scrollCountLabel.Text = "You've scrolled NULL lines! "
        '
        'scrollTestPanel
        '
        Me.scrollTestPanel.Controls.Add(Me.Label4)
        Me.scrollTestPanel.Controls.Add(Me.Label1)
        Me.scrollTestPanel.Location = New System.Drawing.Point(1660, 250)
        Me.scrollTestPanel.Name = "scrollTestPanel"
        Me.scrollTestPanel.Size = New System.Drawing.Size(200, 66)
        Me.scrollTestPanel.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(16, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "testing mouse scroll whell" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Use the scroll whell to start"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lastClickTimeLabelLEFT)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 567)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(128, 450)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 28)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "clicks received"
        '
        'lastClickTimeLabelLEFT
        '
        Me.lastClickTimeLabelLEFT.AutoSize = True
        Me.lastClickTimeLabelLEFT.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.lastClickTimeLabelLEFT.Location = New System.Drawing.Point(16, 508)
        Me.lastClickTimeLabelLEFT.Name = "lastClickTimeLabelLEFT"
        Me.lastClickTimeLabelLEFT.Size = New System.Drawing.Size(374, 28)
        Me.lastClickTimeLabelLEFT.TabIndex = 9
        Me.lastClickTimeLabelLEFT.Text = "It's been 00 seconds since last click received"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 25.0!)
        Me.Label7.Location = New System.Drawing.Point(29, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(337, 46)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "LEFT MOUSE BUTTON"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(6, 19)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(384, 528)
        Me.Panel4.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.clickCountLabelLEFT)
        Me.Panel5.Location = New System.Drawing.Point(8, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(384, 509)
        Me.Panel5.TabIndex = 12
        '
        'clickCountLabelLEFT
        '
        Me.clickCountLabelLEFT.Font = New System.Drawing.Font("Microsoft Sans Serif", 78.0!, System.Drawing.FontStyle.Bold)
        Me.clickCountLabelLEFT.Location = New System.Drawing.Point(55, 320)
        Me.clickCountLabelLEFT.Name = "clickCountLabelLEFT"
        Me.clickCountLabelLEFT.Size = New System.Drawing.Size(242, 114)
        Me.clickCountLabelLEFT.TabIndex = 9
        Me.clickCountLabelLEFT.Text = "00"
        Me.clickCountLabelLEFT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(6, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(239, 43)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "RESET ALL VALUES"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(1631, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 203)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "APPLICATION CONTROLLER"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Magenta
        Me.Button4.Location = New System.Drawing.Point(6, 77)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(239, 43)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "RESTART SESSION"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(6, 180)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(107, 17)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Enable Top Most"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(239, 43)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "TERMINATE SESSION"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lastClickTimeLabelMID)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.clickCountLabelMID)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Location = New System.Drawing.Point(612, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(410, 567)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(128, 450)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 28)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "clicks received"
        '
        'lastClickTimeLabelMID
        '
        Me.lastClickTimeLabelMID.AutoSize = True
        Me.lastClickTimeLabelMID.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.lastClickTimeLabelMID.Location = New System.Drawing.Point(16, 508)
        Me.lastClickTimeLabelMID.Name = "lastClickTimeLabelMID"
        Me.lastClickTimeLabelMID.Size = New System.Drawing.Size(374, 28)
        Me.lastClickTimeLabelMID.TabIndex = 9
        Me.lastClickTimeLabelMID.Text = "It's been 00 seconds since last click received"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 25.0!)
        Me.Label11.Location = New System.Drawing.Point(13, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(386, 46)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "MIDDLE MOUSE BUTTON"
        '
        'clickCountLabelMID
        '
        Me.clickCountLabelMID.Font = New System.Drawing.Font("Microsoft Sans Serif", 78.0!, System.Drawing.FontStyle.Bold)
        Me.clickCountLabelMID.Location = New System.Drawing.Point(72, 347)
        Me.clickCountLabelMID.Name = "clickCountLabelMID"
        Me.clickCountLabelMID.Size = New System.Drawing.Size(242, 114)
        Me.clickCountLabelMID.TabIndex = 9
        Me.clickCountLabelMID.Text = "00"
        Me.clickCountLabelMID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(6, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(384, 528)
        Me.Panel3.TabIndex = 11
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lastClickTimeLabelRIGHT)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Panel6)
        Me.GroupBox4.Location = New System.Drawing.Point(1144, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(410, 567)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        '
        'lastClickTimeLabelRIGHT
        '
        Me.lastClickTimeLabelRIGHT.AutoSize = True
        Me.lastClickTimeLabelRIGHT.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.lastClickTimeLabelRIGHT.Location = New System.Drawing.Point(16, 508)
        Me.lastClickTimeLabelRIGHT.Name = "lastClickTimeLabelRIGHT"
        Me.lastClickTimeLabelRIGHT.Size = New System.Drawing.Size(374, 28)
        Me.lastClickTimeLabelRIGHT.TabIndex = 9
        Me.lastClickTimeLabelRIGHT.Text = "It's been 00 seconds since last click received"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Light", 25.0!)
        Me.Label15.Location = New System.Drawing.Point(13, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(361, 46)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "RIGHT MOUSE BUTTON"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.clickCountLabelRIGHT)
        Me.Panel6.Location = New System.Drawing.Point(6, 19)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(384, 528)
        Me.Panel6.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label13.Location = New System.Drawing.Point(119, 413)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 28)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "clicks received"
        '
        'clickCountLabelRIGHT
        '
        Me.clickCountLabelRIGHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 78.0!, System.Drawing.FontStyle.Bold)
        Me.clickCountLabelRIGHT.Location = New System.Drawing.Point(67, 310)
        Me.clickCountLabelRIGHT.Name = "clickCountLabelRIGHT"
        Me.clickCountLabelRIGHT.Size = New System.Drawing.Size(242, 114)
        Me.clickCountLabelRIGHT.TabIndex = 9
        Me.clickCountLabelRIGHT.Text = "00"
        Me.clickCountLabelRIGHT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'timingEngineLEFT
        '
        Me.timingEngineLEFT.Interval = 1000
        '
        'timingEngineRIGHT
        '
        Me.timingEngineRIGHT.Interval = 1000
        '
        'latencyTestLabel_firstLeftRegisterTime
        '
        Me.latencyTestLabel_firstLeftRegisterTime.AutoSize = True
        Me.latencyTestLabel_firstLeftRegisterTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.latencyTestLabel_firstLeftRegisterTime.Location = New System.Drawing.Point(196, 8)
        Me.latencyTestLabel_firstLeftRegisterTime.Name = "latencyTestLabel_firstLeftRegisterTime"
        Me.latencyTestLabel_firstLeftRegisterTime.Size = New System.Drawing.Size(69, 16)
        Me.latencyTestLabel_firstLeftRegisterTime.TabIndex = 17
        Me.latencyTestLabel_firstLeftRegisterTime.Text = "dataFirst"
        '
        'latencyTestLabel_lastLeftRegisterTime
        '
        Me.latencyTestLabel_lastLeftRegisterTime.AutoSize = True
        Me.latencyTestLabel_lastLeftRegisterTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.latencyTestLabel_lastLeftRegisterTime.Location = New System.Drawing.Point(197, 24)
        Me.latencyTestLabel_lastLeftRegisterTime.Name = "latencyTestLabel_lastLeftRegisterTime"
        Me.latencyTestLabel_lastLeftRegisterTime.Size = New System.Drawing.Size(68, 16)
        Me.latencyTestLabel_lastLeftRegisterTime.TabIndex = 18
        Me.latencyTestLabel_lastLeftRegisterTime.Text = "dataLast"
        '
        'latencyTestLabel_leftMouseButtonLatencyResult
        '
        Me.latencyTestLabel_leftMouseButtonLatencyResult.AutoSize = True
        Me.latencyTestLabel_leftMouseButtonLatencyResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.latencyTestLabel_leftMouseButtonLatencyResult.ForeColor = System.Drawing.Color.Fuchsia
        Me.latencyTestLabel_leftMouseButtonLatencyResult.Location = New System.Drawing.Point(195, 44)
        Me.latencyTestLabel_leftMouseButtonLatencyResult.Name = "latencyTestLabel_leftMouseButtonLatencyResult"
        Me.latencyTestLabel_leftMouseButtonLatencyResult.Size = New System.Drawing.Size(95, 24)
        Me.latencyTestLabel_leftMouseButtonLatencyResult.TabIndex = 19
        Me.latencyTestLabel_leftMouseButtonLatencyResult.Text = "dataFinal"
        '
        'LatencyTestPanel
        '
        Me.LatencyTestPanel.Controls.Add(Me.Label10)
        Me.LatencyTestPanel.Controls.Add(Me.Label6)
        Me.LatencyTestPanel.Controls.Add(Me.latencyTestLabel_leftMouseButtonLatencyArithmeticAverage)
        Me.LatencyTestPanel.Controls.Add(Me.LinkLabel1)
        Me.LatencyTestPanel.Controls.Add(Me.Label5)
        Me.LatencyTestPanel.Controls.Add(Me.Label3)
        Me.LatencyTestPanel.Controls.Add(Me.Label2)
        Me.LatencyTestPanel.Controls.Add(Me.latencyTestLabel_firstLeftRegisterTime)
        Me.LatencyTestPanel.Controls.Add(Me.latencyTestLabel_leftMouseButtonLatencyResult)
        Me.LatencyTestPanel.Controls.Add(Me.latencyTestLabel_lastLeftRegisterTime)
        Me.LatencyTestPanel.Location = New System.Drawing.Point(33, 933)
        Me.LatencyTestPanel.Name = "LatencyTestPanel"
        Me.LatencyTestPanel.Size = New System.Drawing.Size(640, 118)
        Me.LatencyTestPanel.TabIndex = 20
        Me.LatencyTestPanel.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "'Arithmetic average"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label6.Location = New System.Drawing.Point(3, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Computed Latency: "
        '
        'latencyTestLabel_leftMouseButtonLatencyArithmeticAverage
        '
        Me.latencyTestLabel_leftMouseButtonLatencyArithmeticAverage.AutoSize = True
        Me.latencyTestLabel_leftMouseButtonLatencyArithmeticAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.latencyTestLabel_leftMouseButtonLatencyArithmeticAverage.ForeColor = System.Drawing.Color.Fuchsia
        Me.latencyTestLabel_leftMouseButtonLatencyArithmeticAverage.Location = New System.Drawing.Point(195, 70)
        Me.latencyTestLabel_leftMouseButtonLatencyArithmeticAverage.Name = "latencyTestLabel_leftMouseButtonLatencyArithmeticAverage"
        Me.latencyTestLabel_leftMouseButtonLatencyArithmeticAverage.Size = New System.Drawing.Size(95, 24)
        Me.latencyTestLabel_leftMouseButtonLatencyArithmeticAverage.TabIndex = 24
        Me.latencyTestLabel_leftMouseButtonLatencyArithmeticAverage.Text = "dataFinal"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(576, 11)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "RESET"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Last click registered:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "First click registered:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label2.Location = New System.Drawing.Point(5, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Current Latency: "
        '
        'debugTopmostWarn
        '
        Me.debugTopmostWarn.AutoSize = True
        Me.debugTopmostWarn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.debugTopmostWarn.ForeColor = System.Drawing.Color.Red
        Me.debugTopmostWarn.Location = New System.Drawing.Point(1643, 226)
        Me.debugTopmostWarn.Name = "debugTopmostWarn"
        Me.debugTopmostWarn.Size = New System.Drawing.Size(237, 16)
        Me.debugTopmostWarn.TabIndex = 21
        Me.debugTopmostWarn.Text = "Top most disabled during debug."
        Me.debugTopmostWarn.Visible = False
        '
        'latencyTest_fullHistoryOfProcessedDataListBox
        '
        Me.latencyTest_fullHistoryOfProcessedDataListBox.FormattingEnabled = True
        Me.latencyTest_fullHistoryOfProcessedDataListBox.Location = New System.Drawing.Point(1644, 404)
        Me.latencyTest_fullHistoryOfProcessedDataListBox.Name = "latencyTest_fullHistoryOfProcessedDataListBox"
        Me.latencyTest_fullHistoryOfProcessedDataListBox.Size = New System.Drawing.Size(224, 498)
        Me.latencyTest_fullHistoryOfProcessedDataListBox.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1643, 388)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Latency records:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Light", 25.0!)
        Me.Label14.Location = New System.Drawing.Point(6, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(401, 46)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Mouse Pointer Coordinates"
        '
        'cursorPosLabel
        '
        Me.cursorPosLabel.AutoSize = True
        Me.cursorPosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold)
        Me.cursorPosLabel.Location = New System.Drawing.Point(6, 62)
        Me.cursorPosLabel.Name = "cursorPosLabel"
        Me.cursorPosLabel.Size = New System.Drawing.Size(291, 73)
        Me.cursorPosLabel.TabIndex = 10
        Me.cursorPosLabel.Text = "000, 000"
        '
        'CursorPosTimer
        '
        Me.CursorPosTimer.Enabled = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckBox2)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.cursorPosLabel)
        Me.GroupBox5.Location = New System.Drawing.Point(18, 632)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(547, 171)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cursor Position Check"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(15, 148)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "Precise values"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1904, 1080)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.latencyTest_fullHistoryOfProcessedDataListBox)
        Me.Controls.Add(Me.debugTopmostWarn)
        Me.Controls.Add(Me.LatencyTestPanel)
        Me.Controls.Add(Me.focusLostLabel)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.scrollTestPanel)
        Me.Controls.Add(Me.scrollCountLabel)
        Me.Controls.Add(Me.scrollDirectionLabel)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "CryptedBytes Mouse Tester"
        Me.TopMost = True
        Me.scrollTestPanel.ResumeLayout(False)
        Me.scrollTestPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.LatencyTestPanel.ResumeLayout(False)
        Me.LatencyTestPanel.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timingEngineMID As Timer
    Friend WithEvents UIEngine As Timer
    Friend WithEvents focusLostLabel As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents scrollDirectionLabel As Label
    Friend WithEvents scrollCountLabel As Label
    Friend WithEvents scrollTestPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lastClickTimeLabelLEFT As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents clickCountLabelLEFT As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lastClickTimeLabelMID As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents clickCountLabelMID As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lastClickTimeLabelRIGHT As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents clickCountLabelRIGHT As Label
    Friend WithEvents timingEngineLEFT As Timer
    Friend WithEvents timingEngineRIGHT As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents latencyTestLabel_firstLeftRegisterTime As Label
    Friend WithEvents latencyTestLabel_lastLeftRegisterTime As Label
    Friend WithEvents latencyTestLabel_leftMouseButtonLatencyResult As Label
    Friend WithEvents LatencyTestPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents latencyTestLabel_leftMouseButtonLatencyArithmeticAverage As Label
    Friend WithEvents debugTopmostWarn As Label
    Friend WithEvents latencyTest_fullHistoryOfProcessedDataListBox As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents cursorPosLabel As Label
    Friend WithEvents CursorPosTimer As Timer
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
