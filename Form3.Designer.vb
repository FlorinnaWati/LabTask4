<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.txtloginid = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(250, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 63)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FOODTAKE"
        '
        'name
        '
        Me.name.AutoSize = True
        Me.name.BackColor = System.Drawing.Color.Transparent
        Me.name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name.Location = New System.Drawing.Point(175, 229)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(98, 25)
        Me.name.TabIndex = 6
        Me.name.Text = "lOGIN ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-274, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "NAME:"
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.BackColor = System.Drawing.Color.Transparent
        Me.pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(175, 284)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(145, 25)
        Me.pass.TabIndex = 9
        Me.pass.Text = "PASSWORD:"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.BackColor = System.Drawing.Color.Transparent
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(175, 346)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(132, 25)
        Me.email.TabIndex = 10
        Me.email.Text = "USERNAME"
        '
        'txtloginid
        '
        Me.txtloginid.Location = New System.Drawing.Point(279, 232)
        Me.txtloginid.Name = "txtloginid"
        Me.txtloginid.Size = New System.Drawing.Size(166, 22)
        Me.txtloginid.TabIndex = 11
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(326, 284)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(166, 22)
        Me.txtpass.TabIndex = 12
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(313, 346)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(166, 22)
        Me.txtusername.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(326, 414)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "LOG IN"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(761, 585)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtloginid)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.Label1)
        Me.name = "Form3"
        Me.Text = "Reservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents name As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pass As Label
    Friend WithEvents email As Label
    Friend WithEvents txtloginid As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Button4 As Button
End Class
