<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.wa = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tx_i = New System.Windows.Forms.Label()
        Me.tx = New System.Windows.Forms.Label()
        Me.mm = New System.Windows.Forms.Label()
        Me.nn = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tx_id = New System.Windows.Forms.TextBox()
        Me.tx_nu = New System.Windows.Forms.TextBox()
        Me.tx_n = New System.Windows.Forms.TextBox()
        Me.tx_p = New System.Windows.Forms.TextBox()
        Me.tx_pu = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.m = New System.Windows.Forms.GroupBox()
        CType(Me.wa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.m.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(7, 30)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ajouter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(182, 31)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "supprimet"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(94, 30)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 27)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "modifier"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(7, 68)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 27)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "export"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(94, 67)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 27)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "import"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(186, 67)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 27)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "vider"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(182, 100)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(87, 27)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "quiter"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'wa
        '
        Me.wa.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.wa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.wa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.wa.GridColor = System.Drawing.Color.Gray
        Me.wa.Location = New System.Drawing.Point(497, 6)
        Me.wa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.wa.Name = "wa"
        Me.wa.Size = New System.Drawing.Size(509, 173)
        Me.wa.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "id "
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "numero de telephone"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "nom"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "prenom"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "profession"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "num_compt"
        Me.Column6.Name = "Column6"
        '
        'tx_i
        '
        Me.tx_i.AutoSize = True
        Me.tx_i.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_i.Location = New System.Drawing.Point(33, 21)
        Me.tx_i.Name = "tx_i"
        Me.tx_i.Size = New System.Drawing.Size(33, 22)
        Me.tx_i.TabIndex = 8
        Me.tx_i.Text = "id="
        '
        'tx
        '
        Me.tx.AutoSize = True
        Me.tx.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx.Location = New System.Drawing.Point(16, 47)
        Me.tx.Name = "tx"
        Me.tx.Size = New System.Drawing.Size(144, 22)
        Me.tx.TabIndex = 9
        Me.tx.Text = "numero de telephone="
        '
        'mm
        '
        Me.mm.AutoSize = True
        Me.mm.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mm.Location = New System.Drawing.Point(36, 82)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(48, 22)
        Me.mm.TabIndex = 10
        Me.mm.Text = "nom="
        '
        'nn
        '
        Me.nn.AutoSize = True
        Me.nn.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nn.Location = New System.Drawing.Point(16, 107)
        Me.nn.Name = "nn"
        Me.nn.Size = New System.Drawing.Size(65, 22)
        Me.nn.TabIndex = 11
        Me.nn.Text = "prenom="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "profession="
        '
        'tx_id
        '
        Me.tx_id.Location = New System.Drawing.Point(109, 23)
        Me.tx_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_id.Name = "tx_id"
        Me.tx_id.Size = New System.Drawing.Size(116, 22)
        Me.tx_id.TabIndex = 13
        '
        'tx_nu
        '
        Me.tx_nu.Location = New System.Drawing.Point(166, 49)
        Me.tx_nu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_nu.Name = "tx_nu"
        Me.tx_nu.Size = New System.Drawing.Size(116, 22)
        Me.tx_nu.TabIndex = 14
        '
        'tx_n
        '
        Me.tx_n.Location = New System.Drawing.Point(109, 83)
        Me.tx_n.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_n.Name = "tx_n"
        Me.tx_n.Size = New System.Drawing.Size(116, 22)
        Me.tx_n.TabIndex = 15
        '
        'tx_p
        '
        Me.tx_p.Location = New System.Drawing.Point(112, 110)
        Me.tx_p.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_p.Name = "tx_p"
        Me.tx_p.Size = New System.Drawing.Size(116, 22)
        Me.tx_p.TabIndex = 16
        '
        'tx_pu
        '
        Me.tx_pu.Location = New System.Drawing.Point(133, 135)
        Me.tx_pu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_pu.Name = "tx_pu"
        Me.tx_pu.Size = New System.Drawing.Size(116, 22)
        Me.tx_pu.TabIndex = 17
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'm
        '
        Me.m.BackColor = System.Drawing.Color.Transparent
        Me.m.Controls.Add(Me.Button4)
        Me.m.Controls.Add(Me.Button3)
        Me.m.Controls.Add(Me.Button2)
        Me.m.Controls.Add(Me.Button1)
        Me.m.Controls.Add(Me.Button5)
        Me.m.Controls.Add(Me.Button7)
        Me.m.Controls.Add(Me.Button6)
        Me.m.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m.ForeColor = System.Drawing.Color.Red
        Me.m.Location = New System.Drawing.Point(40, 179)
        Me.m.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.m.Name = "m"
        Me.m.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.m.Size = New System.Drawing.Size(280, 123)
        Me.m.TabIndex = 34
        Me.m.TabStop = False
        Me.m.Text = "choix"
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projet_gestion_de_banque.My.Resources.Resources.téléchargement__4_
        Me.ClientSize = New System.Drawing.Size(1018, 315)
        Me.Controls.Add(Me.m)
        Me.Controls.Add(Me.tx_pu)
        Me.Controls.Add(Me.tx_p)
        Me.Controls.Add(Me.tx_n)
        Me.Controls.Add(Me.tx_nu)
        Me.Controls.Add(Me.tx_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nn)
        Me.Controls.Add(Me.mm)
        Me.Controls.Add(Me.tx)
        Me.Controls.Add(Me.tx_i)
        Me.Controls.Add(Me.wa)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "client"
        Me.Text = "d"
        CType(Me.wa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.m.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents wa As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tx_i As System.Windows.Forms.Label
    Friend WithEvents tx As System.Windows.Forms.Label
    Friend WithEvents mm As System.Windows.Forms.Label
    Friend WithEvents nn As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tx_id As System.Windows.Forms.TextBox
    Friend WithEvents tx_nu As System.Windows.Forms.TextBox
    Friend WithEvents tx_n As System.Windows.Forms.TextBox
    Friend WithEvents tx_p As System.Windows.Forms.TextBox
    Friend WithEvents tx_pu As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents m As System.Windows.Forms.GroupBox
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
