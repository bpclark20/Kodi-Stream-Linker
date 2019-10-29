<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStreamLinker
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
        Me.lblProgramDescription = New System.Windows.Forms.Label()
        Me.lblStreamURL = New System.Windows.Forms.Label()
        Me.txtStreamURL = New System.Windows.Forms.TextBox()
        Me.cmdCreateStream = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cmdClearInput = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblProgramDescription
        '
        Me.lblProgramDescription.AutoSize = True
        Me.lblProgramDescription.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramDescription.Location = New System.Drawing.Point(12, 9)
        Me.lblProgramDescription.Name = "lblProgramDescription"
        Me.lblProgramDescription.Size = New System.Drawing.Size(691, 18)
        Me.lblProgramDescription.TabIndex = 0
        Me.lblProgramDescription.Text = "This Application takes a URL to a media file as input and generates stream files " &
    "designed for Kodi. "
        '
        'lblStreamURL
        '
        Me.lblStreamURL.AutoSize = True
        Me.lblStreamURL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreamURL.Location = New System.Drawing.Point(12, 58)
        Me.lblStreamURL.Name = "lblStreamURL"
        Me.lblStreamURL.Size = New System.Drawing.Size(160, 18)
        Me.lblStreamURL.TabIndex = 1
        Me.lblStreamURL.Text = "Stream URL (http://...):"
        '
        'txtStreamURL
        '
        Me.txtStreamURL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreamURL.Location = New System.Drawing.Point(178, 55)
        Me.txtStreamURL.Name = "txtStreamURL"
        Me.txtStreamURL.Size = New System.Drawing.Size(516, 26)
        Me.txtStreamURL.TabIndex = 2
        '
        'cmdCreateStream
        '
        Me.cmdCreateStream.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreateStream.Location = New System.Drawing.Point(492, 87)
        Me.cmdCreateStream.Name = "cmdCreateStream"
        Me.cmdCreateStream.Size = New System.Drawing.Size(202, 37)
        Me.cmdCreateStream.TabIndex = 3
        Me.cmdCreateStream.Text = "Create Stream File"
        Me.cmdCreateStream.UseVisualStyleBackColor = True
        '
        'cmdClearInput
        '
        Me.cmdClearInput.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearInput.Location = New System.Drawing.Point(284, 87)
        Me.cmdClearInput.Name = "cmdClearInput"
        Me.cmdClearInput.Size = New System.Drawing.Size(202, 37)
        Me.cmdClearInput.TabIndex = 4
        Me.cmdClearInput.Text = "Reset"
        Me.cmdClearInput.UseVisualStyleBackColor = True
        '
        'frmStreamLinker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 163)
        Me.Controls.Add(Me.cmdClearInput)
        Me.Controls.Add(Me.cmdCreateStream)
        Me.Controls.Add(Me.txtStreamURL)
        Me.Controls.Add(Me.lblStreamURL)
        Me.Controls.Add(Me.lblProgramDescription)
        Me.Name = "frmStreamLinker"
        Me.Text = "Brian's Kodi Stream Link Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProgramDescription As Label
    Friend WithEvents lblStreamURL As Label
    Friend WithEvents txtStreamURL As TextBox
    Friend WithEvents cmdCreateStream As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents cmdClearInput As Button
End Class
