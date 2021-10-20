<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExitApplication
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.status = New System.Windows.Forms.Label()
        Me.noIcBtn = New FontAwesome.Sharp.IconButton()
        Me.yesIcBtn = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.statsulbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SurveyDemo.My.Resources.Resources.download__6_
        Me.PictureBox1.Location = New System.Drawing.Point(181, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(25, 243)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(554, 18)
        Me.ProgressBar1.TabIndex = 7
        '
        'Timer1
        '
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Font = New System.Drawing.Font("Californian FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(206, 191)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(141, 24)
        Me.status.TabIndex = 9
        Me.status.Text = "STAFF SYSTEM"
        '
        'noIcBtn
        '
        Me.noIcBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.noIcBtn.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noIcBtn.IconChar = FontAwesome.Sharp.IconChar.ToggleOff
        Me.noIcBtn.IconColor = System.Drawing.Color.Black
        Me.noIcBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.noIcBtn.Location = New System.Drawing.Point(330, 191)
        Me.noIcBtn.Name = "noIcBtn"
        Me.noIcBtn.Size = New System.Drawing.Size(107, 46)
        Me.noIcBtn.TabIndex = 10
        Me.noIcBtn.Text = "No"
        Me.noIcBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.noIcBtn.UseVisualStyleBackColor = False
        '
        'yesIcBtn
        '
        Me.yesIcBtn.BackColor = System.Drawing.Color.Red
        Me.yesIcBtn.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yesIcBtn.IconChar = FontAwesome.Sharp.IconChar.ToggleOn
        Me.yesIcBtn.IconColor = System.Drawing.Color.Black
        Me.yesIcBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.yesIcBtn.Location = New System.Drawing.Point(467, 191)
        Me.yesIcBtn.Name = "yesIcBtn"
        Me.yesIcBtn.Size = New System.Drawing.Size(112, 46)
        Me.yesIcBtn.TabIndex = 11
        Me.yesIcBtn.Text = "Yes"
        Me.yesIcBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.yesIcBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(12, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Do you want to close the allpication?"
        '
        'statsulbl
        '
        Me.statsulbl.AutoSize = True
        Me.statsulbl.Font = New System.Drawing.Font("Californian FB", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statsulbl.ForeColor = System.Drawing.SystemColors.Window
        Me.statsulbl.Location = New System.Drawing.Point(55, 24)
        Me.statsulbl.Name = "statsulbl"
        Me.statsulbl.Size = New System.Drawing.Size(279, 47)
        Me.statsulbl.TabIndex = 13
        Me.statsulbl.Text = "STAFF SYSTEM"
        '
        'ExitApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(605, 268)
        Me.Controls.Add(Me.statsulbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.yesIcBtn)
        Me.Controls.Add(Me.noIcBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExitApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExitApplication"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents status As Label
    Friend WithEvents noIcBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents yesIcBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents statsulbl As Label
End Class
