
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AForge.Video
Imports AForge.Video.DirectShow


Public Class Form1

    Dim ACI As LinUDP.ACI
    Dim HostIP As String
    Dim drive1 As String
    Dim drive2 As String
    Dim drive3 As String
    Dim videoDevices As FilterInfoCollection ' List of available cameras
    Dim videoSource As VideoCaptureDevice ' Currently selected video source
    Public Shared drive As String = ""
    Dim firststart As Boolean = True


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Enabled = False
        ACI.CloseConnection()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If firststart Then
            ACI = New LinUDP.ACI()
            ACI.ClearTargetAddressList()
            If Not (TextBox3.Text = "") Then
                drive = TextBox3.Text
                ACI.SetTargetAddressList(drive, "")
            End If

            ACI.ActivateConnection(TextBox1.Text, "")
            Timer1.Enabled = True
            firststart = False
        Else
            ACI.ActivateConnection(TextBox1.Text, "")
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not (ACI.getDLLError() = "") Then
            Label7.Text = "DLL error " + ACI.getDLLError
        Else
            Label7.Text = "DLL error none"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            ' Ensure ACI is initialized
            If ACI Is Nothing Then
                ACI = New LinUDP.ACI() ' Instantiate ACI if it is null
            End If

            ' Ensure drive is valid
            If Not String.IsNullOrEmpty(drive) Then
                ' Call Homing function
                ACI.SwitchOn(drive)
            Else
                MessageBox.Show("Please provide a valid drive address.")
            End If

        Catch ex As NullReferenceException
            ' If there is no drive connected or another null reference error occurs
            MessageBox.Show("No drive is connected or the object reference is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' For any other exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check if a camera is selected in ComboBox1
        If ComboBox1.SelectedIndex >= 0 Then
            ' Get the selected camera's moniker string
            Dim selectedCameraMoniker = videoDevices(ComboBox1.SelectedIndex).MonikerString

            ' Initialize the video source using the selected camera
            videoSource = New VideoCaptureDevice(selectedCameraMoniker)

            ' Set event handler for NewFrame event to display the feed in PictureBox2
            AddHandler videoSource.NewFrame, AddressOf Video_NewFrame

            ' Start the video feed
            videoSource.Start()
        Else
            MessageBox.Show("Please select a camera from the dropdown.")
        End If

        Try
            ' Ensure ACI is initialized
            If ACI Is Nothing Then
                ACI = New LinUDP.ACI() ' Instantiate ACI if it is null
            End If

            ' Ensure drive is valid
            If Not String.IsNullOrEmpty(drive) Then
                ' Call Homing function
                ACI.Homing(drive)
            Else
                MessageBox.Show("Please provide a valid drive address.")
            End If

        Catch ex As NullReferenceException
            ' If there is no drive connected or another null reference error occurs
            MessageBox.Show("No drive is connected or the object reference is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' For any other exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Video_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        ' Display the new frame in PictureBox2
        PictureBox2.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        Try
            ' Clone the frame and display it in PictureBox2
            Dim bitmap As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            PictureBox2.Image = bitmap
        Catch ex As Exception
            MessageBox.Show("Error displaying frame: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Stop the video source if it's running
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the list of available cameras
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        ' Populate ComboBox1 with camera names
        For Each device As FilterInfo In videoDevices
            ComboBox1.Items.Add(device.Name)
        Next

        ' Set default selection if any cameras are available
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0 ' Select the first camera by default
        End If

        ' Optional: Set PictureBox to zoom mode
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if a camera is selected in ComboBox1
        If ComboBox1.SelectedIndex >= 0 Then
            ' Get the selected camera's moniker string
            Dim selectedCameraMoniker = videoDevices(ComboBox1.SelectedIndex).MonikerString

            ' Initialize the video source using the selected camera
            videoSource = New VideoCaptureDevice(selectedCameraMoniker)

            ' Set event handler for NewFrame event to display the feed in PictureBox2
            AddHandler videoSource.NewFrame, AddressOf Video_NewFrame

            ' Start the video feed
            videoSource.Start()
        Else
            MessageBox.Show("Please select a camera from the dropdown.")
        End If
        Try
            ' Ensure ACI is initialized
            If ACI Is Nothing Then
                ACI = New LinUDP.ACI() ' Instantiate ACI if it is null
            End If

            ' Ensure drive is valid
            If Not String.IsNullOrEmpty(drive) Then
                ' Call Homing function
                ACI.LMmt_MoveAbs(drive, CSng(TextBox4.Text), CSng(TextBox2.Text), CSng(TextBox6.Text), CSng(TextBox5.Text))
            Else
                MessageBox.Show("Please provide a valid drive address.")
            End If

        Catch ex As NullReferenceException
            ' If there is no drive connected or another null reference error occurs
            MessageBox.Show("No drive is connected or the object reference is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' For any other exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
