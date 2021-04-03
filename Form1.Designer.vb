<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AFSMConfigurator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.IOCollection = New System.Windows.Forms.ListBox()
        Me.DigitalIN = New System.Windows.Forms.ListBox()
        Me.DigitalOUT = New System.Windows.Forms.ListBox()
        Me.AnalogueIN = New System.Windows.Forms.ListBox()
        Me.PWMOutput = New System.Windows.Forms.ListBox()
        Me.Ultrasonics = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DigIN = New System.Windows.Forms.TextBox()
        Me.ButtonDigIn = New System.Windows.Forms.Button()
        Me.ButtonDigOut = New System.Windows.Forms.Button()
        Me.DigOut = New System.Windows.Forms.TextBox()
        Me.ButtonUltra = New System.Windows.Forms.Button()
        Me.Ultra = New System.Windows.Forms.TextBox()
        Me.ButtonAnaIn = New System.Windows.Forms.Button()
        Me.AnaIN = New System.Windows.Forms.TextBox()
        Me.ButtonPWM = New System.Windows.Forms.Button()
        Me.PWM = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonServo = New System.Windows.Forms.Button()
        Me.Servo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Servos = New System.Windows.Forms.ListBox()
        Me.ButtonDS18B20 = New System.Windows.Forms.Button()
        Me.DS18B20 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DS18B20s = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBUseIntercard = New System.Windows.Forms.CheckBox()
        Me.CBUseGPS = New System.Windows.Forms.CheckBox()
        Me.CBUseHMISerial = New System.Windows.Forms.CheckBox()
        Me.CBUseI2C = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GenConfig = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProjectPathName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ButtonGetMetadata = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AddState = New System.Windows.Forms.Button()
        Me.NewState = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FiniteStatesListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogBox = New System.Windows.Forms.ListBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'IOCollection
        '
        Me.IOCollection.FormattingEnabled = True
        Me.IOCollection.Items.AddRange(New Object() {"AI00", "AI01", "AI02", "AI03", "AI04", "AI05", "AI06", "AI07", "AI08", "AI09", "AI10", "AI11", "AI12", "AI13", "AI14", "AI15", "D22", "D23", "D24", "D25", "D26", "D27", "D28", "D29", "D30", "D31", "D32", "D33", "D34", "D35", "D36", "D37", "D38", "D39", "D40", "D41", "D42", "D43", "D44", "D45", "D46", "D47", "D48", "D49", "D50", "D51", "D52", "D53", "PWM02", "PWM03", "PWM04", "PWM05", "PWM06", "PWM07", "PWM08", "PWM09", "PWM10", "PWM11", "PWM12"})
        Me.IOCollection.Location = New System.Drawing.Point(15, 45)
        Me.IOCollection.Margin = New System.Windows.Forms.Padding(2)
        Me.IOCollection.Name = "IOCollection"
        Me.IOCollection.Size = New System.Drawing.Size(87, 420)
        Me.IOCollection.Sorted = True
        Me.IOCollection.TabIndex = 0
        '
        'DigitalIN
        '
        Me.DigitalIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalIN.FormattingEnabled = True
        Me.DigitalIN.Location = New System.Drawing.Point(16, 43)
        Me.DigitalIN.Margin = New System.Windows.Forms.Padding(2)
        Me.DigitalIN.Name = "DigitalIN"
        Me.DigitalIN.Size = New System.Drawing.Size(184, 108)
        Me.DigitalIN.TabIndex = 1
        '
        'DigitalOUT
        '
        Me.DigitalOUT.FormattingEnabled = True
        Me.DigitalOUT.Location = New System.Drawing.Point(16, 210)
        Me.DigitalOUT.Margin = New System.Windows.Forms.Padding(2)
        Me.DigitalOUT.Name = "DigitalOUT"
        Me.DigitalOUT.Size = New System.Drawing.Size(184, 108)
        Me.DigitalOUT.TabIndex = 2
        '
        'AnalogueIN
        '
        Me.AnalogueIN.FormattingEnabled = True
        Me.AnalogueIN.Location = New System.Drawing.Point(217, 43)
        Me.AnalogueIN.Margin = New System.Windows.Forms.Padding(2)
        Me.AnalogueIN.Name = "AnalogueIN"
        Me.AnalogueIN.Size = New System.Drawing.Size(178, 108)
        Me.AnalogueIN.TabIndex = 3
        '
        'PWMOutput
        '
        Me.PWMOutput.FormattingEnabled = True
        Me.PWMOutput.Location = New System.Drawing.Point(217, 210)
        Me.PWMOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.PWMOutput.Name = "PWMOutput"
        Me.PWMOutput.Size = New System.Drawing.Size(178, 108)
        Me.PWMOutput.TabIndex = 4
        '
        'Ultrasonics
        '
        Me.Ultrasonics.FormattingEnabled = True
        Me.Ultrasonics.Location = New System.Drawing.Point(16, 375)
        Me.Ultrasonics.Margin = New System.Windows.Forms.Padding(2)
        Me.Ultrasonics.Name = "Ultrasonics"
        Me.Ultrasonics.Size = New System.Drawing.Size(184, 69)
        Me.Ultrasonics.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Digital inputs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 195)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Digital outputs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 360)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Ultrasonics"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(214, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Analogue inputs"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(214, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Pulse Witdh Modulation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(11, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "MEGA2560"
        '
        'DigIN
        '
        Me.DigIN.Location = New System.Drawing.Point(16, 155)
        Me.DigIN.Margin = New System.Windows.Forms.Padding(2)
        Me.DigIN.Name = "DigIN"
        Me.DigIN.Size = New System.Drawing.Size(140, 20)
        Me.DigIN.TabIndex = 13
        '
        'ButtonDigIn
        '
        Me.ButtonDigIn.Location = New System.Drawing.Point(156, 153)
        Me.ButtonDigIn.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDigIn.Name = "ButtonDigIn"
        Me.ButtonDigIn.Size = New System.Drawing.Size(43, 23)
        Me.ButtonDigIn.TabIndex = 14
        Me.ButtonDigIn.Text = "Add"
        Me.ButtonDigIn.UseVisualStyleBackColor = True
        '
        'ButtonDigOut
        '
        Me.ButtonDigOut.Location = New System.Drawing.Point(156, 320)
        Me.ButtonDigOut.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDigOut.Name = "ButtonDigOut"
        Me.ButtonDigOut.Size = New System.Drawing.Size(43, 23)
        Me.ButtonDigOut.TabIndex = 16
        Me.ButtonDigOut.Text = "Add"
        Me.ButtonDigOut.UseVisualStyleBackColor = True
        '
        'DigOut
        '
        Me.DigOut.Location = New System.Drawing.Point(16, 322)
        Me.DigOut.Margin = New System.Windows.Forms.Padding(2)
        Me.DigOut.Name = "DigOut"
        Me.DigOut.Size = New System.Drawing.Size(140, 20)
        Me.DigOut.TabIndex = 15
        '
        'ButtonUltra
        '
        Me.ButtonUltra.Location = New System.Drawing.Point(156, 446)
        Me.ButtonUltra.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonUltra.Name = "ButtonUltra"
        Me.ButtonUltra.Size = New System.Drawing.Size(43, 23)
        Me.ButtonUltra.TabIndex = 18
        Me.ButtonUltra.Text = "Add"
        Me.ButtonUltra.UseVisualStyleBackColor = True
        '
        'Ultra
        '
        Me.Ultra.Location = New System.Drawing.Point(16, 449)
        Me.Ultra.Margin = New System.Windows.Forms.Padding(2)
        Me.Ultra.Name = "Ultra"
        Me.Ultra.Size = New System.Drawing.Size(140, 20)
        Me.Ultra.TabIndex = 17
        '
        'ButtonAnaIn
        '
        Me.ButtonAnaIn.Location = New System.Drawing.Point(354, 153)
        Me.ButtonAnaIn.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAnaIn.Name = "ButtonAnaIn"
        Me.ButtonAnaIn.Size = New System.Drawing.Size(40, 23)
        Me.ButtonAnaIn.TabIndex = 20
        Me.ButtonAnaIn.Text = "Add"
        Me.ButtonAnaIn.UseVisualStyleBackColor = True
        '
        'AnaIN
        '
        Me.AnaIN.Location = New System.Drawing.Point(217, 155)
        Me.AnaIN.Margin = New System.Windows.Forms.Padding(2)
        Me.AnaIN.Name = "AnaIN"
        Me.AnaIN.Size = New System.Drawing.Size(134, 20)
        Me.AnaIN.TabIndex = 19
        '
        'ButtonPWM
        '
        Me.ButtonPWM.Location = New System.Drawing.Point(354, 320)
        Me.ButtonPWM.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonPWM.Name = "ButtonPWM"
        Me.ButtonPWM.Size = New System.Drawing.Size(40, 23)
        Me.ButtonPWM.TabIndex = 22
        Me.ButtonPWM.Text = "Add"
        Me.ButtonPWM.UseVisualStyleBackColor = True
        '
        'PWM
        '
        Me.PWM.Location = New System.Drawing.Point(217, 322)
        Me.PWM.Margin = New System.Windows.Forms.Padding(2)
        Me.PWM.Name = "PWM"
        Me.PWM.Size = New System.Drawing.Size(134, 20)
        Me.PWM.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.ButtonServo)
        Me.GroupBox1.Controls.Add(Me.Servo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Servos)
        Me.GroupBox1.Controls.Add(Me.ButtonDS18B20)
        Me.GroupBox1.Controls.Add(Me.DS18B20)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DS18B20s)
        Me.GroupBox1.Controls.Add(Me.ButtonPWM)
        Me.GroupBox1.Controls.Add(Me.PWM)
        Me.GroupBox1.Controls.Add(Me.ButtonAnaIn)
        Me.GroupBox1.Controls.Add(Me.AnaIN)
        Me.GroupBox1.Controls.Add(Me.ButtonUltra)
        Me.GroupBox1.Controls.Add(Me.Ultra)
        Me.GroupBox1.Controls.Add(Me.ButtonDigOut)
        Me.GroupBox1.Controls.Add(Me.DigOut)
        Me.GroupBox1.Controls.Add(Me.ButtonDigIn)
        Me.GroupBox1.Controls.Add(Me.DigIN)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Ultrasonics)
        Me.GroupBox1.Controls.Add(Me.PWMOutput)
        Me.GroupBox1.Controls.Add(Me.AnalogueIN)
        Me.GroupBox1.Controls.Add(Me.DigitalOUT)
        Me.GroupBox1.Controls.Add(Me.DigitalIN)
        Me.GroupBox1.Location = New System.Drawing.Point(161, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(583, 534)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tags/Pins (DRAG/DROP pin on tag to connect, right click to remove)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 471)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Ultrasonics use 2 digital pins"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(214, 471)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "DS18B20 sensors, use one PWM"
        '
        'ButtonServo
        '
        Me.ButtonServo.Location = New System.Drawing.Point(528, 153)
        Me.ButtonServo.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonServo.Name = "ButtonServo"
        Me.ButtonServo.Size = New System.Drawing.Size(40, 23)
        Me.ButtonServo.TabIndex = 30
        Me.ButtonServo.Text = "Add"
        Me.ButtonServo.UseVisualStyleBackColor = True
        '
        'Servo
        '
        Me.Servo.Location = New System.Drawing.Point(405, 155)
        Me.Servo.Margin = New System.Windows.Forms.Padding(2)
        Me.Servo.Name = "Servo"
        Me.Servo.Size = New System.Drawing.Size(120, 20)
        Me.Servo.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(403, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Servos"
        '
        'Servos
        '
        Me.Servos.FormattingEnabled = True
        Me.Servos.Location = New System.Drawing.Point(405, 43)
        Me.Servos.Margin = New System.Windows.Forms.Padding(2)
        Me.Servos.Name = "Servos"
        Me.Servos.Size = New System.Drawing.Size(164, 108)
        Me.Servos.TabIndex = 27
        '
        'ButtonDS18B20
        '
        Me.ButtonDS18B20.Location = New System.Drawing.Point(354, 446)
        Me.ButtonDS18B20.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDS18B20.Name = "ButtonDS18B20"
        Me.ButtonDS18B20.Size = New System.Drawing.Size(40, 23)
        Me.ButtonDS18B20.TabIndex = 26
        Me.ButtonDS18B20.Text = "Add"
        Me.ButtonDS18B20.UseVisualStyleBackColor = True
        '
        'DS18B20
        '
        Me.DS18B20.Location = New System.Drawing.Point(217, 449)
        Me.DS18B20.Margin = New System.Windows.Forms.Padding(2)
        Me.DS18B20.Name = "DS18B20"
        Me.DS18B20.Size = New System.Drawing.Size(134, 20)
        Me.DS18B20.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(214, 360)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Temp sensors"
        '
        'DS18B20s
        '
        Me.DS18B20s.FormattingEnabled = True
        Me.DS18B20s.Location = New System.Drawing.Point(217, 375)
        Me.DS18B20s.Margin = New System.Windows.Forms.Padding(2)
        Me.DS18B20s.Name = "DS18B20s"
        Me.DS18B20s.Size = New System.Drawing.Size(178, 69)
        Me.DS18B20s.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox3.Controls.Add(Me.CBUseIntercard)
        Me.GroupBox3.Controls.Add(Me.CBUseGPS)
        Me.GroupBox3.Controls.Add(Me.CBUseHMISerial)
        Me.GroupBox3.Controls.Add(Me.CBUseI2C)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(764, 21)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(179, 140)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Directives"
        '
        'CBUseIntercard
        '
        Me.CBUseIntercard.AutoSize = True
        Me.CBUseIntercard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUseIntercard.Location = New System.Drawing.Point(13, 116)
        Me.CBUseIntercard.Name = "CBUseIntercard"
        Me.CBUseIntercard.Size = New System.Drawing.Size(68, 17)
        Me.CBUseIntercard.TabIndex = 3
        Me.CBUseIntercard.Text = "Intercard"
        Me.CBUseIntercard.UseVisualStyleBackColor = True
        '
        'CBUseGPS
        '
        Me.CBUseGPS.AutoSize = True
        Me.CBUseGPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUseGPS.Location = New System.Drawing.Point(13, 93)
        Me.CBUseGPS.Name = "CBUseGPS"
        Me.CBUseGPS.Size = New System.Drawing.Size(48, 17)
        Me.CBUseGPS.TabIndex = 2
        Me.CBUseGPS.Text = "GPS"
        Me.CBUseGPS.UseVisualStyleBackColor = True
        '
        'CBUseHMISerial
        '
        Me.CBUseHMISerial.AutoSize = True
        Me.CBUseHMISerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUseHMISerial.Location = New System.Drawing.Point(13, 69)
        Me.CBUseHMISerial.Name = "CBUseHMISerial"
        Me.CBUseHMISerial.Size = New System.Drawing.Size(73, 17)
        Me.CBUseHMISerial.TabIndex = 1
        Me.CBUseHMISerial.Text = "HMI serial"
        Me.CBUseHMISerial.UseVisualStyleBackColor = True
        '
        'CBUseI2C
        '
        Me.CBUseI2C.AutoSize = True
        Me.CBUseI2C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBUseI2C.Location = New System.Drawing.Point(13, 45)
        Me.CBUseI2C.Name = "CBUseI2C"
        Me.CBUseI2C.Size = New System.Drawing.Size(42, 17)
        Me.CBUseI2C.TabIndex = 0
        Me.CBUseI2C.Text = "I2C"
        Me.CBUseI2C.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.IOCollection)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Location = New System.Drawing.Point(34, 21)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(109, 534)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Available pins"
        '
        'GenConfig
        '
        Me.GenConfig.BackColor = System.Drawing.Color.LightGray
        Me.GenConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenConfig.FlatAppearance.BorderSize = 3
        Me.GenConfig.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GenConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenConfig.Location = New System.Drawing.Point(13, 67)
        Me.GenConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.GenConfig.Name = "GenConfig"
        Me.GenConfig.Size = New System.Drawing.Size(147, 41)
        Me.GenConfig.TabIndex = 26
        Me.GenConfig.Text = "Generate new"
        Me.GenConfig.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectPathName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 661)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(997, 22)
        Me.StatusStrip1.TabIndex = 27
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProjectPathName
        '
        Me.ProjectPathName.Name = "ProjectPathName"
        Me.ProjectPathName.Size = New System.Drawing.Size(120, 17)
        Me.ProjectPathName.Text = "ToolStripStatusLabel1"
        '
        'ButtonGetMetadata
        '
        Me.ButtonGetMetadata.BackColor = System.Drawing.Color.LightGray
        Me.ButtonGetMetadata.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonGetMetadata.FlatAppearance.BorderSize = 3
        Me.ButtonGetMetadata.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonGetMetadata.Location = New System.Drawing.Point(13, 17)
        Me.ButtonGetMetadata.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonGetMetadata.Name = "ButtonGetMetadata"
        Me.ButtonGetMetadata.Size = New System.Drawing.Size(147, 41)
        Me.ButtonGetMetadata.TabIndex = 28
        Me.ButtonGetMetadata.Text = "Get old configuration"
        Me.ButtonGetMetadata.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox4.Controls.Add(Me.AddState)
        Me.GroupBox4.Controls.Add(Me.NewState)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.FiniteStatesListBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(764, 176)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(179, 237)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Finite States"
        '
        'AddState
        '
        Me.AddState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddState.Location = New System.Drawing.Point(109, 207)
        Me.AddState.Name = "AddState"
        Me.AddState.Size = New System.Drawing.Size(51, 23)
        Me.AddState.TabIndex = 3
        Me.AddState.Text = "Add"
        Me.AddState.UseVisualStyleBackColor = True
        '
        'NewState
        '
        Me.NewState.Location = New System.Drawing.Point(13, 208)
        Me.NewState.Name = "NewState"
        Me.NewState.Size = New System.Drawing.Size(90, 20)
        Me.NewState.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "START, END"
        '
        'FiniteStatesListBox
        '
        Me.FiniteStatesListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiniteStatesListBox.FormattingEnabled = True
        Me.FiniteStatesListBox.Location = New System.Drawing.Point(13, 41)
        Me.FiniteStatesListBox.Name = "FiniteStatesListBox"
        Me.FiniteStatesListBox.Size = New System.Drawing.Size(147, 160)
        Me.FiniteStatesListBox.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox5.Controls.Add(Me.GenConfig)
        Me.GroupBox5.Controls.Add(Me.ButtonGetMetadata)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(764, 430)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(179, 125)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'LogBox
        '
        Me.LogBox.FormattingEnabled = True
        Me.LogBox.Location = New System.Drawing.Point(34, 573)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ScrollAlwaysVisible = True
        Me.LogBox.Size = New System.Drawing.Size(909, 82)
        Me.LogBox.TabIndex = 32
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(676, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(9, 8)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'AFSMConfigurator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 683)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.LogBox)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AFSMConfigurator"
        Me.Text = "AFSM Configurator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IOCollection As ListBox
    Friend WithEvents DigitalIN As ListBox
    Friend WithEvents DigitalOUT As ListBox
    Friend WithEvents AnalogueIN As ListBox
    Friend WithEvents PWMOutput As ListBox
    Friend WithEvents Ultrasonics As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DigIN As TextBox
    Friend WithEvents ButtonDigIn As Button
    Friend WithEvents ButtonDigOut As Button
    Friend WithEvents DigOut As TextBox
    Friend WithEvents ButtonUltra As Button
    Friend WithEvents Ultra As TextBox
    Friend WithEvents ButtonAnaIn As Button
    Friend WithEvents AnaIN As TextBox
    Friend WithEvents ButtonPWM As Button
    Friend WithEvents PWM As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonDS18B20 As Button
    Friend WithEvents DS18B20 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DS18B20s As ListBox
    Friend WithEvents GenConfig As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ButtonServo As Button
    Friend WithEvents Servo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Servos As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonGetMetadata As Button
    Friend WithEvents ProjectPathName As ToolStripStatusLabel
    Friend WithEvents CBUseGPS As CheckBox
    Friend WithEvents CBUseHMISerial As CheckBox
    Friend WithEvents CBUseI2C As CheckBox
    Friend WithEvents CBUseIntercard As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents FiniteStatesListBox As ListBox
    Friend WithEvents AddState As Button
    Friend WithEvents NewState As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LogBox As ListBox
    Friend WithEvents GroupBox6 As GroupBox
End Class
