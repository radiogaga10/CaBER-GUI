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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        GroupBox1 = New GroupBox()
        Button4 = New Button()
        Button5 = New Button()
        GroupBox2 = New GroupBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label8 = New Label()
        GroupBox3 = New GroupBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        ToolStrip1 = New ToolStrip()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        ComboBox1 = New ComboBox()
        Label10 = New Label()
        GroupBox4 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 65)
        Label1.TabIndex = 0
        Label1.Text = "CABER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 15)
        Label2.TabIndex = 1
        Label2.Text = "Computer IP Address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 15)
        Label3.TabIndex = 2
        Label3.Text = "Drive IP Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 15)
        Label4.TabIndex = 3
        Label4.Text = "Target Position [mm]"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 15)
        Label5.TabIndex = 4
        Label5.Text = "Deceleration [m/s^2]"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 15)
        Label6.TabIndex = 5
        Label6.Text = "Max Velocity [m/s]"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(131, 26)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(139, 61)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(131, 55)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(139, 22)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Location = New Point(12, 77)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(302, 148)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Address Settings"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(154, 106)
        Button4.Name = "Button4"
        Button4.Size = New Size(129, 23)
        Button4.TabIndex = 14
        Button4.Text = "Disconnect Drive"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(6, 106)
        Button5.Name = "Button5"
        Button5.Size = New Size(132, 23)
        Button5.TabIndex = 15
        Button5.Text = "Connect to Drive"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Location = New Point(155, 231)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(275, 179)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Go to Position"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(139, 137)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 15
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(139, 100)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 137)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 15)
        Label8.TabIndex = 14
        Label8.Text = "Acceleration [m/s^2]"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Controls.Add(Button2)
        GroupBox3.Controls.Add(Button3)
        GroupBox3.Location = New Point(12, 231)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(125, 160)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "Drive Operations"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(23, 121)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 11
        Button1.Text = "Stretch"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(23, 74)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 12
        Button2.Text = "Home"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(23, 26)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 13
        Button3.Text = "Switch On"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(610, 25)
        ToolStrip1.TabIndex = 11
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(52, 426)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(423, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(161, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(6, 22)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(244, 119)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(463, 258)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 15
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(463, 240)
        Label10.Name = "Label10"
        Label10.Size = New Size(94, 15)
        Label10.TabIndex = 17
        Label10.Text = "Choose Camera:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(PictureBox2)
        GroupBox4.Location = New Point(328, 77)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(256, 148)
        GroupBox4.TabIndex = 18
        GroupBox4.TabStop = False
        GroupBox4.Text = "Camera Feed"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(610, 450)
        Controls.Add(GroupBox4)
        Controls.Add(Label10)
        Controls.Add(ComboBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(ToolStrip1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox4 As GroupBox

End Class
