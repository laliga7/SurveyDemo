<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectOpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectOpt))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnView = New FontAwesome.Sharp.IconButton()
        Me.btnFill = New FontAwesome.Sharp.IconButton()
        Me.viewBtn = New System.Windows.Forms.Button()
        Me.fillBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.IconButton6)
        Me.Panel1.Controls.Add(Me.IconButton5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1146, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(495, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Munch and PTO Survey"
        '
        'IconButton6
        '
        Me.IconButton6.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconButton6.IconColor = System.Drawing.Color.RoyalBlue
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 30
        Me.IconButton6.Location = New System.Drawing.Point(1038, 0)
        Me.IconButton6.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Size = New System.Drawing.Size(56, 50)
        Me.IconButton6.TabIndex = 4
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'IconButton5
        '
        Me.IconButton5.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconButton5.IconColor = System.Drawing.Color.RoyalBlue
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 30
        Me.IconButton5.Location = New System.Drawing.Point(1094, 0)
        Me.IconButton5.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Size = New System.Drawing.Size(52, 50)
        Me.IconButton5.TabIndex = 3
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1146, 50)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.btnView)
        Me.Panel3.Controls.Add(Me.btnFill)
        Me.Panel3.Controls.Add(Me.viewBtn)
        Me.Panel3.Controls.Add(Me.fillBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1146, 477)
        Me.Panel3.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SurveyDemo.My.Resources.Resources.download__3_
        Me.PictureBox1.Location = New System.Drawing.Point(462, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.btnView.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnView.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnView.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnView.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnView.Location = New System.Drawing.Point(471, 341)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(210, 83)
        Me.btnView.TabIndex = 5
        Me.btnView.Text = "View survey results"
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnFill
        '
        Me.btnFill.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnFill.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnFill.IconChar = FontAwesome.Sharp.IconChar.File
        Me.btnFill.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnFill.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFill.Location = New System.Drawing.Point(471, 252)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(210, 83)
        Me.btnFill.TabIndex = 4
        Me.btnFill.Text = "Fill out survey"
        Me.btnFill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'viewBtn
        '
        Me.viewBtn.Location = New System.Drawing.Point(343, 351)
        Me.viewBtn.Name = "viewBtn"
        Me.viewBtn.Size = New System.Drawing.Size(0, 0)
        Me.viewBtn.TabIndex = 3
        Me.viewBtn.Text = "View survey results"
        Me.viewBtn.UseVisualStyleBackColor = True
        '
        'fillBtn
        '
        Me.fillBtn.Image = Global.SurveyDemo.My.Resources.Resources.icons8_create_64
        Me.fillBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.fillBtn.Location = New System.Drawing.Point(343, 296)
        Me.fillBtn.Name = "fillBtn"
        Me.fillBtn.Size = New System.Drawing.Size(0, 0)
        Me.fillBtn.TabIndex = 2
        Me.fillBtn.Text = "Fill out survey"
        Me.fillBtn.UseVisualStyleBackColor = True
        '
        'SelectOpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1146, 577)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelectOpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents viewBtn As Button
    Friend WithEvents fillBtn As Button
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnView As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFill As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
