Imports System.IO
Public Class frmStreamLinker
    Dim blnValidURL As Boolean = False

    Private Sub frmStreamLinker_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Prompt if the user is attempting to overwrite a file
        SaveFileDialog1.OverwritePrompt = True

        'Setup the default file extension, and save dialog filter
        SaveFileDialog1.DefaultExt = ".strm"

        SaveFileDialog1.Filter = "Kodi Compatabile Stream Files (*.strm)|*.strm|All Files|*.*"
    End Sub

    Private Sub cmdCreateStream_Click(sender As Object, e As EventArgs) Handles cmdCreateStream.Click
        Dim strStreamURL As String = txtStreamURL.Text
        Dim strFileLocation As String
        Dim myOutput As StreamWriter

        'Determine if the URL the user entered is valid and store that as
        'blnValidURL
        blnValidURL = Uri.IsWellFormedUriString(strStreamURL, UriKind.Absolute)

        'If the user didn't enter anything or an invalid URL then...
        If txtStreamURL.Text = "" Or Not blnValidURL Then
            MessageBox.Show("Please enter a valid URL")
        Else    'Otherwise the user entered a valid URL
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName = "" Or SaveFileDialog1.FileName.Contains("?") Then   'If the user clicked cancel or didn't provide a valid filename/path
                MessageBox.Show("You didn't enter a valid filename. Please enter a valid" &
                                "filename to save to.")
            Else    'Otherwise the user saved to a valid file location
                'Take the filename/path from the SaveFileDialog box
                'and store it as strFileLocation
                strFileLocation = SaveFileDialog1.FileName

                'Open a new StreamWriter to the filename/path the user specified
                myOutput = New StreamWriter(strFileLocation)

                'A Kodi stream file only requires a single properly formatted URL to
                'a media file saved as plain text in the .strm filetype
                'so take the URL input from the textbox and make that the contents
                'of this new textfile
                myOutput.WriteLine(strStreamURL)

                'Close the output stream writer after we are done writing the file
                myOutput.Close()

                MessageBox.Show("File Successfully created.")
                clearInput()    'Clear input fields after successful file creation
            End If
        End If
        'Reset everything to nothing/false after writing the file in preparation for a
        'potential next file the user may write
        myOutput = Nothing
        strFileLocation = Nothing
        strStreamURL = Nothing
        blnValidURL = False
    End Sub

    Private Sub clearInput()
        'Fires when the user clicks the clear button or after a successful 
        'file creation
        'Reset the stream URL text box to nothing and
        'change focus to that text box.
        txtStreamURL.Text = ""
        txtStreamURL.Focus()
    End Sub

    Private Sub cmdClearInput_Click(sender As Object, e As EventArgs) Handles cmdClearInput.Click
        'When the user clicks on the clear input button
        clearInput()
    End Sub
End Class
